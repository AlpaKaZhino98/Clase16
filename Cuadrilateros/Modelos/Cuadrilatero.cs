using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    public abstract class Cuadrilatero : Coordenada
    {
        private Coordenada _puntoSuperiorIzquierdo;
        private Coordenada _puntoSuperiorDerecho;
        private Coordenada _puntoInferiorIzquierdo;
        private Coordenada _puntoInferiorDerecho;

        public Coordenada PuntoSuperiorIzquierdo
        {
            get { return _puntoSuperiorIzquierdo; }
        }

        public Coordenada PuntoSuperiorDerecho
        {
            get { return _puntoSuperiorDerecho; }
        }

        public Coordenada PuntoInferiorIzquierdo
        {
            get { return _puntoInferiorIzquierdo; }
        }

        public Coordenada PuntoInferiorDerecho
        {
            get { return _puntoInferiorDerecho; }
        }

        public Cuadrilatero(Coordenada superiorIzquierdo, Coordenada superiorDerecho, Coordenada inferiorIzquierdo, Coordenada inferiorDerecho) : base()
        {
            _puntoSuperiorIzquierdo = superiorIzquierdo;
            _puntoSuperiorDerecho = superiorDerecho;
            _puntoInferiorIzquierdo = inferiorIzquierdo;
            _puntoInferiorDerecho = inferiorDerecho; 
        }

        public abstract float CalcularArea();
    }
}