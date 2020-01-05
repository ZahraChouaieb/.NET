using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismApp.Model
{
    class Categorie
    {
        [Key]
        public int catId { get; set; }


        [Required]
        [MaxLength(128)]
        public string name { get; set; }
    }
}
