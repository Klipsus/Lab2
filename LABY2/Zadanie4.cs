using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//Zadanie4
//Napisz program, który przeanalizuje tekst wprowadzony przez użytkownika
//Program powinien:
//Poprosić użytkownika o wprowadzenie jednego ciągu tekstowego (np. zdania).
//Zliczyć liczbę wystąpień każdego znaku w tekście.
//Zliczyć liczbę wystąpień każdego słowa.
//Wypisać najczęściej występujący znak.
//Wypisać najczęściej występujące słowo.
public class Zad4
{
    public static void Zadanie4()
    {
        Console.WriteLine("Wprowadź zdanie lub tekst do analizy:");
        string input = Console.ReadLine();

        string tekst = Regex.Replace(input.ToLower(), @"[^\w\s]", "");

        var znaki = tekst.Where(c => !char.IsWhiteSpace(c))
                         .GroupBy(c => c)
                         .Select(g => new { Znak = g.Key, Licznik = g.Count() })
                         .OrderByDescending(x => x.Licznik);

        var slowa = tekst.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                         .GroupBy(w => w)
                         .Select(g => new { Slowo = g.Key, Licznik = g.Count() })
                         .OrderByDescending(x => x.Licznik);

        Console.WriteLine("\nCzęstotliwość znaków:");
        foreach (var z in znaki)
        {
            Console.WriteLine($"Znak '{z.Znak}' występuje {z.Licznik} razy");
        }

        Console.WriteLine("\nCzęstotliwość słów:");
        foreach (var s in slowa)
        {
            Console.WriteLine($"Słowo \"{s.Slowo}\" występuje {s.Licznik} razy");
        }

        Console.WriteLine($"\nNajczęstszy znak: '{znaki.First().Znak}' ({znaki.First().Licznik} razy)");
        Console.WriteLine($"Najczęstsze słowo: \"{slowa.First().Slowo}\" ({slowa.First().Licznik} razy)");
    }
}
