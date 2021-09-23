using System.Collections.Generic;
using System.Threading.Tasks;
using CommonLibraries.Config.Models;
using CommonLibraries.EF;
using ConfigService.DAL.Entities;

namespace ConfigService.DAL.Repositories
{
    public interface IConfigRepository : IBaseRepository<ConfigRowEntity>
    {
        Task<List<ConfigRowEntity>> GetConfigsForApplication(GetConfigRequest request);
    }
}
