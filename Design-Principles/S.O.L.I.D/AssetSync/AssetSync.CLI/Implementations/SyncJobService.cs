
using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public abstract class SyncJobService<TSouce, TTarget> : ISyncService where TSouce : IIntegrationComponent where TTarget : IIntegrationComponent
    {
        protected TSouce source;
        protected TTarget target;

        public SyncJobService(TSouce souce, TTarget target)
        {
            this.source = souce;
            this.target = target;
        }

        public async Task StartAsync()
        {
            await ImplementSync();
        }

        protected abstract Task ImplementSync();
    }
}
