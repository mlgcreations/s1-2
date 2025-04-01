int[] randarray = new int[10];
var rand = new Random();

Console.WriteLine("Diez enteros aleatorios entre 1 y 100:");
for (int ctr = 1; ctr < 10; ctr++)
{
    randarray[ctr] = rand.Next(1, 101);
    Console.WriteLine(randarray[ctr]);
}

for (int ctr = 1; ctr < 10; ctr++)
{
   
    if (randarray[ctr] % 2 == 0)
    {
        string valor = randarray[ctr].ToString();
        Console.WriteLine("El número par " + (ctr + 1) + " es: " + valor);
    }
}
