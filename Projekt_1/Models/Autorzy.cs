using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt_1.Models
{
    public class Autorzy
    {
        public int Id { get; set; }

        
        [Display(Name = "Imię:")]
        [MaxLength(50, ErrorMessage = "Zbyt długa nazwa.")]
        public string Imie { get; set; }


        [Display(Name = "Nazwisko:")]
        [MaxLength(100, ErrorMessage = "Zbyt długa nazwa.")]
        public string Nazwisko { get; set; }

        
    }
}