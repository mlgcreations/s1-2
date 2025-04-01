using System.Timers;

int[] randarray = new int[41];
var rand = new Random();
int valor = 21;
int suma = 0;
Console.WriteLine("Calificaiones");
for (int ctr = 1; ctr < 41; ctr++)
{
   
    randarray[ctr] = rand.Next(1, 21);
    Console.WriteLine(randarray[ctr]);
    suma = suma + randarray[ctr];
    if (valor > randarray[ctr])
    {
        valor = randarray[ctr];
    }
}

Console.WriteLine("El promedio es:"+ suma/40);
Console.WriteLine("La menor calificacion es:" + valor);
