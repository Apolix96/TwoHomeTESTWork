using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dbsamicro.Models
{
    public class Micro
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string nameMicro { get; set; }
       
        [Display(Name = "цена")]
        public int priceMicro {get; set;}
      
        [Display(Name = "производитель")]
        public string manufactrure { get; set; }
        
        [Display(Name = "Серия")]
        public string Seria { get; set; }
        
        [Display(Name = "Память")]
        public int Pamyat { get; set; }
    



    }
}