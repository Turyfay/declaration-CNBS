using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Declaration.Core.Entities
{
    public class DataDeclaration
    {
        [JsonPropertyName("DDT")]
        public required DDT DDT { get; set; }
        //[JsonPropertyName("ART")]
        //public required List<ART> ART { get; set; }

        //[JsonPropertyName("LIQ")]
        //public required LIQ LIQ { get; set; }
        //[JsonPropertyName("LQA")]
        //public List<LQA>? LQA { get; set; }

    }
}
