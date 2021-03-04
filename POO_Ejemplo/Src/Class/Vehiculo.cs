using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo.Src.Class
{
    class Vehiculo
    {

        private int _id;
        private string _marca;
        private string _modelo;
        private int _kilometros;
        private double _precio;

        public Vehiculo(int id, string marca, string modelo, int kilometros, double precio)
        {
            _id = id;
            _marca = marca;
            _modelo = modelo;
            _kilometros = kilometros;
            _precio = precio;
        }

        public int id { get => _id; set => _id = value; }
        public string marca { get => _marca; set => _marca = value; }
        public string modelo { get => _modelo; set => _modelo = value; }
        public int kilometros { get => _kilometros; set => _kilometros = value; }
        public virtual double precio { get => _precio; set => _precio = value; }


        public override string ToString()
        {
            return "Marca: " + marca + " Modelo: " + modelo + " Precio: " + precio;
        }


    }
}
