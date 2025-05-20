// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World! 2");

float num1, num2;
int opcion = 0;
do
{
    int aux = 1;

    Console.WriteLine("\nCalculadora V1 \n\n[1] SUMA \n[2] RESTA \n[3] MULTIPLICACION \n[4] DIVISION \n[0] SALIR DEL PROGRAMA");
    Console.WriteLine("\n Su opcion:");
    opcion = Convert.ToInt32(Console.Read());
            Console.WriteLine("\nOpcion ingresada(opcion): " + opcion);
    switch (opcion)
    {
        case 1:
            num1 = ingresarNumero(aux);
            num2 = ingresarNumero(aux++);
            Console.WriteLine("\n El resultado de la suma es: " + (num1 + num2));
            break;
        case 2:
            num1 = ingresarNumero(aux);
            num2 = ingresarNumero(aux++);
            Console.WriteLine("\n El resultado de la resta es: " + (num1 - num2));
            break;
        case 3:
            num1 = ingresarNumero(aux);
            num2 = ingresarNumero(aux++);
            Console.WriteLine("\n El resultado de la multiplicacion es: " + (num1 * num2));
            break;
        case 4:
            num1 = ingresarNumero(aux);
            num2 = ingresarNumero(aux++);
            Console.WriteLine("\n El resultado de la division es: "+ (num1 / num2));
            break;
        case 0:
            Console.WriteLine("\nsoy la opcion 0");
            break;
        default:
            Console.WriteLine("\nOpcion invalida (opcion): " + opcion);
            break;
    }
    aux = 1;
} while (opcion != 0);

float ingresarNumero(int aux)
{
    Console.WriteLine("\n Ingrese el numero " + aux + " :");
    return Console.Read();
}