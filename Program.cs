﻿//  EJERCICIO 1
/*
int numeroEntero = 107, numeroInvertido = 0, factor = 10;
int digito;
if (numeroEntero > 0)
{
    int copiaNum = numeroEntero;
    while (copiaNum / 10 >= 10)
    {
        copiaNum = copiaNum / 10;
        factor = factor * 10;
    }
    copiaNum = numeroEntero;
    while (copiaNum / 10 >= 1)
    {
        digito = copiaNum % 10;
        numeroInvertido = numeroInvertido + (digito * factor);
        factor = factor / 10;
        copiaNum = copiaNum / 10;
    }
    numeroInvertido = numeroInvertido + copiaNum;
    Console.WriteLine("num ingresado fue: " + numeroEntero);
    Console.WriteLine("num invertido es: " + numeroInvertido);
} */

//  EJERCICIO 2

using System.Diagnostics;
using Microsoft.VisualBasic;
float num1, num2;
/*
double grados,radianes;
int opcion;
do
{
    Console.WriteLine("\nCalculadora V1 \n\n[1] SUMA \n[2] RESTA \n[3] MULTIPLICACION \n[4] DIVISION \n[5] VALOR ABSOLUTO \n[6] VALOR AL CUADRADO \n[7] RAIZ CUADRADA \n[8] SENO \n[9] COSENO \n[10] PARTE ENTERA \n[0] SALIR DEL PROGRAMA");
    Console.WriteLine("\n Su opcion:");
    opcion = ingresarNumeroInt();
    switch (opcion)
    {
        case 1:
            Console.WriteLine("\nIngrese los numeros a sumar");
            num1 = ingresarNumeroFloat();
            num2 = ingresarNumeroFloat();
            Console.WriteLine("\n El resultado de la suma es: " + (num1 + num2));
            break;
        case 2:
            Console.WriteLine("\nIngrese los numeros a restar");
            num1 = ingresarNumeroFloat();
            num2 = ingresarNumeroFloat();
            Console.WriteLine("\n El resultado de la resta es: " + (num1 - num2));
            break;
        case 3:
            Console.WriteLine("\nIngrese los numeros a multiplicar");
            num1 = ingresarNumeroFloat();
            num2 = ingresarNumeroFloat();
            Console.WriteLine("\n El resultado de la multiplicacion es: " + (num1 * num2));
            break;
        case 4:
            Console.WriteLine("\nIngrese los numeros a dividir");        
            num1 = ingresarNumeroFloat();
            num2 = ingresarNumeroFloat();
            Console.WriteLine("\n El resultado de la division es: " + (num1 / num2));
            break;
         case 5:
            Console.WriteLine("\nVALOR ABSOLUTO");        
            num1 = ingresarNumeroFloat();
            Console.WriteLine("\n El resultado del valor absoluto "+ num1 + " es " + Math.Abs(num1));
            break;
         case 6:
            Console.WriteLine("\nVALOR AL CUADRADO");        
            num1 = ingresarNumeroFloat();
            Console.WriteLine("\n El resultado "+ num1 + " elevado al cuadrado es " + Math.Pow(num1,2));
            break;
         case 7:
            Console.WriteLine("\nRAIZ CUADRADA");        
            num1 = ingresarNumeroFloat();
            Console.WriteLine("\n El resultado de la raiz cuadrada de  "+ num1 + " es " + Math.Sqrt(num1));
            break;
         case 8:
            Console.WriteLine("\nSENO (ingresar grados)");        
            num1 = ingresarNumeroFloat();
            grados = Convert.ToDouble(num1);
            radianes = grados * (Math.PI / 180);
            Console.WriteLine("\n El seno de "+ num1 + "° es " + Math.Sin(radianes));
            break;
         case 9:
            Console.WriteLine("\nCOSENO (ingresar grados)");        
            num1 = ingresarNumeroFloat();
            grados = Convert.ToDouble(num1);
            radianes = grados * (Math.PI / 180);
            Console.WriteLine("\n El coseno de "+ num1 + "° es " + Math.Cos(radianes));
            break;
         case 10:
            Console.WriteLine("\nPARTE ENTERA");        
            num1 = ingresarNumeroFloat();
            Console.WriteLine("\n La parte entera de "+ num1 + " es " + Math.Floor(num1));
            break;                                                                   
        case 0:

            break;
        default:
            Console.WriteLine("\nOpcion invalida");
            break;
    }
} while (opcion != 0);


determinarMaxMin();

*/
float ingresarNumeroFloat()
{
    string entrada;
    float num;
    do
    {
        Console.Write("\nIngrese un número: ");
        entrada = Console.ReadLine();

        if (float.TryParse(entrada, out num))
        {
            return num;
        }
        else
        {
            Console.WriteLine("\nEntrada no válida. Por favor ingrese un número válido.");
        }
    } while (true);
}

int ingresarNumeroInt()
{
    int opcion;
    string entrada;
    do
    {
        entrada = Console.ReadLine();
        if (int.TryParse(entrada, out opcion)) 
        {
            return opcion;
        }
        else
        {
            Console.WriteLine("\nEntrada no válida. Por favor, ingrese un número.");
            opcion = -1;
        }
    } while (true);
}
/*
void determinarMaxMin(){
    Console.WriteLine("Ingrese dos numero para comparar");
    num1 = ingresarNumeroFloat();
    num2 = ingresarNumeroFloat();

    if (num1>num2)
    {
        Console.WriteLine("el numero "+ num1+ " es el maximo");
    }else if(num2>num1){
        Console.WriteLine("el numero "+ num2+ " es el maximo");
    }else{
        Console.WriteLine("los numeros ingresados son iguales");
    }
}

*/

// EJERCICIO 4 

Console.WriteLine("\nIngrese una cadena de texto(mas de 4 caracteres)");
string cadena = Console.ReadLine();
int largoCadena;
Console.WriteLine("\n\nCadena ingresada: *"+cadena+"*");
largoCadena = cadena.Length;
Console.WriteLine("\nLargo de cadena: "+ largoCadena);

Console.WriteLine("\nIngrese otra cadena de texto");
string cadena2 = Console.ReadLine();

Console.WriteLine("\ncadenas concatenadas: "+ $"{cadena}-{cadena2}");

Console.WriteLine($"\nsubcadena de la primera cadena de texto: {cadena.Substring(3)}" );


Console.WriteLine("\nIngrese los numeros a sumar");
num1 = ingresarNumeroFloat();
num2 = ingresarNumeroFloat();
float suma = num1 + num2;
Console.WriteLine($"\nLa suma de {num1.ToString()} + {num2.ToString()} es igual a {suma.ToString()}");


Console.WriteLine($"\nRecorro la cadena1: {cadena}");
foreach (char elemento in cadena){
    Console.WriteLine(elemento);
}

Console.WriteLine("Ingrese la palabra a buscar:");
string palabra = Console.ReadLine();

if (cadena.Contains(palabra))
{
    Console.WriteLine($"La palabra \"{palabra}\" se encuentra en la cadena.");
}
else
{
    Console.WriteLine($"La palabra \"{palabra}\" NO se encuentra en la cadena.");
}

Console.WriteLine("\nCadena en mayúsculas: " + cadena.ToUpper());
Console.WriteLine("Cadena en minúsculas: " + cadena.ToLower());

Console.WriteLine("\nIngrese una cadena separada por un carácter:");
string separada = Console.ReadLine();

Console.WriteLine("Ingrese el carácter separador:");
char separador = Console.ReadLine()[0]; 

string[] partes = separada.Split(separador);

Console.WriteLine("\nPartes obtenidas:");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}

