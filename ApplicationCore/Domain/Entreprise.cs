using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Entreprise
    {
        [Key]
        public string NomEntreprise {  get; set; }
        public string AdresseEntreprise { get; set; }
        public int NbrEquipement {  get; set; }

        public virtual ICollection<Equipement> Equipements { get; set;}
    }
}
