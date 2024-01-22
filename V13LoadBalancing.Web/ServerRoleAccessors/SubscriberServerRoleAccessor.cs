using Umbraco.Cms.Core.Sync;

namespace v13LoadBalancing.Web
{
    public class SubscriberServerRoleAccessor : IServerRoleAccessor
    {
        public ServerRole CurrentServerRole => ServerRole.Subscriber;
    }
}
