using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public enum TypeAudit
    {
        Mensuel,Annuel
    }
    public class Audit
    {
        [Key]
        public int ReferenceAudit {  get; set; }
        public TypeAudit FrequenceAudit {  get; set; }
        public bool StatutAudit {  get; set; }
        public virtual Cabinet_Audit? Cabinet_Audit { get; set; }

        public string CabinetAuditFK { get; set; }

        public virtual ICollection<DetailsAudit> DetailsAudits { get; set; }
    }
}
