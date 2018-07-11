using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class Paises
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Paises> ListaPais()
        {
            return new List<Paises>
            {
                new Paises {Id = 0, Name = "Selecione"},
                new Paises {Id = 1, Name = "Brasil"},
                new Paises {Id = 2, Name = "França"},
                new Paises {Id = 3, Name = "Russia"},
                new Paises {Id = 4, Name = "Bélgica"},
                new Paises {Id = 5, Name = "Suécia"},
                new Paises {Id = 6, Name = "Inglaterra"},
                new Paises {Id = 7, Name = "Croácia"},
                new Paises {Id = 8, Name = "Dinamarca"}
            };
        }
    }
}