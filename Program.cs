//  EJERCICIO 1
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

int opcion;
do
{
    Console.WriteLine("\nCalculadora V1 \n\n[1] SUMA \n[2] RESTA \n[3] MULTIPLICACION \n[4] DIVISION \n[0] SALIR DEL PROGRAMA");
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
        case 0:

            break;
        default:
            Console.WriteLine("\nOpcion invalida (opcion): " + opcion);
            break;
    }
} while (opcion != 0);

float ingresarNumeroFloat()
{
    string entrada;
    float num;
    do
    {
        Console.WriteLine("\nIngrese un número");
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
        if (int.TryParse(entrada, out opcion)) // Intenta convertir a entero
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