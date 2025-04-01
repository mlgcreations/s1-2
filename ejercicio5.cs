Console.Write("Ingrese el número de valores: ");
int n = int.Parse(Console.ReadLine());

int mayor = int.MinValue;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese el valor " + i +":");
    int valor = int.Parse(Console.ReadLine());

    if (valor > mayor)
    {
        mayor = valor;
    }
}

Console.WriteLine("El mayor valor ingresado es: "+mayor);
