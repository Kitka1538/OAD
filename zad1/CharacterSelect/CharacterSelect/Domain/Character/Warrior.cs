
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Warrior : Entity.Character
{
    public Warrior(string name) : base(name, CharacterClass.Warrior)
    {
        Health = 120;
        Strength = 14;
        Intelligence = 6;
        Agility = 8;
        Defense = 12;
        Mana = 5;
    }

    public override void Attack()
    {
        Console.WriteLine("Wojownik wykonuje potężne uderzenie!");
        Console.WriteLine($"Obrażenia: {Strength * 3}");
    }

    public override void UseSpecial()
    {
        Console.WriteLine("Wojownik używa Szału Bitewnego!");
        Console.WriteLine("Wojownik zbiera siły i przygotowuje się do niszczycielskiego ataku!");
    }
}
