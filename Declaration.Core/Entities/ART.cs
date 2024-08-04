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
        public decimal? Qartbul { get; set; }

        [JsonPropertyName("Martunitar")]
        public decimal? Martunitar { get; set; }

        [JsonPropertyName("Cartuntdcl")]
        public string? Cartuntdcl { get; set; }

        [JsonPropertyName("Qartuntdcl")]
        public decimal? Qartuntdcl { get; set; }

        [JsonPropertyName("Cartuntest")]
        public string? Cartuntest { get; set; }

        [JsonPropertyName("Qartuntest")]
        public decimal? Qartuntest { get; set; }

        [JsonPropertyName("Qartkgrbrt")]
        public decimal? Qartkgrbrt { get; set; }

        [JsonPropertyName("Qartkgrnet")]
        public decimal? Qartkgrnet { get; set; }

        [JsonPropertyName("Martfob")]
        public required decimal Martfob { get; set; }

        [JsonPropertyName("Martfobdol")]
        public decimal? Martfobdol { get; set; }

        [JsonPropertyName("Martfle")]
        public decimal? Martfle { get; set; }

        [JsonPropertyName("Martass")]
        public decimal? Martass { get; set; }

        [JsonPropertyName("Martemma")]
        public decimal? Martemma { get; set; }

        [JsonPropertyName("Martfrai")]
        public decimal? Martfrai { get; set; }

        [JsonPropertyName("Martajuinc")]
        public decimal? Martajuinc { get; set; }

        [JsonPropertyName("Martajuded")]
        public decimal? Martajuded { get; set; }

        [JsonPropertyName("Martbasimp")]
        public required decimal Martbasimp { get; set; }

        
    }
}
