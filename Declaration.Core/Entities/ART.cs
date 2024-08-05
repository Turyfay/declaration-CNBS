using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Declaration.Core.Entities
{
    [Table("ARTs")]
    public class ART
    {
        [Key, Column(Order = 0)]
        [JsonPropertyName("Iddt")]
        public required string Iddt { get; set; }

        [Key, Column(Order = 1)]
        [JsonPropertyName("Nart")]
        public required int Nart { get; set; }

        [JsonPropertyName("Carttyp")]
        public required string Carttyp { get; set; }

        [JsonPropertyName("Codbenef")]
        public required string Codbenef { get; set; }

        [JsonPropertyName("Cartetamrc")]
        public string? Cartetamrc { get; set; }

        [JsonPropertyName("Iespnce")]
        public required string Iespnce { get; set; }

        [JsonPropertyName("Cartdesc")]
        public required string Cartdesc { get; set; }

        [JsonPropertyName("Cartpayori")]
        public string? Cartpayori { get; set; }

        [JsonPropertyName("Cartpayacq")]
        public string? Cartpayacq { get; set; }

        [JsonPropertyName("Cartpayprc")]
        public string? Cartpayprc { get; set; }

        [JsonPropertyName("Iddtapu")]
        public string? Iddtapu { get; set; }

        [JsonPropertyName("Nartapu")]
        public int? Nartapu { get; set; }

        [JsonPropertyName("Qartbul")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Qartbul { get; set; }

        [JsonPropertyName("Martunitar")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Martunitar { get; set; }

        [JsonPropertyName("Cartuntdcl")]
        public string? Cartuntdcl { get; set; }

        [JsonPropertyName("Qartuntdcl")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Qartuntdcl { get; set; }

        [JsonPropertyName("Cartuntest")]
        public string? Cartuntest { get; set; }

        [JsonPropertyName("Qartuntest")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Qartuntest { get; set; }

        [JsonPropertyName("Qartkgrbrt")]
        [Column(TypeName = "decimal(18,3)")]
        public decimal? Qartkgrbrt { get; set; }

        [JsonPropertyName("Qartkgrnet")]
        [Column(TypeName = "decimal(18,3)")]
        public decimal? Qartkgrnet { get; set; }

        [JsonPropertyName("Martfob")]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal Martfob { get; set; }

        [JsonPropertyName("Martfobdol")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Martfobdol { get; set; }

        [JsonPropertyName("Martfle")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Martfle { get; set; }

        [JsonPropertyName("Martass")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Martass { get; set; }

        [JsonPropertyName("Martemma")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Martemma { get; set; }

        [JsonPropertyName("Martfrai")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Martfrai { get; set; }

        [JsonPropertyName("Martajuinc")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Martajuinc { get; set; }

        [JsonPropertyName("Martajuded")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Martajuded { get; set; }

        [JsonPropertyName("Martbasimp")]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal Martbasimp { get; set; }

        
    }
}
