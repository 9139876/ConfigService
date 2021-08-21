﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibraries.EF.Implementation;
using ConfigService.Api.Enum;
using ConfigService.Api.Models;
using ConfigService.DAL.Entities;
using ConfigService.DAL.Internal;
using Microsoft.EntityFrameworkCore;

namespace ConfigService.DAL.Repositories.Implementation
{
    internal class ConfigRepository : BaseRepository<ConfigRawEntity>, IConfigRepository
    {
        private readonly IConfigDbContext _dbContext;

        public ConfigRepository(IConfigDbContext dbContext) : base(dbContext.ConfigRaws)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ConfigRawEntity>> GetConfigsForApplication(GetConfigRequest request)
        {
            return await DbSet.Where(x => x.Environment == request.Environment && x.Application == request.Application).ToListAsync();
        }
    }
}