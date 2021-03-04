using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo.Src.Class
{
    class Herencia_Carro:Vehiculo
    {
        private bool _airbag;

        public Herencia_Carro(int id, string marca, string modelo, int kilometros, double precio,bool airbag)
            :base(id,marca,modelo,kilometros,precio) 
        {
          _airbag = airbag;
        }

        public bool Airbag { get => _airbag; set => _airbag = value; }

        public override double precio {

            get
            {
                if (this._airbag)
                {
                    return base.precio + 200;
                }
                else
                {
                    return base.precio;
                }
            }

            //set => base.precio = value; 
        }

        public override string ToString()
        {
            if (this._airbag)
            {
                return base.ToString() + "y Tiene Airbag";
            }
            else
            {
                return base.ToString() + "y no Tiene Airbag";
            }
        }


    }
}
