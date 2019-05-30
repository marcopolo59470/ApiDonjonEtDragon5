using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIDonjonEtDragon.Models
{
    public class Damage_types
    {
        [Key]
        public string _id { get; set; }
        public int index { get; set; }
        public string name { get; set; }
        public List<string> desc { get; set; }
        public string url { get; set; }
    }
 
}