// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

string ingresarCadena(string mensaje)
{
    string? respuesta;
    do {
        Console.WriteLine(mensaje);
        respuesta = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(respuesta)); //verifico si es nula o esta vacia
    return respuesta;
}

int longitud(string cadena)
{
    return cadena.Length;
}

string concatenar(string cadena1, string cadena2)
{
    return string.Concat(cadena1, " ", cadena2);
    //string nombreCompleto = saludo + nombre; // Usando el operador +
    //string mensajeCompleto = string.Concat(saludo, nombre, "!"); // Usando el método Concat
    //string interpolacion = $"{saludo}{nombre}!";
}

int ingresarNumeros(string mensaje)
{
    string? respuesta;
    int num;
    do {
        Console.WriteLine(mensaje);
        respuesta = Console.ReadLine();
    } while (!int.TryParse(respuesta, out num));
    return num;
}

string extraerSubcadena(string cadena, int posicionInicial, int longitudSubcadena)
{
    string subcadena;
    if (longitudSubcadena < 0 || posicionInicial + longitudSubcadena > longitud(cadena))
    {
        subcadena = cadena.Substring(posicionInicial);
    }
    else
    {
        subcadena = cadena.Substring(posicionInicial, longitudSubcadena);
    }
    return subcadena;
}

void recorrerCadena(string cadena)
{
    foreach (char caracter in cadena)
    {
        Console.WriteLine(caracter);
    }
}

int ocurrenciaPalabra(string cadena, string palabra)
{
    int n = 0;
    int indice = 0;
    int posicion = cadena.IndexOf(palabra, indice, StringComparison.OrdinalIgnoreCase);
    //StringComparison.OrdinalIgnoreCase para ignorar mayusculas y minusculas
    while (posicion != -1)
    {
        n++;
        indice = posicion + 1;
        posicion = cadena.IndexOf(palabra, indice, StringComparison.OrdinalIgnoreCase);
    }
    return n;
}

void mostrarPartes(string[] arreglo)
{
    foreach (string item in arreglo)
    {
        Console.WriteLine(item);
    }
}


string? cadena1 = ingresarCadena("Ingresa una cadena de texto: ");

Console.WriteLine("La longitud de la cadena1 es: " + longitud(cadena1));

string? cadena2 = ingresarCadena("Ingresa una cadena de texto: ");

string concatenada = concatenar(cadena1, cadena2);
Console.WriteLine("La cadena concatenada: " + concatenada);

int principioSubcadena = ingresarNumeros("Ingresa la posicion inicial para la subcadena: ");
int longitudSubcadena = ingresarNumeros("Ingresa la longitud de la subcadena(si quiere que la subcadena sea hasta el final de la cadena, ingrese un valor negativo): ");

string subcadena = extraerSubcadena(concatenada, principioSubcadena, longitudSubcadena);
Console.WriteLine("La subcadena: " + subcadena);

recorrerCadena(subcadena);

string? palabra = ingresarCadena("Ingresa la palabra a buscar: ");
Console.WriteLine("La palabra " + palabra + " aparece " + ocurrenciaPalabra(concatenada, palabra) + " veces en la cadena " + concatenada);

Console.WriteLine("La cadena en mayusculas: " + cadena1.ToUpper());
Console.WriteLine("La cadena en minusculas: " + cadena1.ToLower());

string cadenaSeparada = "a,b;c.d";
char[] separadores = { ',', ';', '.' };
string[] partes = cadenaSeparada.Split(separadores);
mostrarPartes(partes);



//Construir un programa que permita identificar de forma sencilla si la cadena ingresada es una dirección web y otro que una cadena ingresada sea un mail válido

string? direccionWeb = ingresarCadena("Ingresa una direccion web:");
string patronURL = @"^(https?:\/\/)?(www\.)?[a-zA-Z0-9\-]+(\.[a-zA-Z]{2,})+(/.*)?$";

if (Regex.IsMatch(direccionWeb, patronURL))
{
    Console.WriteLine("La cadena es una dirección web válida.");
}
else
{
    Console.WriteLine("La cadena NO es una dirección web válida.");
}

string? mail = ingresarCadena("Ingresa un mail:");
string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

if (Regex.IsMatch(mail, patronEmail))
{
    Console.WriteLine("El correo electrónico es válido.");
}
else
{
    Console.WriteLine("El correo electrónico NO es válido.");
}