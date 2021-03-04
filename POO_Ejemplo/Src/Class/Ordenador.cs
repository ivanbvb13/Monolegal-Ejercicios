using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo.Src.Class
{
    class Ordenador
    {

        private int _tamannoGB;
        private int _tamannoGBMax;
        private bool _encendido;
        private const int _TAMANNO_DEFECTO = 100;

        public Ordenador(int tannoGBMax) 
        {
            this._tamannoGB = 0;
            this._encendido = false;

            if (_tamannoGBMax < 0)
            {
                this._tamannoGBMax = _TAMANNO_DEFECTO;
            }
            else 
            {
                this._tamannoGBMax = tannoGBMax;
            }
        }

        public void annadirDatos(int datos) 
        {
            if (this._encendido)
            {
                if (datos <= 0)
                {
                    Console.WriteLine("Los GB debe ser Mayor que 0");

                }
                else
                {
                    if (this._tamannoGB + datos >= this._tamannoGBMax)
                    {
                        this._tamannoGB = this._tamannoGBMax;
                        Console.WriteLine("Disco Duro Lleno");

                    }
                    else
                    {
                        this._tamannoGB += datos;
                        Console.WriteLine("Se ha añadido Informacion, actual: " +this._tamannoGB);
                    }
                }
            }
            else 
            {
                Console.WriteLine("Debe Estar Encendido el Ordenador");
            }
        }
        public void eliminarDatos(int datos)
        {
            if (this._encendido)
            {
                if (datos <= 0)
                {
                    Console.WriteLine("Los GB debe ser Mayor que 0");

                }
                else
                {
                    if (this._tamannoGB - datos <= 0)
                    {
                        this._tamannoGB = 0;
                        Console.WriteLine("Disco Duro Vacio");

                    }
                    else
                    {
                        this._tamannoGB -= datos;
                        Console.WriteLine("Se ha Eliminado Informacion, actual: " + this._tamannoGB);
                    }
                }
            }
            else
            {
                Console.WriteLine("Debe Estar Encendido el Ordenador");
            }
        }

        public void encender()
        {
            this._encendido = true;
        }

        public void apagar()
        {
            this._encendido = false;
        }




    }
}
