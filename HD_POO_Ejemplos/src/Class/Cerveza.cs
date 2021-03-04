using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD_POO_Ejemplos.src.Class
{
    public class Cerveza
    {

        public int Amargor { get; set; }
        public decimal Alcohol { get; set; }
        public int TiempoFermentacion { get; set; }


        public Cerveza(int Amargor, decimal Alcohol, int TiempoFermentacion) 
        {
            this.Amargor = Amargor;
            this.Alcohol = Alcohol;
            this.TiempoFermentacion = TiempoFermentacion;
        }

        public void Fermentacion() 
        {
            Console.WriteLine("Se Fermento");
        }



    }
}
