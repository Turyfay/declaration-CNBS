using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Declaration.Core.Entities
{
    [Table("LAQs")]
    public class LQA
    {
        [Key]
        [JsonPropertyName("Iliq")]
        public string? Iliq { get; set; }

        [JsonPropertyName("Nart")]
        public int? Nart { get; set; }

        [JsonPropertyName("Clqatax")]
        public string? Clqatax { get; set; }

        [JsonPropertyName("Clqatyp")]
        public string? Clqatyp { get; set; }

        [JsonPropertyName("Mlqabas")]
        public decimal? Mlqabas { get; set; }

        [JsonPropertyName("Qlqacoefic")]
        public decimal? Qlqacoefic { get; set; }

        [JsonPropertyName("Mlqa")]
        public decimal? Mlqa { get; set; }


    }
}
