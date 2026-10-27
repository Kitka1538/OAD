using System;
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Entity;

public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }
    public int Defense { get; protected set; }
    public int Mana { get; protected set; }

    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

public virtual void Describe()
{
    Console.WriteLine($"[{Class}] {Name}");
    Console.WriteLine($"  HP: {Health}");
    Console.WriteLine($"  STR: {Strength}");
    Console.WriteLine($"  INT: {Intelligence}");
    Console.WriteLine($"  AGI: {Agility}");
    Console.WriteLine($"  Defense: {Defense}");
    Console.WriteLine($"  Mana: {Mana}");
}
    public virtual void Attack()
    {
        int damage = Strength * 3;

        Console.WriteLine($"{Name} wykonuje atak!");
        Console.WriteLine($"Obrażenia: {damage}");
    }

    public virtual void UseSpecial()
    {
        Console.WriteLine($"{Name} używa umiejętności specjalnej!");
    }
}