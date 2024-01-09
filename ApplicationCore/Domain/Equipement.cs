using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public enum CategoryEquipement
    {
        Ascensceur,Machine_Impression,Serveur,Machine_Industrielle
    }
    public class Equipement
    {
        [Key]
        [Required(ErrorMessage ="La reference est un champ obligatoire")]
        public string Reference { get; set; }
        [MinLength(10, ErrorMessage = "champs doit avoir au moins 10 Caracters")]
        public string Nom {  get; set; }
        [DataType(DataType.Date)]
        public DateTime DateFabrication { get; set; }
        public CategoryEquipement TypeEquipement {  get; set; }
        public  virtual ICollection<Entreprise> Entreprise {  get; set; }
    }
}
