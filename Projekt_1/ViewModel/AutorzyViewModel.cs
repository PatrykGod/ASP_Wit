using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projekt_1.Models;

namespace Projekt_1.ViewModel
{
    public class AutorzyViewModel
    {
        public IEnumerable<Autorzy> Autorzies { get; set; }
        public Autorzy Autorzy { get; set; }
    }
}