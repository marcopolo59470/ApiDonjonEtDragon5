using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIDonjonEtDragon.Models
{
    public class Quizz
    {
        [Key]
        public int Id_Player { get; set; }

        // Pseudo du participant  
        [Required]
        public string Pseudo { get; set; }

        // Note sur 10
        [Required]
        public int Note { get; set; }

       
    }
}