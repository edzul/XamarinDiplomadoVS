using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinDiplomado.Models
{
    [DataTable("Languages")]
    public class Language
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }
        
        [JsonProperty]
        public string Imperative { get; set; }

        [JsonProperty]
        public string ObjectOriented { get; set; }

        [JsonProperty]
        public string Functional { get; set; }
        
        [JsonProperty]
        public string Procedural { get; set; }
        [JsonProperty]
        public string Generic { get; set; }
        [JsonProperty]
        public string Reflective { get; set; }
        [JsonProperty]
        public string EventDriven { get; set; }
    }
}
