using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD_POO_Ejemplos.src.Class
{
    public class Cliente: Persona
    {
        public Cliente(string nombre) : base(nombre) { }

        public override void Accion()
        {
            Console.WriteLine("Tomarse las Bebidas");
        }

    }
}
