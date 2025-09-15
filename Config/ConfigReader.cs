using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestsharpAPI_Automation.Config
{
    public class ConfigReader
    {
        public static dynamic LoadConfig()
        {
            var json = File.ReadAllText("appsettings.json");
            return JsonConvert.DeserializeObject<dynamic>(json);
        }
    }
}
