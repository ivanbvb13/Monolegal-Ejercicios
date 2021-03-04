using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo.Src.Class
{
    class Concesionario
    {

        private Carro[] _carro;
        private int _limite;

        private int _countCarros;

        public Concesionario() { 
        }

        public Concesionario(int limite)
        {
            this._carro = new Carro[limite];
            _limite = limite;
            _countCarros = 0;
        }


        public void annadirCarro(Carro carro) 
        {
            if (carro!= null && _countCarros < _carro.Length) 
            {
                _carro[_countCarros] = carro;
                _countCarros++;
            }
        }

        public void mostrarCarro()
        {
            for (int i = 0; i < _countCarros; i++)
            {
                Console.WriteLine(_carro[i].ToString());
            }
        }

        public void vaciarCarro()
        {
            this._carro = new Carro[_limite];
            _countCarros = 0;
        }

        public void eliminarCarro(Carro carro)
        {
            if (carro!=null && _countCarros !=0)
            {
                int position = -1;
                for (int i = 0; i < _countCarros; i++)
                {
                    if (carro.id == _carro[i].id)
                    {
                        position = i;
                    }
                }

                if (position == -1)
                {
                    Console.WriteLine("No Existe el Carro");
                }
                else 
                {
                    _carro[position] = null;

                    for (int i = position; i < _countCarros; i++)
                    {
                        _carro[i] = _carro[i+1];
                    }

                    _countCarros--;
                }
            }
        }





    }
}
