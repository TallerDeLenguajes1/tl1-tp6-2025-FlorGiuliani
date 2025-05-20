// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

Console.WriteLine("Ingrese un numero: ");
string? entrada = Console.ReadLine();
int numero;
double inverso = 0;

if (int.TryParse(entrada, out numero))
{
    int cifras = entrada.Length;
    while (numero > 0)
    {
        inverso += numero % 10 * Math.Pow(10, cifras - 1);
        numero /= 10;
        cifras--;
    }
    Console.WriteLine("El inverso del numero ingresado es: " + inverso);
} else {
    Console.WriteLine("No ingresaste ningun numero");
}
