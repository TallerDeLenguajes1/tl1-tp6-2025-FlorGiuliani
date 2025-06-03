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