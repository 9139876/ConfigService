using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigService.Api.Enum;

namespace ConfigService.Api.Models
{
    public class GetConfigRequest
    {
        public EnvironmentEnum Environment { get; set; }

        public string Application { get; set; }
    }
}
