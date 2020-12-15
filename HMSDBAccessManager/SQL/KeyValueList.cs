using System;
using System.Collections.Generic;
using System.Linq;

namespace DBAccessManager.SQL
{
    /// <summary>
    /// class implement a Key/Value pair for persistence manager keyvaluelist
    /// </summary>
    public class KeyValueList : Dictionary<string, object>
    {
        public KeyValueList() : base(StringComparer.OrdinalIgnoreCase) { }

        public KeyValuePair<string, object> this[int index]
        {
            get { return this.ElementAt(index); }
        }

        public void Add(KeyValuePair<string, object> keyvalue)
        {
            base.Add(keyvalue.Key, keyvalue.Value);
        }
    }
}
