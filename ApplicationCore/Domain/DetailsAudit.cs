using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class DetailsAudit
    {

        public int DureAuditJour {  get; set; }
        public int Prix {  get; set; }
        public DateTime DateAudit {  get; set; }

        public virtual Audit Audit { get; set; }

        public int AuditFK { get; set; }

        public virtual Equipement Equipement { get; set; }

        public string EquipementFK { get; set; }
    }
}
