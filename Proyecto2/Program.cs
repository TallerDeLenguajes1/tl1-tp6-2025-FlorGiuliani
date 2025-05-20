// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

int sumar (int num1, int num2)
{
    return num1 + num2;
}

int restar (int num1, int num2)
{
    return num1 - num2;
}

int multiplicar (int num1, int num2)
{
    return num1 * num2;
}

int dividir (int num1, int num2)
{
    return num1 / num2;
}

int ingresarNumeros()
{
    string? respuesta;
    int num;
    do
    {
        Console.WriteLine("Ingresa un numero: ");
        respuesta = Console.ReadLine();
    } while (!int.TryParse(respuesta, out num));
    return num;
}

bool repetir()
{
    string? respuesta;
    int num;
    do
    {
        Console.WriteLine("\nDesear realizar otra operacion? Si(1) No(0)");
        respuesta = Console.ReadLine();
    } while (!int.TryParse(respuesta, out num));
    return num == 1;
}




int resultado = 0;
string? respuesta;
int respuestaNumero = 5;
int num1, num2;

do {
    Console.WriteLine("--------MENU--------");
    Console.WriteLine("(1) Sumar");
    Console.WriteLine("(2) Restar");
    Console.WriteLine("(3) Multiplicar");
    Console.WriteLine("(4) Dividir");
    Console.WriteLine("(5) Salir");


    Console.WriteLine("Seleccione la opción a realizar: ");
    respuesta = Console.ReadLine();
    if (int.TryParse(respuesta, out respuestaNumero))
    {
        switch (respuestaNumero)
        {
            case 1:
                num1 = ingresarNumeros();
                num2 = ingresarNumeros();
                resultado = sumar(num1, num2);
                break;
            case 2:
                num1 = ingresarNumeros();
                num2 = ingresarNumeros();
                resultado = restar(num1, num2);
                break;
            case 3:
                num1 = ingresarNumeros();
                num2 = ingresarNumeros();
                resultado = multiplicar(num1, num2);
                break;
            case 4:
                num1 = ingresarNumeros();
                num2 = ingresarNumeros();
                resultado = dividir(num1, num2);
                break;
            default:
                break;
        }
        Console.Write("El resultado es: " + resultado);
    }

} while (repetir());
