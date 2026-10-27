using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Paladin : Entity.Character
{
    public Paladin(string name) : base(name, CharacterClass.Paladin)
    {
        Health = 140;
        Strength = 15;
        Intelligence = 12;
        Agility = 6;
        Defense = 18;
        Mana = 15;
    }

    public override void Attack()
    {
        Console.WriteLine("Paladyn atakuje świętym orężem!");
        Console.WriteLine($"Obrażenia: {Strength * 3}");
    }

    public override void UseSpecial()
    {
        Console.WriteLine("Paladyn używa Świętego Uderzenia!");
        Console.WriteLine("Święta energia uderza przeciwnika!");
    }
}