using HD_POO_Ejemplos.src.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD_POO_Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {

            // --------------------- .Net #1 -----------------------

            //Cerveza c = new Cerveza(5,6.5M,30);

            //c.Fermentacion();

            //Console.ReadLine();

            // --------------------- .Net #2 -----------------------

            //Herencia_Leon le = new Herencia_Leon();

            //le.Correr();
            //le.Nombre = "Simba";

            //Herencia_Buitre bu = new Herencia_Buitre();

            //bu.Volar();
            //bu.Nombre = "Condorito";

            // --------------------- .Net #3 -----------------------

            ////Herencia_Leon le = new Herencia_Leon();

            ////le.Correr(23);
            ////Console.ReadLine();

            // --------------------- .Net #4 -----------------------

            //Herencia_Leon le = new Herencia_Leon("Simba");

            //Console.WriteLine(le.GetNombre());
            //Console.ReadLine();

            // --------------------- .Net #6 -----------------------

            //Herencia_Leon le = new Herencia_Leon("Simba");

            //Console.WriteLine(le.velocidadEnMetros);
            //Console.ReadLine();

            // --------------------- .Net #7 -----------------------

            Bar bar = new Bar();
            Persona mesero = new Mesero("Chayan");
            Persona cantinero = new Cantinero("Bryan");
            Persona cliente = new Cliente("Lucas");

            bar.Entrar(mesero);
            bar.Entrar(cantinero);
            bar.Entrar(cliente);

            Console.ReadLine();


        }
    }
}
