/*
 Diseñe la siguiente jerarquía para las clases:

Cuadrilátero.
Trapecio.
Rectángulo.
Cuadrado.

Use la clase Cuadrilátero como la clase base de la jerarquía, que debe ser abstracta.
Los datos privados de la clase base deben ser las coordenadas x-y de los cuatro vértices de la figura y
debe contener un método abstracto para calcular el área.
Agregue un constructor a cada clase para inicializar sus datos e invoque el constructor de la 
clase base desde el constructor de cada clase derivada.
Escriba un programa que instancie objetos de cada una de las clases y calcule el área correspondiente. 
Investigue las fórmulas para calcular el área de cada figura.
 */

using Cuadrilateros.Modelos;

bool salir = false;
string linea;
int opcion;


while (!salir)
{
    Console.Clear();
    Console.WriteLine("---Calculo del area de cuadrilateros---");
    Console.WriteLine();
    Console.WriteLine("Elija la figura: ");
    Console.WriteLine("1 - Trapecio");
    Console.WriteLine("2 - Rectangulo");
    Console.WriteLine("3 - Cuadrado");

    linea = Console.ReadLine();
    opcion = int.Parse(linea);

    switch (opcion)
    {
        case 1:
            CalcularTrapecio();
            break;
        case 2:
            CalcularRectangulo();
            break;
        case 3:
            CalcularCuadrado();
            break;
        default:
            Console.WriteLine("Opcion no valida...");
            Console.WriteLine("Vuelva a ingresar otra opcion. (Pulse una tecla para continuar)");
            Console.ReadKey();
            continue;
    }

    Console.WriteLine("¿Quiere volver a calcular otra figura S/N?");
    linea = Console.ReadLine();

    if (linea.ToUpper() != "S")
    {
        salir = true;
    }
}

void CalcularTrapecio()
{
    Console.Clear();
    Console.WriteLine("\t     TRAPECIO");
    Console.WriteLine();
    Console.WriteLine("\t    * * ** * *");
    Console.WriteLine("\t   *          *");
    Console.WriteLine("\t  *            *");
    Console.WriteLine("\t *              *");
    Console.WriteLine("\t* * * * ** * * * *");

    Coordenada aux1 = new() , aux2 = new(), aux3 = new(), aux4 = new();

    Console.WriteLine("Ingrese el punto superior izquierdo: ");
    Console.Write("Coordenada X: ");
    aux1.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux1.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto superior derecho: ");
    Console.Write("Coordenada X: ");
    aux2.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux2.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto inferior izquierdo: ");
    Console.Write("Coordenada X: ");
    aux3.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux3.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto inferior derecho: ");
    Console.Write("Coordenada X: ");
    aux4.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux4.Y = int.Parse(Console.ReadLine());

    Trapecio trapecio = new Trapecio(aux1, aux2, aux3, aux4);

    Console.WriteLine();
    Console.WriteLine("El area del trapecio es: " + trapecio.CalcularArea());
    Console.WriteLine();
    Console.WriteLine("Pulse una tecla para continuar...");
    Console.ReadKey();
}

void CalcularRectangulo()
{
    Console.Clear();
    Console.WriteLine("\t   RECTANGULO");
    Console.WriteLine();
    Console.WriteLine("\t* * * * * * * *");
    Console.WriteLine("\t*             *");
    Console.WriteLine("\t*             *");
    Console.WriteLine("\t*             *");
    Console.WriteLine("\t* * * * * * * *");

    Coordenada aux1 = new(), aux2 = new(), aux3 = new(), aux4 = new();

    Console.WriteLine("Ingrese el punto superior izquierdo: ");
    Console.Write("Coordenada X: ");
    aux1.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux1.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto superior derecho: ");
    Console.Write("Coordenada X: ");
    aux2.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux2.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto inferior izquierdo: ");
    Console.Write("Coordenada X: ");
    aux3.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux3.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto inferior derecho: ");
    Console.Write("Coordenada X: ");
    aux4.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux4.Y = int.Parse(Console.ReadLine());

    Rectangulo rectangulo = new Rectangulo(aux1, aux2, aux3, aux4);

    Console.WriteLine();
    Console.WriteLine("El area del trapecio es: " + rectangulo.CalcularArea());
    Console.WriteLine();
    Console.WriteLine("Pulse una tecla para continuar...");
    Console.ReadKey();
}

void CalcularCuadrado()
{
    Console.Clear();
    Console.WriteLine("\t CUADRADO");
    Console.WriteLine();
    Console.WriteLine("\t* * * * *");
    Console.WriteLine("\t*       *");
    Console.WriteLine("\t*       *");
    Console.WriteLine("\t*       *");
    Console.WriteLine("\t* * * * *");

    Coordenada aux1 = new(), aux2 = new(), aux3 = new(), aux4 = new();

    Console.WriteLine("Ingrese el punto superior izquierdo: ");
    Console.Write("Coordenada X: ");
    aux1.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux1.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto superior derecho: ");
    Console.Write("Coordenada X: ");
    aux2.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux2.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto inferior izquierdo: ");
    Console.Write("Coordenada X: ");
    aux3.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux3.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el punto inferior derecho: ");
    Console.Write("Coordenada X: ");
    aux4.X = int.Parse(Console.ReadLine());
    Console.Write("Coordenada Y: ");
    aux4.Y = int.Parse(Console.ReadLine());

    Cuadrado cuadrado = new Cuadrado(aux1, aux2, aux3, aux4);

    Console.WriteLine();
    Console.WriteLine("El area del trapecio es: " + cuadrado.CalcularArea());
    Console.WriteLine();
    Console.WriteLine("Pulse una tecla para continuar...");
    Console.ReadKey();
}