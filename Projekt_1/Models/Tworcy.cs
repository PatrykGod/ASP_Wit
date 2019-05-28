using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_1.Models
{
    public class Tworcy
    {
        public int Id { get; set; }
        public Autorzy Autorzy { get; set; }
        public int AutorzyId { get; set; }

        public Ksiazka Ksiazka { get; set; }
        public int KsiazkaId { get; set; }


    }
}