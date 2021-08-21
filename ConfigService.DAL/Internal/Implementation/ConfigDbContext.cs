using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibraries.EF.Implementation;
using ConfigService.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConfigService.DAL.Internal.Implementation
{
    internal class ConfigDbContext : BaseDbContext, IConfigDbContext
    {
        public ConfigDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ConfigRowEntity> ConfigRows { get; set; }
    }
}
