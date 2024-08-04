using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.Core.Entities
{
    [Table("DDTs")]
    public class DDT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Iddtextr { get; set; }
        public int Cddtver { get; set; }
        public string Iddtext { get; set; }
        public string Iddt { get; set; }
        public string Iext { get; set; }
        public string Cddteta { get; set; }
        public DateTime Dddtoficia { get; set; }
        public DateTime? Dddtrectifa { get; set; }
        public string Cddtcirvis { get; set; }
        public double Qddttaxchg { get; set; }
        public string Ista { get; set; }
        public string Cddtbur { get; set; }
        public string Cddtburdst { get; set; }
        public string? Cddtdep { get; set; }
        public string? Cddtentrep { get; set; }
        public string Cddtage { get; set; }
        public string Nddtimmioe { get; set; }
        public string Lddtnomioe { get; set; }
        public string Cddtagr { get; set; }
        public string Lddtagr { get; set; }
        public string Cddtpayori { get; set; }
        public string Cddtpaidst { get; set; }
        public string Lddtnomfod { get; set; }
        public string Cddtincote { get; set; }
        public string Cddtdevfob { get; set; }
        public string? Cddtdevfle { get; set; }
        public string? Cddtdevass { get; set; }
        public string Cddttransp { get; set; }
        public string Cddtmdetrn { get; set; }
        public string Cddtpaytrn { get; set; }
        public int Nddtart { get; set; }
        public int Nddtdelai { get; set; }
        public DateTime Dddtbae { get; set; }
        public DateTime Dddtsalida { get; set; }
        public DateTime Dddtcancel { get; set; }
        public DateTime Dddtechean { get; set; }
        public string Cddtobs { get; set; }
    }
}
