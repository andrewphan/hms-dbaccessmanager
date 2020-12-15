using System;
using System.Collections.Generic;
using HMSDBAccessManager.Implementations;

namespace DBAccessManager.Interfaces
{
    public interface IDatabaseConfiguration
    {
        IDictionary<string, DBConnectionInfo> DatabaseConfigurations { get; set; }
    }
}
