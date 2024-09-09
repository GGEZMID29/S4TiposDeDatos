using System.Diagnostics;
using S4Tiposdedatos;
Console.Clear();
/*ToString
Sirve para convertir de un tipo a string.

Ejemplo 1: Simple ToString
var cantidad1 = 5;

if (cantidad1.ToString() == "5")
{
    Console.WriteLine("Son iguales");
}
else
{
    Console.WriteLine("No son iguales");
}

Ejemplo 2: ToString con formato personalizado
var hoy = DateTime.Today.ToString("yyyy-MM-dd (dddd)");
Console.WriteLine(hoy);

Ejemplo 3: 

int num = 9;
string text = num.ToString();

System.Console.WriteLine(text);

Ejemplo 4:

double number = 1234.777;
string texto = number.ToString("C");

System.Console.WriteLine(texto);
*/

/*Parse/TryParse
Convertir de String hacia otro tipo de dato.

// Ejemplo 1: Enteros
var cantidadString = "5";

int cantidad = int.Parse(cantidadString);

cantidad++;

Console.WriteLine(cantidad); // 6

// Ejemplo 2: Decimal

var cantidadDecimalString = "4.9";

var cantidadDecimal = decimal.Parse(cantidadDecimalString);

cantidadDecimal++; // 5.9

// Ejemplo 3: Booleanos

var booleanoString = "true";

var booleano = bool.Parse(booleanoString);

if (booleano)
{
    Console.WriteLine("Convertimos de string a booleano");
}

// Ejemplo 4: Fechas

var fechaString = "2022-05-09";

var fecha = DateTime.Parse(fechaString);

Console.WriteLine(fecha.AddYears(1)); // 2023-05-09

// Ejemplo 5: Manejando errores

var supuestoNumero = "Felipe";
//var supuestoNumero = "9";

// Lanza un error
//var numero = int.Parse(supuestoNumero);

int numero;

// No lanza error
var pudoParsear = int.TryParse(supuestoNumero, out numero);

if (pudoParsear)
{
    // lugar seguro donde puedo usar la variable numero
    numero++; // 10
    Console.WriteLine(numero);
}
else
{
    Console.WriteLine($"El valor {supuestoNumero} no tiene el formato correcto.");
}

// Ejemplo 6: Parse
string text = "777";
int nume = int.Parse(text);

System.Console.WriteLine(nume);

// Ejemplo 7: Excepción

try
{
    string texto = "abc";
    int num = int.Parse(texto);
}
catch (FormatException)
{
    
    System.Console.WriteLine("ERROR: String no se convierte a número!");
}

Ejemplo 8: TryParse

string texto = "1245";
int numero;

bool exito = int.TryParse(texto, out numero);

if (exito)
{
    System.Console.WriteLine($"Conversión exitosa, {numero} es el número.");
}
else
{
    System.Console.WriteLine("ERROR: No se pudo completar la conversión.");
}

Ejemplo 9: TryParse con cadena inválida.

string texto = "Ok";
int numero;

bool exito = int.TryParse(texto, out numero);

if (exito)
{
    System.Console.WriteLine($"Conversión exitosa, {numero} es el número.");
}
else
{
    System.Console.WriteLine("ERROR: No se pudo completar la conversión.");
}
*/

/*Casteos
Pasar de un tipo de dato a otro.

Ejemplo 1: Casteo explícito, de entero a double

var c1 = 9;
var c2 = 4;

var division = (double)c1 / c2;

Console.WriteLine("La división es " + division);

Ejemplo 2: Otro casteo explícito

byte byte1; // 0 hasta 255
int int1 = 7; // -2 mil millones hasta 2 mil millones

checked
{
    byte1 = (byte)int1;
}

Console.WriteLine(byte1);

Ejemplo 3: Casteo implícito

byte byte2 = 11;
int int2;

int2 = byte2;

Console.WriteLine(int2);
*/

/*Enums
Es un valor especial que nos permite agrupar un conjunto de constantes con nombre de forma numéricas.


var EstatusDeLaVentaDeUnaCamisa = EstatusVenta.PendienteDePago;

switch (EstatusDeLaVentaDeUnaCamisa)
{
    case EstatusVenta.Exitoso:
        System.Console.WriteLine("La venta fue exitosa!");
        break;
    case EstatusVenta.PendienteDePago:
        System.Console.WriteLine("El cliente está pendiente a pago.");
        break;
    case EstatusVenta.Cancelada:
        System.Console.WriteLine("Venta declinada.");
        break;
    default:
        System.Console.WriteLine("Estatus desconocido.");
        break;
}

Ejemplo 2: Casteos

int estatus = (int)EstatusDeLaVentaDeUnaCamisa;
System.Console.WriteLine(estatus); // 1

int Estatus3 = 3;
var Estatus3Nombre = (EstatusVenta)Estatus3;
System.Console.WriteLine(Estatus3Nombre); 

Ejemplo 3: Uso de enums

NivelDeAcceso nivel = NivelDeAcceso.Invitado;

if (nivel is NivelDeAcceso.Administrador)
{
    System.Console.WriteLine("Eres el administrador, tienes acceso total.");
}
else if (nivel is NivelDeAcceso.SuperAdmin)
{
    System.Console.WriteLine("Puedes hacer lo que quieras, eres el desarrollador.");
}
else if (nivel is NivelDeAcceso.Usuario)
{
    System.Console.WriteLine("Puedes usar el programa para trabajar.");
}
else 
{
    System.Console.WriteLine("Eres invitado, solo puedes ver la aplicación.");
}
*/

/*Introducción a los arreglos
Es una representación de un número fijo de elementos de un tipo particular.

Ejemplo 1: Arreglo de char's

char[]? vocales = new char[5];
vocales = null; // Son tipo de referencia

vocales[0] = 'a'; // Primer elemento
vocales[1] = 'e'; // Segundo elemento
vocales[2] = 'i'; // Tercer elemento
vocales[3] = 'o'; // Cuarto elemento
vocales[4] = 'u'; // Quinto elemento

var v2 = vocales[1]; 

// System.Console.WriteLine(v2); // e

//var unaVocalMagica = vocales[5]; // no hay sexto elemento

// foreach (var vocal in vocales)
// {
//     System.Console.WriteLine(vocal);
// }

// Ejemplo: Enteros arrays

var numeros = new int[] {1,2,3,4,5,6,7,8,9,10}; 

foreach (var number in numeros)
{
    System.Console.Write($"{number} ");
}

int[] numeros = new int[5]; // Array de 5 elementos
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
numeros[3] = 40;
numeros[4] = 50;

// Recorrer el array
for (int i = 2; i < numeros.Length; i++)
{
    Console.WriteLine($"Índice: {i}, Valor: {numeros[i]}");
}

// Ejemplo: Modificando un array
int[] numeros = { 1, 2, 3, 4, 5 };

// Multiplicamos cada valor del array por 2
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] *= 2;
}

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Ejemplo array multidimensional (bidimensional)

int[,] matriz = new int[3, 2] 
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 2; columna++)
    {
        Console.WriteLine($"Elemento en [{fila},{columna}] = {matriz[fila, columna]}");
    }
}

Ejemplo array escalonado

int[][] arrayEscalonado = new int[3][];
arrayEscalonado[0] = new int[] { 1, 2 }; 
arrayEscalonado[1] = new int[] { 3, 4, 5 };
arrayEscalonado[2] = new int[] { 6, 7, 8, 9 };

for (int i = 0; i < arrayEscalonado.Length; i++)
{
    for (int j = 0; j < arrayEscalonado[i].Length; j++)
    {
        Console.Write(arrayEscalonado[i][j] + " ");
    }
    Console.WriteLine();
}

Ejemplo array multidimensional (tridimensional)

int[,,] cubo = new int[2, 2, 2] 
{
    {
        { 1, 2 }, { 3, 4 }
    },
    {
        { 5, 6 }, { 7, 8 }
    }
};

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.WriteLine($"Elemento en [{i},{j},{k}] = {cubo[i,j,k]}");
        }
    }
}
*/

/*Índices

var vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

var segundaVocal = vocales[1]; // e

var ultimaVocal = vocales[^1]; // u

Index penultimo = ^2;

var penultimaVocal = vocales[penultimo]; // o

Console.WriteLine(penultimaVocal);
*/

/*Rango

var vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

Range dosPrimeros = ..2;
var dosPrimerasVocales = vocales[dosPrimeros]; // 0, 1
var tresPrimerasVocales = vocales[..3]; // 0, 1, 2

var dosUltimasVocales = vocales[^2..]; // ^2, ^1
var dosUltimasVocalesV2 = vocales[3..]; // 3, 4

var tresEnMedio = vocales[1..4]; // 1,2,3

Range ignorarPrimeroYUltimo = 1..^1;
var tresEnMedioV2 = vocales[ignorarPrimeroYUltimo]; // 1,2,3

foreach (var vocal in tresEnMedio)
{
    System.Console.WriteLine(vocal);
}
*/

/*Arreglos Multidimensionales

Bidimensional
int[,] matriz = new int[2, 2];

System.Console.WriteLine(matriz.Rank); //Tamaño de la matriz

matriz[0, 0] = 1; // primera fila, primera columna
matriz[0, 1] = 2; // primera fila, segunda columna
matriz[1, 0] = 3; // segunda fila, primera columna
matriz[1, 1] = 4; // segunda fila, segunda columna

var elemento01 = matriz[0, 1]; // 2

int[,] matriz2 = new int[,]
{
    {5, 6 }, // primera fila
    {7, -5 }, // segunda fila
    {8, 9 } // tercera fila
};

for (int fila = 0; fila < matriz2.GetLength(0); fila++)
{
    for (int columna = 0; columna < matriz2.GetLength(1); columna++)
    {
        System.Console.Write($"{matriz2[fila, columna]} ");
    }
    System.Console.WriteLine();
}
*/

/*Arreglos dentro de Arreglos (Arreglos de arreglos)

int[][] arregloDeArreglos = {

                                new int[]{1, 2},
                                new int[]{3, 4, 5},
                                new int[]{6},
                                new int[]{7, 8}

                            };

var e2 = arregloDeArreglos[1];

foreach (var valor in e2)
{
    System.Console.Write($"{valor}");
}

arregloDeArreglos[3] = new int[] { 9, 10, 11};

var e3 = arregloDeArreglos[3];

foreach (var valor in e3)
{
    System.Console.Write($"{valor} ");
}

string[] palabras = { "Hola", "mundo", "en", "C#" };
string resultado = String.Join(" ", palabras);
System.Console.WriteLine(resultado);

for (int fila = 0; fila < arregloDeArreglos.Length; fila++)
{
    var arreglo = arregloDeArreglos[fila];
    for (int columna = 0; columna < arreglo.Length; columna++)
    {
        System.Console.Write($"{arreglo[columna]} ");  
    }
    System.Console.WriteLine();
}


Ejemplos
Los arreglos de arreglos son arreglos que pueden contener como elemento otro arreglo, y esos 
subarreglos pueden ser de diferentes tamaños

int [][] jaggedArray = new int[3][]; // 3 subarreglos

Elementos que tendrá cada subarreglo.
jaggedArray[0] = new int[2]; // 2 elementos.
jaggedArray[1] = new int[3]; // 3 elementos.
jaggedArray[2] = new int[1]; // 1 elemento.

Se llena cada subarreglo con números.

jaggedArray[0][0] = 10;
jaggedArray[0][1] = 20;

jaggedArray[1][0] = 30;
jaggedArray[1][1] = 40;
jaggedArray[1][2] = 50;

jaggedArray[2][0] = 60;

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        System.Console.Write(jaggedArray[i][j] + " ");
    }   
    System.Console.WriteLine();
}   
*/

/*Manipulando Strings

string nombre = "Jayson";

string enmayuscula = nombre.ToUpper(); //ToUpper sirve para todo en mayúsculas.
string enminuscula = nombre.ToLower(); //ToLower sirve para todo en minúsculas.
var longitud = nombre.Length; // length sirve para saber la longitud de un string. 6 caracteres


System.Console.Write("Desea terminar el programa? (y/n):");
var leer = Console.ReadLine();

if (leer?.ToLower().Trim() is "y") //Trim elimina los espacios en blanco.
{
    System.Console.WriteLine("Terminó");
}
else
{
    System.Console.WriteLine("el programa no ha terminado.");
}

var mensaje = "123Hola, ¿KLK?99";
char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
var mensajeArreglado = mensaje.Trim(numeros); //Trim puede eliminar caracteres en especifico que queramos.
System.Console.WriteLine(mensajeArreglado);

long monto1 = 123;
long monto2 = 4;
long monto3 = 123456789L;
long monto4 = 1234567890L;

System.Console.WriteLine(monto1.ToString().PadLeft(10, '0'));
System.Console.WriteLine(monto2.ToString().PadLeft(10, '0'));
System.Console.WriteLine(monto3.ToString().PadLeft(10, '0'));
System.Console.WriteLine(monto4.ToString().PadLeft(10, '0'));
*/

/*Temas
   --ToString
   --Parse
   --Enums
   --Arreglos
   --Manipular Strings.
*/

/*Practicas S4*/

/*ToString
Es un método que funciona para convertir un obejo en la representación de una cadena de texto (String).
Tipos de Datos como int, double, bool ya lo tienen implementado, cuando se llama se obtiene una representación en texto del valor.

Ejemplo

int number = 123;
string textNumber = number.ToString();
System.Console.WriteLine(textNumber);

Ejemplo 2 

decimal precio = 19.99m;
string textoPrecio = precio.ToString();
Console.WriteLine(textoPrecio); // Imprime "19.99"

Ejemplo 3

DateTime fechaActual = DateTime.Now;
string textoFecha = fechaActual.ToString();
System.Console.WriteLine(textoFecha);

// Ejemplo 4

double numero = 1234.56789;
string textoFormateado = numero.ToString("F2");
Console.WriteLine(textoFormateado); // Imprime "1234.57"

// Ejemplo 5

bool esVerdadero = true;
string textoBooleano = esVerdadero.ToString();
Console.WriteLine(textoBooleano); // Imprime "True"

// Ejemplo 6

int[] numeros = { 1, 2, 3, 4, 5 };
string textoArreglo = string.Join(", ", numeros);
Console.WriteLine(textoArreglo); // Imprime "1, 2, 3, 4, 5"

Ejercicio ToString 1

bool test = true;
string textTest = test.ToString();
System.Console.WriteLine(textTest);

Ejercicio ToString 2

DateTime test = DateTime.Now;
string fechaAtexto = test.ToString();
System.Console.WriteLine(fechaAtexto);
*/

/*Parse y TryParse

Métodos que se utilizan para convertir cadenas de texto en tipos de datos (int, date, etc)

Parse: La diferencia Parse si la cadena no puede convertirse dará una excepción.

string numeroTexto = "321";
int numero = int.Parse(numeroTexto);
System.Console.WriteLine(numero);

Manejar una exepción con Parse

try
{
    string numeroTexto = "ok";
    int numero = int.Parse(numeroTexto);
}
catch (FormatException ex)
{

    System.Console.WriteLine("ERROR: No es válido");
}

Ejemplo con Parse y Try-Catch

Console.Write("Por favor, ingresa un número entero: ");
string? entradaUsuario = Console.ReadLine();

try
{
    int numero = int.Parse(entradaUsuario);
    Console.WriteLine("La conversión fue exitosa. El número es: " + numero);
}
catch (FormatException)
{
    Console.WriteLine("Error: La entrada no es un número válido.");
}

TryParse: Funciona similar que Parse, pero no lanza una excepción cuando falla si no un valor booleano (true/false) si es exitoso o no la conversión.

Ejemplo 1

string numeroTexto = "123";
bool exito = int.TryParse(numeroTexto, out int numero);

if (exito)
{
    System.Console.WriteLine("Conversión exitorsa. El numero es: "+ numero); 
}
else
{
    System.Console.WriteLine("Error: Conversión fallida.");
}

Ejemplo 2: Manejar una cadena no numérica

string numero = "ABC";
bool exito = int.TryParse(numero, out int n);

if (exito)
{  
    System.Console.WriteLine("Conversión Exitosa. Tu número es: " + n); 
}
else
{
    System.Console.WriteLine("Error.");
}

Resumen: 

Parse: Convierte una cadena en un tipo de dato y en caso de no hacerlo arroja una excepción.

TryParse: Hace lo mismo, pero cuando falla no detiene el programa si no que es más seguro porque 
maneja la excepción y el programa no se detendrá si falla por excepción.

Ambos son útiles, pero el TryParse es más seguro.

Ejercicio Parse/TryParse 1

while (true)
{

    Console.Write("Por favor, ingresa un número entero: ");
    string? entradaUsuario = Console.ReadLine();

    bool exito = int.TryParse(entradaUsuario, out int numero);

    if (exito)
    {
        System.Console.WriteLine("Conversión exitosa. Numero: " + numero);
    }
    else
    {
        System.Console.WriteLine("Error");
    }

}

Ejercicio Parse/TryParse 2

while (true)
{
    System.Console.Write("Por favor, ingrese un decimal: ");
    string? entradaUsuario = Console.ReadLine();

    if (!entradaUsuario.Contains('.'))
    {
        Console.WriteLine("ERROR: Por favor, ingrese un número decimal (con punto).");
        continue; // Saltar a la siguiente iteración del bucle
    }


    try
    {
        decimal numero = decimal.Parse(entradaUsuario);
        Console.WriteLine("La conversión fue exitosa. El número es: " + numero);

    }
    catch (FormatException)
    {

        System.Console.WriteLine("ERROR");
    }
}
*/

/*Enums
Te permiten definir un conjunto de constantes con nombre.

DiasDeLaSemana diaHoy = DiasDeLaSemana.Miercoles;
Console.WriteLine($"Hoy es {diaHoy}");

int numeroDia = (int)DiasDeLaSemana.Lunes;
System.Console.WriteLine(numeroDia);

    NivelDePrioridad prioridad = NivelDePrioridad.Alta;

    switch (prioridad)
    {
        case NivelDePrioridad.Baja:
            System.Console.WriteLine("La tarea tiene baja prioridad, se puede trabajar con calma.");
            break;

        case NivelDePrioridad.Media:
            System.Console.WriteLine("La tarea tiene prioridad media, trabajarla a su debido tiempo");
            break;

        case NivelDePrioridad.Alta:
            System.Console.WriteLine("La tarea tiene prioridad alta, trabajar lo antes posible.");
            break;

        case NivelDePrioridad.Critica:
            System.Console.WriteLine("La tarea está en estado critico, favor dejar todo y darle prioridad a esta tarea.");
            break;
    }

/*Resumen
    Un Enum es un tipo que nos permite definir un conjunto de constantes con nombre.
    Se usan para representar un conjunto fijo de valores.
    Estos mejoran la claridad y el mantenimiento del código.


Ejercicio 1 Enums

EstadoPedido estado = EstadoPedido.Procesando;

switch (estado)
{   
    case EstadoPedido.Procesando:
        System.Console.WriteLine("Su pedido ha sido registrado, Procesando. Por favor espere...");
        break;

    case EstadoPedido.Pendiente:
        System.Console.WriteLine("Su pedido está pendiente a su entrega. Por favor active las notificaciones para ver el estatus.");
        break;

    case EstadoPedido.Enviado:
        System.Console.WriteLine("Su pedido ha sido enviado con exito. Por favor continue pendiente a las notificaciones.");
        break;
    
    case EstadoPedido.Entregado:
        System.Console.WriteLine("Su pedido ha sido entregado correctamente. Califique su entrega.");
        break;
    
}

Ejercico 2 Enums

NivelDeAcceso acceso = NivelDeAcceso.Administrador;

if (acceso is NivelDeAcceso.Administrador)
{
    System.Console.WriteLine("Acceso concedido. Bienvenido!");
}
else
{
    System.Console.WriteLine("Acceso denegado. No es Administrador.");
}
*/

/*Arreglos*/

//Es una estructura de datos que permiten almacenar una colección de elementos del mismo tipo en una secuencia ordenada. 

//Bidimensional
// int[] num = { 30, 9, 4, 10, 29}; //La posición 0 es la primera en los arreglos

// foreach (var n in num)
// {
//     System.Console.WriteLine(n);
// }

// System.Console.WriteLine(num[3]); //Se puede acceder a un elemento mediante índices.

//Multidimensional o Matriz

// int[,] calificaciones = { {90, 85}, {78, 82}, {88, 91} };

// System.Console.WriteLine(calificaciones[0, 1]); //Imprime 85
// System.Console.WriteLine(calificaciones[2, 0]); //Imprime 88

//Arreglo de Arreglos
// int[][] grupos = new int[3][];

// grupos[0] = new int[] { 5, 7, 8}; // Grupo 1 tiene 3 estudiantes
// grupos[1] = new int[] { 6, 9 }; // Grupo 2 tiene 2 estudiantes
// grupos[2] = new int[] {4, 10, 11}; // Grupo 3 tiene 3 estudiantes

// System.Console.WriteLine(grupos[0][2]); //Imprime 8
// System.Console.WriteLine(grupos[1][1]); //Imprime 9

//Recorrer con Foreach

// foreach (int[] grupo in grupos)
// {
//     foreach (int estudiante in grupo)
//     {
//         System.Console.WriteLine(estudiante);
//     }
// }

//Recorrer con For

// for (int i = 0; i < grupos.Length; i++)
// {
//     for (int j = 0; j < grupos[i].Length; j++)
//     {
//         System.Console.WriteLine(grupos[i][j]);
//     }
// }

//Ejercicio 1 arreglos

//Sumar Elementos de un Arreglo Unidimensional
// int[] numeros = { 2, 4, 6, 8, 10 };
// int suma = 0;

// foreach (int numero in numeros)
// {
//     suma += numero; // Esto es lo mismo que: suma = suma + numero;

// }

// Console.WriteLine("La suma de todos los elementos es: " + suma);

//Ejercicio 2 Contar Números Pares en un Arreglo Dentado

// int[][] grupos = new int[3][];
// grupos[0] = new int[] { 1, 2, 3 };
// grupos[1] = new int[] { 4, 5, 6 };
// grupos[2] = new int[] { 7, 8, 9 };

// int contadorPares = 0;

// foreach (int[] grupo in grupos)
// {
//     foreach (int numero in grupo)
//     {
//         if (numero % 2 == 0)
//         {
//             contadorPares++;
//         }
//     }
// }

// Console.WriteLine("La cantidad de números pares es: " + contadorPares);