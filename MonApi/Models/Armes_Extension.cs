using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

// relation One-To-Many : une extension de provient que d'une arme

namespace MonApi.Models
{
    /** ceci n'est pas un DLC mais une extension pour une arme/armure
    *   par exemple une Dague de venin, l'arc magique de jean_francois, etc

    ****   */

    public class Armes_Extension
    {
        public int Id { get; set; }

             // toujours le nom du machin
        [Required]
        public string Name { get; set; }

            // Foreign Key
             // Le nom de l'équipement qui a recu une 'extension'
        [Required]
        public string IdArmes { get; set; }

            // propriété de navigation
        public Armes Armes { get; set; }

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
        public float Poids { get; set; } //en Kg   

              // Le truc que tout le monde fait gaffe dans les JDR ...
        [Required]
        public string Prix { get; set; }

             // description du bonus de l'arme (extension)
        public string Propriete { get; set; }

             // Description de aidedd.org ou de mon cerveau
        [Required]
        public string Description { get; set; }

       
    }
}
