using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string plikWejsciowy = "ranking_raw.txt";
        string plikWyjsciowy = "ranking_clean.txt";

        try
        {
            Console.WriteLine("Katalog roboczy:");
            Console.WriteLine(Directory.GetCurrentDirectory());

            if (!File.Exists(plikWejsciowy))
            {
                Console.WriteLine("Blad: Nie znaleziono pliku ranking_raw.txt!");
                return;
            }

            string[] linie = File.ReadAllLines(plikWejsciowy);

            List<string> rankingClean = new List<string>();

            rankingClean.Add("Nick;Czas;Punkty;Status;Opis");

            for (int i = 1; i < linie.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(linie[i]))
                {
                    continue;
                }

                string[] pola = linie[i].Split(';');

                if (pola.Length != 5)
                {
                    Console.WriteLine(
                        $"Blad w linii {i + 1}: Nieprawidlowa liczba pol."
                    );
                    continue;
                }

                for (int j = 0; j < pola.Length; j++)
                {
                    pola[j] = pola[j].Trim();
                }

                if (!int.TryParse(pola[2], out int punkty))
                {
                    punkty = 0;
                }

                pola[2] = punkty.ToString();

                string czas = pola[1];
                string status = pola[3];

                if (status == "HACKER" ||
                    czas == "00:00:01" ||
                    czas == "0:00:01")
                {
                    Console.WriteLine(
                        $"Odrzucono wynik gracza: {pola[0]}"
                    );
                    continue;
                }

                string poprawionaLinia = string.Join(";", pola);

                rankingClean.Add(poprawionaLinia);
            }

            File.WriteAllLines(plikWyjsciowy, rankingClean);

            Console.WriteLine();
            Console.WriteLine("Ranking zostal oczyszczony i zapisany!");
            Console.WriteLine();

            if (File.Exists(plikWyjsciowy))
            {
                string[] wynik = File.ReadAllLines(plikWyjsciowy);

                Console.WriteLine("===== OCZYSZCZONY RANKING =====");

                foreach (string linia in wynik)
                {
                    Console.WriteLine(linia);
                }

                Console.WriteLine("===============================");
            }
            else
            {
                Console.WriteLine("Blad: Nie znaleziono pliku wynikowego.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Blad operacji na pliku: " + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Brak uprawnien do pliku: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystapil nieoczekiwany blad: " + ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Nacisnij dowolny klawisz, aby zakonczyc.");
        Console.ReadKey();
    }
}