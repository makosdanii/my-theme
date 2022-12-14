using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using Orchard.Alias.Implementation.Map;

namespace Orchard.Alias.Implementation.Holder {
    public class AliasHolder : IAliasHolder {
        public AliasHolder() {
            _aliasMaps = new ConcurrentDictionary<string, AliasMap>(StringComparer.OrdinalIgnoreCase);
        }

        private readonly ConcurrentDictionary<string, AliasMap> _aliasMaps;

        public void SetAliases(IEnumerable<AliasInfo> aliases) {
            var grouped = aliases.GroupBy(alias => alias.Area ?? String.Empty, StringComparer.InvariantCultureIgnoreCase);

            foreach (var group in grouped) {
                var map = GetMap(group.Key);

                foreach (var alias in group) {
                    map.Insert(alias);
                }
            }
        }

        public void SetAlias(AliasInfo alias) {
            foreach (var map in _aliasMaps.Values) {
                map.Remove(alias);
            }

            GetMap(alias.Area).Insert(alias);
        }

        public IEnumerable<AliasMap> GetMaps() {
            return _aliasMaps.Values;
        }

        public AliasMap GetMap(string areaName) {
            return _aliasMaps.GetOrAdd(areaName ?? String.Empty, key => new AliasMap(key));
        }

        public void RemoveAlias(AliasInfo aliasInfo) {
            GetMap(aliasInfo.Area ?? String.Empty).Remove(aliasInfo);
        }
    }
}