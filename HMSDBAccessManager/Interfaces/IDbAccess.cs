using System;
using DBAccessManager.Implementations;
using HMSDBAccessManager.Implementations;

namespace DBAccessManager.Interfaces
{
    public interface IDbAccess : IPersistenceManager
    {
        string DatabaseName { get; set; }
        DBConnectionInfo Configuration { get; set; }
        void Prepare();
    }

}
