using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD_POO_Ejemplos.src.Class
{
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public virtual void Accion() { }
    }
}
