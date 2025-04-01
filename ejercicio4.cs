Console.Write("Ingrese el número de obreros: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write($"Ingrese las horas trabajadas por el obrero {i}: ");
    int horasTrabajadas = int.Parse(Console.ReadLine());

    double salario = CalcularSalario(horasTrabajadas);
    Console.WriteLine($"El salario del obrero {i} es: ${salario}");
}
static double CalcularSalario(int horas)
{
    const double tarifaNormal = 20;
    const double tarifaExtra = 25;
    const int limiteHoras = 40;

    if (horas <= limiteHoras)
    {
        return horas * tarifaNormal;
    }
    else
    {
        int horasExtras = horas - limiteHoras;
        return (limiteHoras * tarifaNormal) + (horasExtras * tarifaExtra);
    }
}
