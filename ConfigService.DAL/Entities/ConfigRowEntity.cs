using CommonLibraries.Config.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
