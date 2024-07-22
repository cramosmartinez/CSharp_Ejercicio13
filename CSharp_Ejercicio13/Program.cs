//Comprobar si un numero introducido por consola es primo
Console.WriteLine("Ingrese un número:");
int numero125 = Convert.ToInt32(Console.ReadLine());
bool esPrimo = true;
for (int i = 2; i < numero125; i++)
{
    if (numero125 % i == 0)
    {
        esPrimo = false;
        break;
    }
}
if (esPrimo)
{
    Console.WriteLine("El número " + numero125 + " es primo.");
}
else
{
    Console.WriteLine("El número " + numero125 + " no es primo.");
}
