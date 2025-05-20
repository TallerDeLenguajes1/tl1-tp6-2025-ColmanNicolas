// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World 1 !");

/*int numeroEntero = 1450, i = 0;
int digitos[10];

if (numeroEntero > 0)
{
    while (numeroEntero / 10 > 10)
    {
        digitos[i] = numeroEntero % 10;
        i++;
        numeroEntero = numeroEntero / 10;
    }
    digitos[i + 1] = numeroEntero;

    for (int a = 0; a < i; a++)
    {
        Console.WriteLine("\n" + digitos[a]);
    }
}

*/


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
}