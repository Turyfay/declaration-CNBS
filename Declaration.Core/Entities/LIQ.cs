using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Declaration.Core.Entities
{
    [Table("LIQs")]
    public class LIQ
    {
        [Key]
        [JsonPropertyName("Iliq")]
        public required string Iliq { get; set; }

        [JsonPropertyName("Cliqdop")]
        public required string Cliqdop { get; set; }

        [JsonPropertyName("Cliqeta")]
        public required string Cliqeta { get; set; }

        [JsonPropertyName("Mliq")]
        public required decimal Mliq { get; set; }

        [JsonPropertyName("Mliqgar")]
        public required decimal Mliqgar { get; set; }

        [JsonPropertyName("Dlippay")]
        public DateTime? Dlippay { get; set; }

        [JsonPropertyName("Clipnomope")]
        public string? Clipnomope { get; set; }

        //Relation
        public required DDT DDT { get; set; }

    }
}
