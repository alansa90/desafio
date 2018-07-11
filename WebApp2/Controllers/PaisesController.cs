using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class PaisesController : Controller
    {
        // GET: Paises
        public ActionResult Index()
        {
            var jogos = GetQuartas();
            var pais = GetPais();
            
            var quartasViewModel = new QuartasViewModel
            {
                JogosQ = jogos,
                Pais = pais,
                JogoQ = new JogosQ(),
                Paises = new Paises()
            };
            return View(quartasViewModel);
        }
        [HttpPost]
        public ActionResult Index(QuartasViewModel model)
        {
            if (model.JogoQ.Equals(null))
            {
                return View("error");
            }
            else
            {
                if (model.JogoQ.GP1 > model.JogoQ.GP2)
                {
                    var semi1 = new Paises();
                    var vencedor = model.Pais.FirstOrDefault(e => e.Id == 1);
                    semi1.Id = vencedor.Id;
                    semi1.Name = vencedor.Name;
                }
                else
                {
                    var semi1 = new Paises();
                    var vencedor = model.Pais.FirstOrDefault(e => e.Id == 2);
                    semi1.Id = vencedor.Id;
                    semi1.Name = vencedor.Name;
                }

                if (model.JogoQ.GP3 > model.JogoQ.GP4)
                {
                    var semi2 = new Paises();
                    var vencedor = model.Pais.FirstOrDefault(e => e.Id == 3);
                    semi2.Id = vencedor.Id;
                    semi2.Name = vencedor.Name;
                }
                else
                {
                    var semi2 = new Paises();
                    var vencedor = model.Pais.FirstOrDefault(e => e.Id == 4);
                    semi2.Id = vencedor.Id;
                    semi2.Name = vencedor.Name;

                }
                if (model.JogoQ.GP5 > model.JogoQ.GP6)
                {
                    var semi3 = new Paises();
                    var vencedor = model.Pais.FirstOrDefault(e => e.Id == 3);
                    semi3.Id = vencedor.Id;
                    semi3.Name = vencedor.Name;
                }
                else
                {
                    var semi3 = new Paises();
                    var vencedor = model.Pais.FirstOrDefault(e => e.Id == 4);
                    semi3.Id = vencedor.Id;
                    semi3.Name = vencedor.Name;

                }
                if (model.JogoQ.GP7 > model.JogoQ.GP8)
                {
                    var semi4 = new Paises();
                    var vencedor = model.Pais.FirstOrDefault(e => e.Id == 3);
                    semi4.Id = vencedor.Id;
                    semi4.Name = vencedor.Name;
                }
                else
                {
                    var semi4 = new Paises();
                    var vencedor = model.Pais.FirstOrDefault(e => e.Id == 4);
                    semi4.Id = vencedor.Id;
                    semi4.Name = vencedor.Name;

                }
            }


            return View();
        }
        public ActionResult Semi(Paises paises)
        {
            return View();
        }



        private IEnumerable<JogosQ> GetQuartas()
        {
            return new List<JogosQ>
            {
                new JogosQ()
                {
                    Id = 1,
                    Pais1Id = 1,
                    Pais1 = GetPais().FirstOrDefault(e=> e.Id ==1),
                    GP1= 0,
                    Pais2Id = 2,
                    Pais2 = GetPais().FirstOrDefault(e=>e.Id==2),
                    GP2=0
                },
                new JogosQ()
                {
                    Id = 2,
                    Pais3Id = 3,
                    Pais3 = GetPais().FirstOrDefault(e=> e.Id ==3),
                    GP3=0,
                    Pais4Id = 4,
                    Pais4 = GetPais().FirstOrDefault(e=>e.Id==4),
                    GP4=0
                },
                new JogosQ()
                {
                    Id = 3,
                    Pais5Id = 5,
                    Pais5 = GetPais().FirstOrDefault(e=> e.Id ==5),
                    GP5=0,
                    Pais6Id = 6,
                    Pais6 = GetPais().FirstOrDefault(e=>e.Id==6),
                    GP6=0
                },
                new JogosQ()
                {
                    Id = 4,
                    Pais7Id = 7,
                    Pais7 = GetPais().FirstOrDefault(e=> e.Id ==7),
                    GP7=0,
                    Pais8Id = 8,
                    Pais8 = GetPais().FirstOrDefault(e=>e.Id==8),
                    GP8=0
                }
            };
        }
        private IEnumerable<JogosS> GetSemi()
        {
            return new List<JogosS>
            {
                new JogosS()
                {
                    Id = 1,
                    Pais1Id = 1,
                    Pais1 = GetPais().FirstOrDefault(e=> e.Id ==1),
                    Pais2Id = 2,
                    Pais2 = GetPais().FirstOrDefault(e=>e.Id==2)
                },
                new JogosS()
                {
                    Id = 2,
                    Pais1Id = 3,
                    Pais1 = GetPais().FirstOrDefault(e=> e.Id ==1),
                    Pais2Id = 4,
                    Pais2 = GetPais().FirstOrDefault(e=>e.Id==2)
                }
            };
        }
        private IEnumerable<JogosF> GetFinal()
        {
            return new List<JogosF>
            {
                new JogosF()
                {
                    Id = 1,
                    Pais1Id = 1,
                    Pais1 = GetPais().FirstOrDefault(e=> e.Id ==1),
                    Pais2Id = 2,
                    Pais2 = GetPais().FirstOrDefault(e=>e.Id==2)
                }
            };
        }
        private IEnumerable<Paises> GetPais()
        {
            return new List<Paises>
            {
                new Paises() {Id = 1, Name = "Brasil"},
                new Paises() {Id = 2, Name = "Bélgica"},
                new Paises() {Id = 3, Name = "França"},
                new Paises() {Id = 4, Name = "Uruguai"},
                new Paises() {Id = 5, Name = "Suécia"},
                new Paises() {Id = 6, Name = "Inglaterra"},
                new Paises() {Id = 7, Name = "Croácia"},
                new Paises() {Id = 8, Name = "Russia"}

            };
        }
    }
}