using System;

public class Zad2
{
	public Zad2()
	{
	}
	public static void Zadanie2()
	{
		double[] zbior = { 2, 3, 3.5, 4, 4.5, 5 };
		Random rand = new Random();
		
        Console.WriteLine("Podaj długość tablicy");
		int input = int.Parse(Console.ReadLine());
		double [] z = new double[input];
		for (int i = 0; i < input; i++) {

            int random_index = rand.Next(0, zbior.Length);
			z[i] = zbior[random_index];
        }
		Console.WriteLine($"Średnia liczb tablicy to {z.Average()}");
		Console.WriteLine($"Największa wartość z tablicy {z.Max()}");
		Console.WriteLine($"Najmniejsza wartość z tablicy to {z.Min()}");
		List<double> higher_than_avg = new List<double>();
		foreach (double i in z) { 
		if(i>z.Average()) higher_than_avg.Add(i);
		}
		Console.WriteLine("Wartości wyższe od średniej");
        Console.WriteLine(string.Join(", ", higher_than_avg));
        var powtorzenia = z.GroupBy(x => x).Select(g => new { Wartosc = g.Key, Licznik = g.Count() });

        Console.WriteLine("Powtarzające się wartości:");
        foreach (var el in powtorzenia)
        {
            Console.WriteLine($"Wartość {el.Wartosc} występuje {el.Licznik} razy");
        }
        double srednia = z.Average();
        double wariancja = z.Select(x => Math.Pow(x - srednia, 2)).Average();
        double odchylenie = Math.Sqrt(wariancja);

        Console.WriteLine($"Odchylenie standardowe: {odchylenie}");


    }
}
