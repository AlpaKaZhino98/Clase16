using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    public class Coordenada
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordenada()
        {

        }
        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
