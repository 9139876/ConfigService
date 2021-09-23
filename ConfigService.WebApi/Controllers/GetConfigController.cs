using System.Linq;
using System.Threading.Tasks;
using CommonLibraries.Config.Models;
using CommonLibraries.Core.Extensions;
using ConfigService.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ConfigService.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class GetConfigController
    {
        private readonly IConfigRepository _configRepository;

        public GetConfigController(
            IConfigRepository configRepository)
        {
            _configRepository = configRepository;
        }

        [HttpPost]
        [Route("get-config")]
        public async Task<GetConfigResponse> GetConfig([FromBody] GetConfigRequest request)
        {
            request.RequiredNotNull(nameof(request));

            var configRows = await _configRepository.GetConfigsForApplication(request);

            return new GetConfigResponse()
            {
                ConfigRows = configRows.Select(x => new ConfigRow()
                {
                    Key = x.Key,
                    Value = x.Value,
                    ParentKey = x.ParentKey
                }).ToList()
            };
        }
    }
}
