using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIDonjonEtDragon.Models
{
    public class Armures
    {
        [Key]
        public int Id_armure { get; set; }

        // C'est le nom ....  
        [Required]
        public string Name_armure { get; set; }

        // Le nom dans la langue de SCHWARZENEGGER
        [Required]
        public string VO_Name_armure { get; set; }

        // Classe d'armure

        public int CA { get; set; }

        //bonus de DEX a la CA ?
        public string Bonus_CA { get; set; }

        // Minimum de FORCE pour porter l'engin
        [Required]
        public string Force { get; set; }

        // Le truc que tout le monde s'en fou dans les JDR ...
        [Required]
        public float Poids_armure { get; set; } // en Kg

        // Le truc que tout le monde fait gaffe dans les JDR ...
        [Required]
        public string Prix_armure { get; set; }

        // Wikipedia, toi-même tu sais !!!
        [Required]
        public string Description_armure { get; set; }
    }
}