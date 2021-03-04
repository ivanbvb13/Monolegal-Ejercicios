using POO_Ejemplo.Src.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------------------  POO #1  ---------------------------

            //Carro c = new Carro(1,"BMW","Nose",100,1200);

            //Console.WriteLine(c.precio);

            //Console.WriteLine(c.marca);

            //c.precio = 16000;

            //Console.WriteLine(c.precio);

            //Console.WriteLine(c.ToString());

            //Console.ReadLine();


            //--------------------  POO #2  ---------------------------

            //Carro c = new Carro(1, "BMW", "Nose", 100, 1200);
            //Carro c2 = new Carro(2, "Toyota", "Nose", 150, 1300);
            //Carro c3 = new Carro(3, "Nissan", "Nose", 200, 1400);
            //Carro c4 = new Carro(4, "Seat", "Nose", 250, 1500);
            //Carro c5 = new Carro(5, "Che", "Nose", 300, 1600);

            //Concesionario con = new Concesionario(10);

            //con.annadirCarro(c);
            //con.annadirCarro(c2);
            //con.annadirCarro(c3);
            //con.annadirCarro(c4);
            //con.annadirCarro(c5);

            //Console.WriteLine("Todos Los Carros");
            //con.mostrarCarro();

            //Console.WriteLine("Elimino de 2 Carros");
            //con.eliminarCarro(c);
            //con.eliminarCarro(c3);
            //con.mostrarCarro();

            //Console.WriteLine("Añadir Carro");
            //con.annadirCarro(c);


            //Console.WriteLine("Todos Los Carros");
            //con.mostrarCarro();

            //Console.WriteLine("Vacio de Carros");
            //con.vaciarCarro();
            //con.mostrarCarro();


            //Console.ReadLine();

            //--------------------  POO #3  ---------------------------

            //Aleatorios ale = new Aleatorios();

            //Console.WriteLine("20 numeros Random");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(ale.generarNumeroAleatotios(1,20));
            //}

            //Console.WriteLine("20 numeros ramdon en array");
            //int[] arr = ale.generarNumerosAleatotios(1,20,5);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " - " );
            //}

            //Console.ReadLine();


            //--------------------  POO #4  ---------------------------

            Aleatorios ale = new Aleatorios();

            //int[] _numero = ale.generarNumerosAleatotiosNoRepetidos(5,9,5);

            //if (_numero != null)
            //{
            //    for (int i = 0; i < _numero.Length; i++)
            //    {
            //        Console.WriteLine(_numero[i]);
            //    }
            //}
            //else 
            //{
            //        Console.WriteLine("Revisar Paraetros");
            //}

            //Console.ReadLine();


            //--------------------  POO #5  ---------------------------

            //Ordenador o = new Ordenador(500);

            //o.encender();

            //o.annadirDatos(200);

            //o.apagar();

            //o.eliminarDatos(100);

            //Console.ReadLine();

            //--------------------  POO #6  ---------------------------

            //ConexionAcces co = new ConexionAcces("Database.accdb");

            //co.open();

            //DataSet d = co.executeQuery("SELECT * FROM clientes");

            //foreach (DataRow row in d.Tables[0].Rows)
            //{
            //    Console.WriteLine("ID: "+row["ID"]);
            //    Console.WriteLine("Nombre: "+row["nombre"]);
            //    Console.WriteLine("Apellidos: "+row["apellidos"]);
            //    Console.WriteLine("Edad: "+row["edad"]);
            //    Console.WriteLine();

            //}

            //co.close();
            //Console.ReadLine();


            //--------------------  POO #7  ---------------------------

            Herencia_Carro hc = new Herencia_Carro(1,"BMW","Nose",100,1200,true);
            Herencia_Moto hm = new Herencia_Moto(2,"BMW","Nose",100,1000,false);

            Console.WriteLine("Precio Carro: " + hc.precio);
            Console.WriteLine("Precio Moto: " + hm.precio);


            Console.WriteLine(hc.ToString());
            Console.WriteLine(hm.ToString());

            Console.ReadLine();


        }
    }
}
