using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD_POO_Ejemplos.src.Class
{
    public class Bar
    {

        List<Persona> LisPersonas = new List<Persona>();

        public void Entrar(Persona persona)
        {
            LisPersonas.Add(persona);
            persona.Accion();
        }

    }
}
