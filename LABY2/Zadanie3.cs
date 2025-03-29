using System;

public class Zad3
{
    public Zad3()
    {
    }

    public static void Zadanie3()
    {
        Console.WriteLine("Podaj wymiar macierzy kwadratowej:");
        int n = int.Parse(Console.ReadLine());

        int[,] A = new int[n, n];
        int[,] B = new int[n, n];
        int[,] wynik;

        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = rand.Next(-10, 11);
                B[i, j] = rand.Next(-10, 11);
            }
        }

        Console.WriteLine("\nMacierz A:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j].ToString().PadLeft(5));
            Console.WriteLine();
        }

        Console.WriteLine("\nMacierz B:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(B[i, j].ToString().PadLeft(5));
            Console.WriteLine();
        }

        Console.WriteLine("\nA + B:");
        wynik = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                wynik[i, j] = A[i, j] + B[i, j];
        WypiszMacierz(wynik);

        Console.WriteLine("\nA - B:");
        wynik = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                wynik[i, j] = A[i, j] - B[i, j];
        WypiszMacierz(wynik);

        Console.WriteLine("\nA * B:");
        wynik = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                    wynik[i, j] += A[i, k] * B[k, j];
        WypiszMacierz(wynik);
    }

    // Pomocnicza metoda do wypisywania macierzy
    public static void WypiszMacierz(int[,] macierz)
    {
        int n = macierz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(macierz[i, j].ToString().PadLeft(5));
            Console.WriteLine();
        }

    }
}
