using System.Diagnostics;
using S4Tiposdedatos;
Console.Clear();
/*ToString
//Sirve para convertir de un tipo a string.

// Ejemplo 1: Simple ToString
var cantidad1 = 5;

if (cantidad1.ToString() == "5")
{
    Console.WriteLine("Son iguales");
}
else
{
    Console.WriteLine("No son iguales");
}

// Ejemplo 2: ToString con formato personalizado
var hoy = DateTime.Today.ToString("yyyy-MM-dd (dddd)");
Console.WriteLine(hoy);

//Ejemplo 3: 

int num = 9;
string text = num.ToString();

System.Console.WriteLine(text);

//Ejemplo 4:

double number = 1234.777;
string texto = number.ToString("C");

System.Console.WriteLine(texto);
*/

/*Parse/TryParse
//Convertir de String hacia otro tipo de dato.

// // Ejemplo 1: Enteros
// var cantidadString = "5";

// int cantidad = int.Parse(cantidadString);

// cantidad++;

// Console.WriteLine(cantidad); // 6

// // Ejemplo 2: Decimal

// var cantidadDecimalString = "4.9";

// var cantidadDecimal = decimal.Parse(cantidadDecimalString);

// cantidadDecimal++; // 5.9

// // Ejemplo 3: Booleanos

// var booleanoString = "true";

// var booleano = bool.Parse(booleanoString);

// if (booleano)
// {
//     Console.WriteLine("Convertimos de string a booleano");
// }

// // Ejemplo 4: Fechas

// var fechaString = "2022-05-09";

// var fecha = DateTime.Parse(fechaString);

// Console.WriteLine(fecha.AddYears(1)); // 2023-05-09

// // Ejemplo 5: Manejando errores

// var supuestoNumero = "Felipe";
// //var supuestoNumero = "9";

// // Lanza un error
// //var numero = int.Parse(supuestoNumero);

// int numero;

// // No lanza error
// var pudoParsear = int.TryParse(supuestoNumero, out numero);

// if (pudoParsear)
// {
//     // lugar seguro donde puedo usar la variable numero
//     numero++; // 10
//     Console.WriteLine(numero);
// }
// else
// {
//     Console.WriteLine($"El valor {supuestoNumero} no tiene el formato correcto.");
// }

// // Ejemplo 6: Parse
// string text = "777";
// int nume = int.Parse(text);

// System.Console.WriteLine(nume);

// // Ejemplo 7: Excepción

// try
// {
//     string texto = "abc";
//     int num = int.Parse(texto);
// }
// catch (FormatException)
// {
    
//     System.Console.WriteLine("ERROR: String no se convierte a número!");
// }

// Ejemplo 8: TryParse

// string texto = "1245";
// int numero;

// bool exito = int.TryParse(texto, out numero);

// if (exito)
// {
//     System.Console.WriteLine($"Conversión exitosa, {numero} es el número.");
// }
// else
// {
//     System.Console.WriteLine("ERROR: No se pudo completar la conversión.");
// }

// Ejemplo 9: TryParse con cadena inválida.

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
//Pasar de un tipo de dato a otro.

// Ejemplo 1: Casteo explícito, de entero a double

var c1 = 9;
var c2 = 4;

var division = (double)c1 / c2;

Console.WriteLine("La división es " + division);

// Ejemplo 2: Otro casteo explícito

byte byte1; // 0 hasta 255
int int1 = 7; // -2 mil millones hasta 2 mil millones

checked
{
    byte1 = (byte)int1;
}

Console.WriteLine(byte1);

// Ejemplo 3: Casteo implícito

byte byte2 = 11;
int int2;

int2 = byte2;

Console.WriteLine(int2);
*/

/*Enums
//Es un valor especial que nos permite agrupar un conjunto de constantes con nombre de forma numéricas.


// var EstatusDeLaVentaDeUnaCamisa = EstatusVenta.PendienteDePago;

// switch (EstatusDeLaVentaDeUnaCamisa)
// {
//     case EstatusVenta.Exitoso:
//         System.Console.WriteLine("La venta fue exitosa!");
//         break;
//     case EstatusVenta.PendienteDePago:
//         System.Console.WriteLine("El cliente está pendiente a pago.");
//         break;
//     case EstatusVenta.Cancelada:
//         System.Console.WriteLine("Venta declinada.");
//         break;
//     default:
//         System.Console.WriteLine("Estatus desconocido.");
//         break;
// }

//Ejemplo 2: Casteos

// int estatus = (int)EstatusDeLaVentaDeUnaCamisa;
// System.Console.WriteLine(estatus); // 1

// int Estatus3 = 3;
// var Estatus3Nombre = (EstatusVenta)Estatus3;
// System.Console.WriteLine(Estatus3Nombre); 

//Ejemplo 3: Uso de enums

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
//Es una representación de un número fijo de elementos de un tipo particular.

// Ejemplo 1: Arreglo de char's

// char[]? vocales = new char[5];
// vocales = null; // Son tipo de referencia

// vocales[0] = 'a'; // Primer elemento
// vocales[1] = 'e'; // Segundo elemento
// vocales[2] = 'i'; // Tercer elemento
// vocales[3] = 'o'; // Cuarto elemento
// vocales[4] = 'u'; // Quinto elemento

// var v2 = vocales[1]; 

// // System.Console.WriteLine(v2); // e

// //var unaVocalMagica = vocales[5]; // no hay sexto elemento

// // foreach (var vocal in vocales)
// // {
// //     System.Console.WriteLine(vocal);
// // }

// // Ejemplo: Enteros arrays

// var numeros = new int[] {1,2,3,4,5,6,7,8,9,10}; 

// foreach (var number in numeros)
// {
//     System.Console.Write($"{number} ");
// }

// int[] numeros = new int[5]; // Array de 5 elementos
// numeros[0] = 10;
// numeros[1] = 20;
// numeros[2] = 30;
// numeros[3] = 40;
// numeros[4] = 50;

// // Recorrer el array
// for (int i = 2; i < numeros.Length; i++)
// {
//     Console.WriteLine($"Índice: {i}, Valor: {numeros[i]}");
// }

// // Ejemplo: Modificando un array
// int[] numeros = { 1, 2, 3, 4, 5 };

// // Multiplicamos cada valor del array por 2
// for (int i = 0; i < numeros.Length; i++)
// {
//     numeros[i] *= 2;
// }

// foreach (int numero in numeros)
// {
//     Console.WriteLine(numero);
// }

// Ejemplo array multidimensional (bidimensional)

// int[,] matriz = new int[3, 2] 
// {
//     { 1, 2 },
//     { 3, 4 },
//     { 5, 6 }
// };

// for (int fila = 0; fila < 3; fila++)
// {
//     for (int columna = 0; columna < 2; columna++)
//     {
//         Console.WriteLine($"Elemento en [{fila},{columna}] = {matriz[fila, columna]}");
//     }
// }

// Ejemplo array escalonado

// int[][] arrayEscalonado = new int[3][];
// arrayEscalonado[0] = new int[] { 1, 2 }; 
// arrayEscalonado[1] = new int[] { 3, 4, 5 };
// arrayEscalonado[2] = new int[] { 6, 7, 8, 9 };

// for (int i = 0; i < arrayEscalonado.Length; i++)
// {
//     for (int j = 0; j < arrayEscalonado[i].Length; j++)
//     {
//         Console.Write(arrayEscalonado[i][j] + " ");
//     }
//     Console.WriteLine();
// }

// Ejemplo array multidimensional (tridimensional)

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
}*/

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
*/

// Ejemplos
/* Los arreglos de arreglos son arreglos que pueden contener como elemento otro arreglo, y esos 
subarreglos pueden ser de diferentes tamaños*/

// int [][] jaggedArray = new int[3][]; // 3 subarreglos

// // Elementos que tendrá cada subarreglo.
// jaggedArray[0] = new int[2]; // 2 elementos.
// jaggedArray[1] = new int[3]; // 3 elementos.
// jaggedArray[2] = new int[1]; // 1 elemento.

// // Se llena cada subarreglo con números.

// jaggedArray[0][0] = 10;
// jaggedArray[0][1] = 20;

// jaggedArray[1][0] = 30;
// jaggedArray[1][1] = 40;
// jaggedArray[1][2] = 50;

// jaggedArray[2][0] = 60;

// for (int i = 0; i < jaggedArray.Length; i++)
// {
//     for (int j = 0; j < jaggedArray[i].Length; j++)
//     {
//         System.Console.Write(jaggedArray[i][j] + " ");
//     }   
//     System.Console.WriteLine();
// }   

/*Manipulando Strings

// string nombre = "Jayson";

// string enmayuscula = nombre.ToUpper(); //ToUpper sirve para todo en mayúsculas.
// string enminuscula = nombre.ToLower(); //ToLower sirve para todo en minúsculas.
// var longitud = nombre.Length; // length sirve para saber la longitud de un string. 6 caracteres


// System.Console.Write("Desea terminar el programa? (y/n):");
// var leer = Console.ReadLine();

// if (leer?.ToLower().Trim() is "y") //Trim elimina los espacios en blanco.
// {
//     System.Console.WriteLine("Terminó");
// }
// else
// {
//     System.Console.WriteLine("el programa no ha terminado.");
// }

// var mensaje = "123Hola, ¿KLK?99";
// char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
// var mensajeArreglado = mensaje.Trim(numeros); //Trim puede eliminar caracteres en especifico que queramos.
// System.Console.WriteLine(mensajeArreglado);

// long monto1 = 123;
// long monto2 = 4;
// long monto3 = 123456789L;
// long monto4 = 1234567890L;

// System.Console.WriteLine(monto1.ToString().PadLeft(10, '0'));
// System.Console.WriteLine(monto2.ToString().PadLeft(10, '0'));
// System.Console.WriteLine(monto3.ToString().PadLeft(10, '0'));
// System.Console.WriteLine(monto4.ToString().PadLeft(10, '0'));
*/

/*
    --ToString
    --Parse
    --Enums
    --Arreglos
    --Manipular Strings.
*/