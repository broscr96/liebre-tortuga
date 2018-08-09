using TortugaVsLiebre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TortugaVsLiebre.Services
{
    public class AnimalService
    {
  

        public List<Animal> ObtenerAnimales()
        {
            var tortuga = new Animal()
            {
                numPatas = 4,
                tipo = "Tortuga",
                nombre = "Miguel Angel",
                foto = "/personajes/tortuga1.jpg"
            };
            var liebre = new Animal()
            {
                numPatas = 4,
                tipo = "Liebre",
                nombre = "Rocket",
                foto = "/personajes/liebre.png"
            };
            var buho = new Animal()
            {
                numPatas = 2,
                tipo = "Búho",
                nombre = "Thor",
                foto = "/personajes/buho1.jpg"
            };

            return new List<Animal> { tortuga, liebre, buho };
        }


    }
}