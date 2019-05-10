using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIDonjonEtDragon.Models
{
    public class Sorts
    {
        [Key]
        public int Id_sorts { get; set; }

        // C'est le nom ....  
        [Required]
        public string Name_sorts { get; set; }

        // Le nom dans la langue de TRUMP
        [Required]
        public string VO_Name_sort { get; set; }

        // mieux vaut un bon lien qu'un long discours : https://regles-donjons-dragons.com/page432.html
        [Required]
        public string Ecole { get; set; }

        // le niveau du sort
        [Required]
        public int Niveau { get; set; }

        // la durée avant que le sort pop
        [Required]
        public string Tps_incant { get; set; }

        // la distance en métre avant que le sort s'estompe
        [Required]
        public string Portée { get; set; }

        // necessite de ce concentrer?
        [Required]
        public bool IsConcentration { get; set; }

        // Durée en minute avant que le sort se termine
        [Required]
        public int Durée { get; set; } 

        // L'effet du sort
        [Required]
        public string Effet { get; set; }

        // Effet supplémentaire du sort si lancé en niveau au dessus
        public string Lvl_upg { get; set; }

        // misc
        public string Autre { get; set; }

        // Classe pouvant utiliser le sort
        [Required]
        public string Race_use { get; set; }

        // comoosants requis pour lancer le sort
        public string Composantes { get; set; }
    }
}