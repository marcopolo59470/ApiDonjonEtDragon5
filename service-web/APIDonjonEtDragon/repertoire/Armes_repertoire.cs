using APIDonjonEtDragon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIDonjonEtDragon.repertoire
{
    public class Armes_repertoire
    {
        

        public Armes_repertoire()
        {
            var arme = new Armes[]
                    {
                new Armes
                {
                    Id=1,
                    Name= "Bâton",
                    VO_Name= "Quarterstaff",
                    IsGuerre= false,
                    IsDistant= false,
                    Bobo= "1D6",
                    Type_bobo= "contondant",
                    Poids= 1,
                    Prix= "2 pa",
                    Propriete= "Polyvalente(1D8)",
                    Description= "On a trouvé ca par-terre pour le mage ..."
                },

                new Armes
                {
                    Id=2,
                    Name= "Dague",
                    VO_Name= "Dagger",
                    IsGuerre= false,
                    IsDistant= false,
                    Bobo= "1D4",
                    Type_bobo= "perforant",
                    Poids= 1,
                    Prix= "2 po",
                    Propriete= "Finesse, légère, lancer (portée 6 m/18 m)",
                    Description= "Arme courte à double tranchant"
                },

                new Armes
                {
                    Id=3,
                    Name= "Arc court",
                    VO_Name= "Shortbow",
                    IsGuerre= false,
                    IsDistant= true,
                    Bobo= "1D6",
                    Type_bobo= "perforant",
                    Poids= 2,
                    Prix= "25 po",
                    Propriete= "Munitions (portée 24 m/96 m), à deux mains",
                    Description= "Arme destinée à lancer des flèches"
                },
                    };

                    
                }
            }
        }

        

       
