using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo.Src.Class
{
    class Aleatorios
    {

        private Random _random;

        public Aleatorios() 
        {
            this._random = new Random();
        }


        public int generarNumeroAleatotios(int min, int max) 
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }
            return this._random.Next(min,max+1);
        }

        public int[] generarNumerosAleatotios(int min, int max, int longitud)
        {
            if (longitud <= 0)
            {
                return null;
            }
            int[] _numeros = new int[longitud];

            for (int i = 0; i < _numeros.Length; i++)
            {
                _numeros[i] = generarNumeroAleatotios(min,max);
            }

            return _numeros;
        }

        public int[] generarNumerosAleatotiosNoRepetidos(int min, int max, int longitud)
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }

            if (longitud <= 0 || (max-min) < longitud-1)
            {
                return null;
            }
            int[] _numeros = new int[longitud];

            bool _repetido;
            int _numero;
            int _indice = 0;

            while (_indice < _numeros.Length)
            {
                _repetido = false;

                _numero = generarNumeroAleatotios(min,max);

                for (int i = 0; i < _indice; i++)
                {
                    if (_numeros[i]==_numero)
                    {
                        _repetido = true;
                    }
                }

                if (!_repetido)
                {
                    _numeros[_indice] = _numero;
                    _indice++;
                }

            }

            return _numeros;
        }

    }
}
