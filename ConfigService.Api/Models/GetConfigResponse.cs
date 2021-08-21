using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigService.Api.Models
{
    public class GetConfigResponse
    {
        public List<ConfigRow> ConfigRows { get; set; } = new List<ConfigRow>();
    }
}
