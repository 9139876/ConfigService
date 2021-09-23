using System.Threading.Tasks;
using CommonLibraries.Config.Models;
using CommonLibraries.RemoteCall;
using CommonLibraries.RemoteCall.Services;
using Microsoft.Extensions.Configuration;

namespace ConfigService.Api.Services.Implementation
{
    internal class GetConfigRemoteCallService : BaseRemoteCallService, IGetConfigRemoteCallService
    {
        public GetConfigRemoteCallService(
            IConfiguration configuration,
            IRemoteCallHelperService remoteCallHelperService) : base(configuration, remoteCallHelperService) { }

        protected override string _apiSchemeAndHostConfigKey { get; set; } = "ConfigService.Api.SchemeAndHost";

        public async Task<GetConfigResponse> GetConfig(GetConfigRequest request)
            => await ExecutePostAsync<GetConfigResponse, GetConfigRequest>("api/get-config", request);
    }
}
