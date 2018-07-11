using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class QuartasViewModel
    {
        public IEnumerable<Paises> Pais { get; set; }
        public IEnumerable<JogosQ> JogosQ     { get; set; }
        public Paises Paises { get; set; }
        public JogosQ JogoQ { get; set; }

    }
}