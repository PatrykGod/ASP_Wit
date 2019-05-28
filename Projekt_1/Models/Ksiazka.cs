using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt_1.Models
{
    public class Ksiazka
    {
        public int Id { get; set; }


        [Display(Name = "Tytuł:")]
        [MaxLength(255, ErrorMessage = "Tytuł jest zbyt długa nazwa.")]
        public string Tytul { get; set; }


        [Display(Name = "UKD:")]
        [MaxLength(50, ErrorMessage = "UKD jest zbyt długi.")]
        public string UKD { get; set; }


        [Display(Name = "Opis:")]
        public string Opis { get; set; }
    }
}