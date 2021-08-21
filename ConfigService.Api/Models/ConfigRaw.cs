using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigService.Api.Models
{
    public class ConfigRaw
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public string ParentKey { get; set; }
    }
}
