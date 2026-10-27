
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Rogue : Entity.Character
{
    public Rogue(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 95;
        Strength = 9;
        Intelligence = 8;
        Agility = 15;
        Defense = 7;
        Mana = 10;
    }

    public override void Attack()
    {
        Console.WriteLine("Łotrzyk wykonuje szybkie cięcie!");
        Console.WriteLine($"Obrażenia: {Agility * 3}");
    }

    public override void UseSpecial()
    {
        Console.WriteLine("Łotrzyk używa Ciosu w Cień!");
        Console.WriteLine("Łotrzyk znika w mroku i zaskakuje przeciwnika!");
    }
}
