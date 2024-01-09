using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Cabinet_Audit
    {
        [Key]
        public string Adresse;
        public string NomCabinet;
        public int NbrEmploye;
        public int NbrTotalAudit;
        public virtual ICollection<Audit> Audits { get; set; }
    }
}
