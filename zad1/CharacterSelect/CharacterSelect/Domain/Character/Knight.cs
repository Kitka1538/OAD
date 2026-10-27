using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Knight : Entity.Character
{
    public Knight(string name) : base(name, CharacterClass.Knight)
    {
        Health = 150;
        Strength = 18;
        Intelligence = 5;
        Agility = 7;
        Defense = 20;
        Mana = 5;
    }

    public override void Attack()
    {
        Console.WriteLine("Rycerz wykonuje potężny cios!");
        Console.WriteLine($"Obrażenia: {Strength * 3}");
    }

    public override void UseSpecial()
    {
        Console.WriteLine("Rycerz używa Tarczy Obrońcy!");
        Console.WriteLine("Przygotowuje się do zablokowania ataku przeciwnika!");
    }
}