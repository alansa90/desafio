using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class JogosS
    {
        public int Id { get; set; }

        public Paises Pais1 { get; set; }
        public int Pais1Id { get; set; }
        public int GP1 { get; set; }
        public Paises Pais2 { get; set; }
        public int Pais2Id { get; set; }
        public int GP2 { get; set; }
    }
}