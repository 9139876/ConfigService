using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigService.Api.Models;

namespace ConfigService.Api.Services
{
    public interface IGetConfigRemoteCallService
    {
        Task<GetConfigResponse> GetConfig(GetConfigRequest request);
    }
}
