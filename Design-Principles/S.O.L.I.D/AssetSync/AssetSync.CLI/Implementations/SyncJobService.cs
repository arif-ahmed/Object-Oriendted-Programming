
using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public abstract class SyncJobService<TSouce, TTarget> : ISyncService where TSouce : IIntegrationComponent where TTarget : IIntegrationComponent
    {
        protected TSouce _souce;
        protected TTarget _target;

        public SyncJobService(TSouce souce, TTarget target)
        {
            _souce = souce;
            _target = target;
        }

        public async Task StartAsync()
        {
            await ImplementSync();
        }

        protected abstract Task ImplementSync();
    }
}
