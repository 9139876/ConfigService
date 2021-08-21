using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibraries.EF;
using ConfigService.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConfigService.DAL.Internal
{
    public interface IConfigDbContext : IBaseDbContext
    {
        DbSet<ConfigRowEntity> ConfigRows { get; set; }
    }
}
