using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    public sealed class Cuadrado : Cuadrilatero
    {
        public Cuadrado(Coordenada superiorIzquierdo, Coordenada superiorDerecho, Coordenada inferiorIzquierdo, Coordenada inferiorDerecho)
            : base(superiorIzquierdo, superiorDerecho, inferiorIzquierdo, inferiorDerecho)
        {

        }
        public override float CalcularArea()
        {
            //Area = lado al cuadrado
            //Resto la componente X de dos lados adyacentes
            var lado = PuntoSuperiorDerecho.X - PuntoSuperiorIzquierdo.X;

            return lado*lado;
        }
    }
}