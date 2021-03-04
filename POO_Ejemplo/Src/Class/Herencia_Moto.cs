using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo.Src.Class
{
    class Herencia_Moto:Vehiculo
    {

        private bool _sidecar;

        public Herencia_Moto(int id, string marca, string modelo, int kilometros, double precio, bool sidecar)
            : base(id, marca, modelo, kilometros, precio)
        {
            _sidecar = sidecar;
        }

        public bool Airbag { get => _sidecar; set => _sidecar = value; }

        public override double precio
        {

            get
            {
                if (this._sidecar)
                {
                    return base.precio + 50;
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
            if (this._sidecar)
            {
                return base.ToString() + "y Tiene Sidecar";
            }
            else
            {
                return base.ToString() + "y no Tiene Sidecar";
            }
        }


    }
}
