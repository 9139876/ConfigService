using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigService.Api.Enum;

namespace ConfigService.DAL.Entities
{
    [Table("ConfigRows")]
    public class ConfigRowEntity
    {
        [Key]
        public int Id { get; set; }

        public EnvironmentEnum Environment { get; set; }

        public string Application { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string ParentKey { get; set; }
    }
}
