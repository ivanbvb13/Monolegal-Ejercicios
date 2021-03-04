using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD_POO_Ejemplos.src.Class
{
    public class Cantinero: Persona
    {
        public Cantinero(string nombre) : base(nombre) { }

        public override void Accion()
        {
            Console.WriteLine("Sirve Bebidas");
        }


    }
}
