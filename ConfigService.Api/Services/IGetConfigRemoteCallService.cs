using CommonLibraries.Config.Models;
using System.Threading.Tasks;


namespace ConfigService.Api.Services
{
    public interface IGetConfigRemoteCallService
    {
        Task<GetConfigResponse> GetConfig(GetConfigRequest request);
    }
}
