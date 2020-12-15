using System;
using System.Collections.Generic;
using DBAccessManager.SQL;

namespace DBAccessManager.Interfaces
{
    public interface IPersistenceManager
    {
        string DbmsName { get; }

        int Insert(string entityName, KeyValueList insertRecords);
        int Update(string entityName, KeyValueList updateRecords);
        int Delete(string entityName, KeyValueList deleteRecord);

        List<Dictionary<string, string>> ExecuteQuery(string query, KeyValueList parameters);
    }
}
