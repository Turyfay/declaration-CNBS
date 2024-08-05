using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    [Table("DDTs")]
    public class DDT
    {
        [JsonPropertyName("Iddtextr")]
        public required string Iddtextr { get; set; }

        [JsonPropertyName("Cddtver")]
        public required int Cddtver { get; set; }

        [JsonPropertyName("Iddtext")]
        public required string Iddtext { get; set; }
        [Key]
        [JsonPropertyName("Iddt")]
        public required string Iddt { get; set; }

        [JsonPropertyName("Iext")]
        public string? Iext { get; set; }

        [JsonPropertyName("Cddteta")]
        public required string Cddteta { get; set; }

        [JsonPropertyName("Dddtoficia")]
        public required DateTime Dddtoficia { get; set; }

        [JsonPropertyName("Dddtrectifa")]
        public DateTime? Dddtrectifa { get; set; }

        [JsonPropertyName("Cddtcirvis")]
        public string? Cddtcirvis { get; set; }

        [JsonPropertyName("Qddttaxchg")]
        [Column(TypeName = "decimal(12,6)")]
        public required decimal Qddttaxchg { get; set; }

        [JsonPropertyName("Ista")]
        public required string Ista { get; set; }

        [JsonPropertyName("Cddtbur")]
        public required string Cddtbur { get; set; }

        [JsonPropertyName("Cddtburdst")]
        public string? Cddtburdst { get; set; }

        [JsonPropertyName("Cddtdep")]
        public string? Cddtdep { get; set; }

        [JsonPropertyName("Cddtentrep")]
        public string? Cddtentrep { get; set; }

        [JsonPropertyName("Cddtage")]
        public required string Cddtage { get; set; }

        [JsonPropertyName("Cddtagr")]
        public string? Cddtagr { get; set; }

        [JsonPropertyName("Lddtagr")]
        public string? Lddtagr { get; set; }

        [JsonPropertyName("Nddtimmioe")]
        public required string Nddtimmioe { get; set; }

        [JsonPropertyName("Lddtnomioe")]
        public required string Lddtnomioe { get; set; }

        [JsonPropertyName("Cddtpayori")]
        public string? Cddtpayori { get; set; }

        [JsonPropertyName("Cddtpaidst")]
        public string? Cddtpaidst { get; set; }

        [JsonPropertyName("Lddtnomfod")]
        public string? Lddtnomfod { get; set; }

        [JsonPropertyName("Cddtincote")]
        public string? Cddtincote { get; set; }

        [JsonPropertyName("Cddtdevfob")]
        public required string Cddtdevfob { get; set; }

        [JsonPropertyName("Cddtdevfle")]
        public string? Cddtdevfle { get; set; }

        [JsonPropertyName("Cddtdevass")]
        public string? Cddtdevass { get; set; }

        [JsonPropertyName("Cddttransp")]
        public string? Cddttransp { get; set; }

        [JsonPropertyName("Cddtmdetrn")]
        public string? Cddtmdetrn { get; set; }

        [JsonPropertyName("Cddtpaytrn")]
        public string? Cddtpaytrn { get; set; }

        [JsonPropertyName("Nddtart")]
        public required int Nddtart { get; set; }

        [JsonPropertyName("Nddtdelai")]
        public int? Nddtdelai { get; set; }

        [JsonPropertyName("Dddtbae")]
        public DateTime? Dddtbae { get; set; }

        [JsonPropertyName("Dddtsalida")]
        public DateTime? Dddtsalida { get; set; }

        [JsonPropertyName("Dddtcancel")]
        public DateTime? Dddtcancel { get; set; }

        [JsonPropertyName("Dddtechean")]
        public DateTime? Dddtechean { get; set; }

        [JsonPropertyName("Cddtobs")]
        public string? Cddtobs { get; set; }

        public LIQ LIQ { get; set; }

        public ICollection<ART> ARTS { get; set; }
    }
}
