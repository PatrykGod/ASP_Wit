using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt_1.Models
{
    public class Wydanie
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "ISBN:")]
        public string ISBN { get; set; }


        [Display(Name = "Rok Wydania:")]
        [MaxLength(4, ErrorMessage = "Zbyt długa nazwa.")]
        public string rokWydania { get; set; }


        [Display(Name = "Numer Wydania:")]
        [MaxLength(20, ErrorMessage = "Zbyt długa nazwa.")]
        public string numerWydania { get; set; }


        [Display(Name = "Liczba Stron:")]
        [MaxLength(20, ErrorMessage = "Zbyt długa nazwa.")]
        public string liczbaStron { get; set; }


        [Display(Name = "Zdjęcie:")]
        public string zdjecieNazwa { get; set; }


        [Display(Name = "Książka wydania:")]
        public int KsiazkaId { get; set; }
        public Ksiazka Ksiazka { get; set; }

        [Display(Name = "Wydawnictwo wydania:")]
        public int WydawnictwoId { get; set; }
        public Wydawnictwo Wydawanictwo { get; set; }
    }
}