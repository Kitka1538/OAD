using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 90;
        Strength = 8;
        Intelligence = 6;
        Agility = 18;
        Defense = 7;
        Mana = 8;
    }

    public override void Attack()
    {
        Console.WriteLine("Łucznik wypuszcza strzałę!");
        Console.WriteLine($"Obrażenia: {Agility * 3}");
    }

    public override void UseSpecial()
    {
        Console.WriteLine("Łucznik używa Gradu Strzał!");
        Console.WriteLine("Przeciwnik zostaje zasypany strzałami!");
    }
}