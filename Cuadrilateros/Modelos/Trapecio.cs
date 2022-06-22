using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    public sealed class Trapecio : Cuadrilatero
    {
        public Trapecio(Coordenada superiorIzquierdo, Coordenada superiorDerecho, Coordenada inferiorIzquierdo, Coordenada inferiorDerecho) 
                : base(superiorIzquierdo, superiorDerecho, inferiorIzquierdo, inferiorDerecho)
        {

        }
        public override float CalcularArea()
        {
            //Area = ((Base + base) / 2 )*h

            var base1 = PuntoInferiorDerecho.X - PuntoInferiorIzquierdo.X;
            var base2 = PuntoSuperiorDerecho.X - PuntoSuperiorIzquierdo.X;
            var h = PuntoSuperiorDerecho.Y - PuntoInferiorDerecho.Y;

            return h*((base1 + base2)/2);
        }
    }
}
