using System;
using DBAccessManager.Interfaces;

namespace DBAccessManager
{
    /// <summary>
    /// class PersistenceFactory creates a Facades for the databases
    /// </summary>
    public sealed class PersistenceFactory
    {
        public PersistenceFactory()
        {
        }

        public static IPersistenceManager GetDatabase(string dbName)
        {
            IPersistenceManager manager = new PersistenceManager(dbName);
            return manager;
        }
    }
}
