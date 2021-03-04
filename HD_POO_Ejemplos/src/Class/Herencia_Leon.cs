using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD_POO_Ejemplos.src.Class
{
    public class Herencia_Leon:Herencia_Animal_Carnivoro
    {
        public string ColorCabello { get; set; }
        private int VelocidadDefecto = 20;

        public int Velocidad
        {
            get
            {
                return VelocidadDefecto;
            }
            set
            {
                if (value <= 0)
                {
                    value = 1;
                    VelocidadDefecto = value;
                }
            }
            
        }

        public string velocidadEnMetros
        {
            get
            {
                return "La velocidad en metros es: " + VelocidadDefecto * 1000;
            }
        }

        public override string GetNombre()
        {
            return "Soy Un Leon Llamado: " + Nombre;
        }

        public Herencia_Leon(string nombre)
        {
            this.Nombre = nombre;
        }
        public void Correr()
        {
            Console.WriteLine("Corriendo a: " + VelocidadDefecto +" K/H");
        }

        public void Correr(int velocidad)
        {
            Console.WriteLine("Corriendo a: " + velocidad + " K/H");
        }

    }
}
