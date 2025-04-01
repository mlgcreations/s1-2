using System.Timers;

int[] randarray = new int[8];
var rand = new Random();
int suma = 0;
Console.WriteLine("Calificaiones");
for (int ctr = 1; ctr < 8; ctr++)
{
   
    randarray[ctr] = rand.Next(1, 21);
    Console.WriteLine(randarray[ctr]);
    suma = suma + randarray[ctr];
}

Console.WriteLine("El promedio es:"+ suma/7);
