using System;
using System.Collections.Generic;
using DBAccessManager;
using DBAccessManager.Interfaces;
using DBAccessManager.SQL;

namespace HMSDBAccessManager_Test
{
    /// <summary>
    /// class introduce the asumption on my implementation and how to call
    /// the corresponding methods 
    /// </summary>
    class PersistenceManagerTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var query = "";
            var parameters = new KeyValueList();
            IPersistenceManager persist = PersistenceFactory.GetDatabase("MYSQL");
            List<Dictionary<string, string>> result = persist.ExecuteQuery(query, parameters);
        }
    }
}
