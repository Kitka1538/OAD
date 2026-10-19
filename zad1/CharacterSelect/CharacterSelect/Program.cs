using CharacterSelect.Domain.Enum;

namespace CharacterSelect
{
    public static class Program
    {
        private static readonly string[] Classes =
        {
            "Wojownik", "Mag", "Łotrzyk", "Zabójca", "Łucznik",
        };

        private static readonly int[] Strength = { 15, 5, 10, 12, 8 };
        private static readonly int[] Intelligence = { 5, 18, 8, 10, 7 };
        private static readonly int[] Dexterity = { 8, 7, 18, 20, 18 };
        private static readonly int[] Defense = { 15, 5, 7, 6, 5 };
        private static readonly int[] Mana = { 5, 20, 8, 8, 6 };

        public static void Main()
        {
            Console.Title = "Character Select";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== WYBÓR POSTACI ===");

                for (int i = 0; i < Classes.Length; i++)
                    Console.WriteLine($"{i + 1}) {Classes[i]}");

                Console.WriteLine("0) Wyjście");
                Console.Write("Wybierz klasę: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                    continue;

                if (choice == 0)
                    break;

                if (choice < 1 || choice > Classes.Length)
                {
                    Pause("Niepoprawny wybór.");
                    continue;
                }

                int index = choice - 1;

                Console.Write("Podaj imię postaci: ");
                string name = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(name))
                    name = Classes[index];

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"=== {name} — {Classes[index]} ===");
                    Console.WriteLine($"Siła: {Strength[index]}");
                    Console.WriteLine($"Inteligencja: {Intelligence[index]}");
                    Console.WriteLine($"Zręczność: {Dexterity[index]}");
                    Console.WriteLine($"Obrona: {Defense[index]}");
                    Console.WriteLine($"Mana: {Mana[index]}");

                    Console.WriteLine("\n1. Atak");
                    Console.WriteLine("2. Umiejętność specjalna");
                    Console.WriteLine("3. Powrót");
                    Console.Write("Wybierz akcję: ");

                    string? action = Console.ReadLine();

                    if (action == "1")
                    {
                        int mainStat = index switch
                        {
                            1 => Intelligence[index],
                            2 or 3 or 4 => Dexterity[index],
                            _ => Strength[index]
                        };

                        Console.WriteLine($"\n{name} wykonuje atak!");
                        Console.WriteLine($"Obrażenia: {mainStat * 3}");
                        Pause("Naciśnij Enter...");
                    }
                    else if (action == "2")
                    {
                        string[] skills =
                        {
                            "Potężne uderzenie!",
                            "Kula Ognia!",
                            "Cios z ukrycia!",
                            "Śmiertelne cięcie!",
                            "Grad strzał!",
                        };

                        Console.WriteLine($"\n{name} używa umiejętności: {skills[index]}");
                        Console.WriteLine("Przeciwnik zostaje trafiony!");
                        Pause("Naciśnij Enter...");
                    }
                    else if (action == "3")
                    {
                        break;
                    }
                    else
                    {
                        Pause("Niepoprawny wybór.");
                    }
                }

                Console.Write("\nUtworzyć kolejną postać? (t/n): ");
                string again = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();

                if (again != "t" && again != "tak")
                    break;
            }

            Console.WriteLine("Dzięki za grę! Do zobaczenia!");
        }

        private static void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
