using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD_POO_Ejemplos.src.Class
{
    public class Animal
    {

        public string Nombre { get; set; }

       public virtual string GetNombre()
        {
            return Nombre;
        }
    }
}
