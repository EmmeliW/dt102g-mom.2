using System;
using System.ComponentModel.DataAnnotations;
namespace MVC.Models

{
    public class KindThings
    {        
        [Required(ErrorMessage = "Du måste skiva i")]
        [MinLength(5)]
        public string Thing { get; set; }
        [Required(ErrorMessage = "Du måste välja färg")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Du måste välja textfärg")]
        public string Textcolor { get; set; }
        public KindThings() 
        {

        }
    }        
} 