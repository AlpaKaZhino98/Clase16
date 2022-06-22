using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    public sealed class Rectangulo : Cuadrilatero
    {
        public Rectangulo(Coordenada superiorIzquierdo, Coordenada superiorDerecho, Coordenada inferiorIzquierdo, Coordenada inferiorDerecho)
            : base(superiorIzquierdo, superiorDerecho, inferiorIzquierdo, inferiorDerecho)
        {

        }
        public override float CalcularArea()
        {
            //Area = base * altura
            var baseRect = PuntoInferiorDerecho.X - PuntoInferiorIzquierdo.X; ;
            var altura = PuntoSuperiorDerecho.Y - PuntoInferiorDerecho.Y;

            return baseRect * altura;

        }
    }
}
