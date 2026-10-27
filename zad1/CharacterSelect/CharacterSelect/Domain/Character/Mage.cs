
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Mage : Entity.Character
{
    public Mage(string name) : base(name, CharacterClass.Mage)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Defense = 5;
        Mana = 25;
    }

    public override void Attack()
    {
        Console.WriteLine("Mag rzuca magiczny pocisk!");
        Console.WriteLine($"Obrażenia: {Intelligence * 3}");
    }

    public override void UseSpecial()
    {
        Console.WriteLine("Mag używa Kuli Ognia!");
        Console.WriteLine("Przeciwnik zostaje trafiony potężnym płomieniem!");
    }
}
