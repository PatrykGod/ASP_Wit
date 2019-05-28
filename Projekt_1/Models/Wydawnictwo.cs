using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt_1.Models
{
    public class Wydawnictwo
    {
        public int Id { get; set; }


        [Display(Name = "Nazwa wydawnictwa:")]
        [MaxLength(255, ErrorMessage = "Zbyt długa nazwa.")]
        public string NazwaWydawnictwa { get; set; }


        [MaxLength(15, ErrorMessage = "Skrót")]
        public string Skrot { get; set; }


        [MaxLength(50, ErrorMessage = "Kraj")]
        public string Kraj { get; set; }


        [MaxLength(50, ErrorMessage = "Miejscowość")]
        public string Miejscowosc { get; set; }


        [MaxLength(50, ErrorMessage = "Kod pocztowy")]
        public string kodPocztowy { get; set; }


        [MaxLength(50, ErrorMessage = "Ulica")]
        public string Ulica { get; set; }


        [MaxLength(15, ErrorMessage = "Numer Telefonu")]
        public string numerTelefonu { get; set; }


        [MaxLength(100, ErrorMessage = "E-mail")]
        public string eMail { get; set; }


        [MaxLength(100, ErrorMessage = "Strona WWW")]
        public string stronaWWW { get; set; }
    }
}