using Umbraco.Cms.Core.Sync;

namespace v13LoadBalancing.Web
{
    public class SchedulingPublisherServerRoleAccessor : IServerRoleAccessor
    {
        public ServerRole CurrentServerRole => ServerRole.SchedulingPublisher;
    }
}