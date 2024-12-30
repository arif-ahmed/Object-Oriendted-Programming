using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetSync.CLI.Contracts
{
    //public interface ISyncService<TSource, TTarget> where TSource : IIntegrationComponent where TTarget : IIntegrationComponent
    //{
    //    Task StartAsync();
    //}

    public interface ISyncService
    {
        Task StartAsync();
    }
}
