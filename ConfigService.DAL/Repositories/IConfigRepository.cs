using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibraries.EF;
using ConfigService.Api.Enum;
using ConfigService.Api.Models;
using ConfigService.DAL.Entities;

namespace ConfigService.DAL.Repositories
{
    public interface IConfigRepository : IBaseRepository<ConfigRawEntity>
    {
        Task<List<ConfigRawEntity>> GetConfigsForApplication(GetConfigRequest request);
    }
}
