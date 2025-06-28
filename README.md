[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

*¿String es una tipo por valor o un tipo por referencia?
En C#, string es un tipo por referencia, pero se comporta de manera inmutable como si fuera por valor en muchos casos.

Explicación:
string es una clase (System.String), y todas las clases en C# son tipos por referencia.

Sin embargo, los objetos string son inmutables, es decir, una vez creado un objeto string, su contenido no puede cambiar.

Cuando "modificas" un string, en realidad estás creando un nuevo objeto en memoria con el nuevo valor.



*¿Qué secuencias de escape tiene el tipo string?
En C#, el tipo string admite varias secuencias de escape que comienzan con una barra invertida (\). Estas secuencias permiten representar caracteres especiales dentro de cadenas literales.

Secuencia	Significado
\'	Comilla simple (')
\"	Comilla doble (")
\\	Barra invertida (\)
\0	Carácter nulo (NULL)
\a	Alerta (beep)
\b	Retroceso (backspace)
\f	Salto de página (form feed)
\n	Nueva línea (line feed)
\r	Retorno de carro (carriage return)
\t	Tabulación horizontal
\v	Tabulación vertical
\uXXXX	Unicode con 4 dígitos hexadecimales
\xXX	Unicode/ASCII con 1–4 dígitos hexadecimales



*¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Por otro lado, se puede usar @ para evitar usar secuencias de escape
Ejemplo: 
    string ruta = @"C:\Archivos\MiCarpeta\archivo.txt";
    string mensaje = @"Este es un texto que abarca múltiples líneas y contiene ""comillas dobles"".";

Cuando usamos @ y $ juntos antes de una cadena en C#, estás combinando dos funcionalidades:

@ = Cadena verbatim → ignora la mayoría de las secuencias de escape y permite múltiples líneas.

$ = Cadena interpolada → permite insertar variables o expresiones dentro de la cadena usando {}.

La combinación @$ (o $@, el orden no importa) te permite:

Escribir cadenas en múltiples líneas o con rutas de archivo sin tener que escapar las \.

Interpolar variables y expresiones dentro del texto.

Ejemplos:
    string nombre = "Carlos";
    string ruta = @$"C:\Usuarios\{nombre}\Documentos\archivo.txt";

    int edad = 30;
    string mensaje = @$"
    Hola, {nombre}.
    Tienes {edad} años.
    Tu carpeta está en: C:\Usuarios\{nombre}\";



    ¿Qué son las expresiones regulares?
Las expresiones regulares (o regex, por "regular expressions") son patrones utilizados para buscar, validar o manipular texto. Son muy potentes para encontrar coincidencias dentro de cadenas, como verificar si una cadena cumple con cierto formato (ej: un correo electrónico, un número de teléfono, etc.).

Las expresiones regulares están compuestas por símbolos y caracteres especiales que representan patrones de búsqueda. Algunos ejemplos:

\d → Cualquier dígito (0–9)

\w → Cualquier letra o número (carácter alfanumérico)

. → Cualquier carácter excepto salto de línea

* → Cero o más repeticiones

+ → Una o más repeticiones

^ → Inicio de línea

$ → Fin de línea

Por ejemplo, el patrón ^\d{3}-\d{2}-\d{4}$ valida un número de seguridad social con el formato 123-45-6789.

    ¿Funcionan solo en C#?
No. Las expresiones regulares son un estándar que se utiliza en muchos lenguajes de programación y herramientas: Python, JavaScript, Java, PHP, Ruby, Perl, etc.
Incluso en editores de texto como VSCode o Notepad++ para búsqueda avanzada

    ¿En qué casos son útiles?

- Validar formatos de entrada:
Verificar si un correo electrónico es válido
Comprobar si un número de teléfono tiene el formato correcto
Validar contraseñas seguras (longitud, símbolos, etc.)

- Extraer información de un texto:
Sacar todas las direcciones de email de un archivo de texto
Obtener números de factura en un reporte
Leer fechas dentro de un documento

- Reemplazar texto:
Cambiar todos los dígitos por * en un texto para ocultar información
Limpiar espacios dobles o caracteres innecesarios
Reformatear fechas de DD/MM/YYYY a YYYY-MM-DD

    ¿Cómo se usan en C#?

Ejemplo 1:
using System.Text.RegularExpressions;
string email = "ejemplo@correo.com";
bool esValido = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
Console.WriteLine(esValido); // True si es válido

Ejemplo 2:
string texto = "Hay 3 perros y 14 gatos";
MatchCollection numeros = Regex.Matches(texto, @"\d+");
foreach (Match match in numeros) {
    Console.WriteLine(match.Value); // Imprime 3 y luego 14
}

Ejemplo 3:
string texto = "Hola mundo";
string ocultado = Regex.Replace(texto, @"[a-zA-Z]", "*");
Console.WriteLine(ocultado); // **** *****