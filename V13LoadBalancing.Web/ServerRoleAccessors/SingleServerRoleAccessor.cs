using Umbraco.Cms.Core.Sync;

namespace v13LoadBalancing.Web
{
    public class SingleServerRoleAccessor : IServerRoleAccessor
    {
        public ServerRole CurrentServerRole => ServerRole.Single;
    }
}