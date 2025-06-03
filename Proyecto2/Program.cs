// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

/*int sumar (int num1, int num2)
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
}*/

double valorAbsoluto (double num)
{
    if (num < 0) {
        return (-1) * num;
    }
    else {
        return num;
    }
}

double cuadrado (double num)
{
    return num * num;
}

double raizCuadrada (double num)
{
    return Math.Sqrt(num);
}

double seno (double num)
{
    return Math.Sin(num);
}

double coseno (double num)
{
    return Math.Cos(num);
}

int parteEntera (double num)
{
    return (int)Math.Truncate(num);
}

void maximoYMinimo (int num1, int num2)
{
    if (num1 > num2) {
        Console.Write("El Maximo es: " + num1);
        Console.Write("\nEl Minimo es: " + num2);
    }
    else {
        Console.Write("El Maximo es: " + num2);
        Console.Write("\nEl Minimo es: " + num1);
    }
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

double ingresarNumerosDouble()
{
    string? respuesta;
    double num;
    do
    {
        Console.WriteLine("Ingresa un numero: ");
        respuesta = Console.ReadLine();
    } while (!double.TryParse(respuesta, out num));
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




double resultado = 0;
string? respuesta;
int respuestaNumero = 8;
int num1, num2;
double num;

do {
    Console.WriteLine("--------MENU--------");
    Console.WriteLine("(1) Valor Absoluto");
    Console.WriteLine("(2) Cuadrado");
    Console.WriteLine("(3) Raiz Cuadrada");
    Console.WriteLine("(4) Seno");
    Console.WriteLine("(5) Coseno");
    Console.WriteLine("(6) Parte Entera");
    Console.WriteLine("(7) Maximo y Minimo");
    Console.WriteLine("(8) Salir");


    Console.WriteLine("Seleccione la opción a realizar: ");
    respuesta = Console.ReadLine();
    if (int.TryParse(respuesta, out respuestaNumero))
    {
        switch (respuestaNumero)
        {
            case 1:
                num = ingresarNumerosDouble();
                resultado = valorAbsoluto(num);
                Console.Write("El resultado es: " + resultado);
                break;
            case 2:
                num = ingresarNumerosDouble();
                resultado = cuadrado(num);
                Console.Write("El resultado es: " + resultado);
                break;
            case 3:
                num = ingresarNumerosDouble();
                resultado = raizCuadrada(num);
                Console.Write("El resultado es: " + resultado);
                break;
            case 4:
                num = ingresarNumerosDouble();
                resultado = seno(num);
                Console.Write("El resultado es: " + resultado);
                break;
            case 5:
                num = ingresarNumerosDouble();
                resultado = coseno(num);
                Console.Write("El resultado es: " + resultado);
                break;
            case 6:
                num = ingresarNumerosDouble();
                resultado = parteEntera(num);
                Console.Write("El resultado es: " + resultado);
                break;
            case 7:
                num1 = ingresarNumeros();
                num2 = ingresarNumeros();
                maximoYMinimo(num1,num2);
                break;  
            default:
                break;
        }
    }

} while (respuestaNumero != 8 && repetir());
