using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MonApi.Models
{
    public class Armes
    {
        public int Id { get; set; }

             // C'est le nom ....  
        [Required]
        public string Name { get; set; }

             // arme de guerre? (sinon courant)
        [Required]
        public bool IsGuerre { get; set; }

             // arme à distance? (sinon ben pas distance)
        [Required]
        public bool IsDistant { get; set; }

             // Le nom dans la langue de SCHWARZENEGGER
        [Required]
        public string VO_Name { get; set; }

            // Les dés de degats de l'arme
        [Required]
        public string Bobo { get; set; }

             // Le type de degats infligés - contondant/tranchant/perforant et plus si affinitée
        [Required]
        public string Type_bobo { get; set; }

             // Le truc que tout le monde s'en fou dans les JDR ...
        [Required]
        public string Poids { get; set; } // en Kg

             // Le truc que tout le monde fait gaffe dans les JDR ...
        [Required]
        public string Prix { get; set; }

             // lisez-ca : https://www.aidedd.org/regles/equipement/armes/ !!! Merci
        public string Propriete { get; set; }

             // Wikipedia, toi-même tu sais !!!
        [Required]
        public string Description { get; set; }
    }
}