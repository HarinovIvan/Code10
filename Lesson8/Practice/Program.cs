using System;

abstract class Creature
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Creature (string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack(Creature target);
    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if(Health < 0)
        {
            Health = 0;
        }
    }
}

class Hero : Creature
{
    public int AttackPower { get; set; }

    public Hero(string name, int health, int AttackPower) : base(name, health)
    {
        AttackPower = attackPower;
    }

    public override void Attack(Creature target)
    {
        target.TakeDamage(AttackPower);
        Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage");
    }

}

class Monster : Creature 
{
    public int AttackPower{get; set;}
    public Monster(string name, int health, int attackPower) : base(name, health)
    {
        AttackPower = attackPower;
    }

    public override void Attack(Creature target)
    {
        target.TakeDamage(AttackPower);
        System.Console.WriteLine($"{name} attacks {target.Name} for {AttackPower} damage");
    }
}

class Item
{
    public string Name {get; set;}
    public string Description {get; set;}

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Use(Hero Hero)
    {
        Console.WriteLine($"Using {Name}: {Description}");
    }

}

class HealingPotion : Item
{
    private int healingAmount;

    public HealingPotion(string name, string description, int healingAmount)
    {
        Name = name;
        Description = description;
        this.healingAmount = healingAmount;
    }

    public override void Use(Hero hero)
    {
        hero.Health += healingAmount;
        Console.WriteLine($"Using {Name}: {Description}. Health restored by {healingAmount}");
    }
}

public class Game
{
    private Hero hero;
    private List<Monster> monsters;
    private List<Item> inventory;

    public Game()
    {
        hero = new Hero("Knight", 100, 20);
        monsters = new List<Monster>
        {
            new Monster("Goblin", 30, 5),
            new Monster("Orc", 50, 10)
        };
        inventory = new List<Item>
        {
            new HealingPotion("Small Healing Potion", "Heals 20 health points", 20)
        };
    }

    public void Play()
    {
        Console.WriteLine("Welcome to the RPG Game!");
        Console.WriteLine($"{hero.Name} starts the journey with {hero.Health} health and {hero.AttackPower} attack power.");

        foreach (var monster in monsters)
        {
            Console.WriteLine($"\nA wild {monster.Name} appears!");

            while (monster.Health > 0 && hero.Health > 0)
            {
                hero.Attack(monster);
                if (monster.Health > 0)
                {
                    monster.Attack(hero);
                }
            }

            if (hero.Health > 0)
            {
                Console.WriteLine($"{hero.Name} defeated the {monster.Name}!");
            }
            else
            {
                Console.WriteLine($"{hero.Name} was defeated by the {monster.Name}...");
                return;
            }
        }

        Console.WriteLine($"\n{hero.Name} has defeated all the monsters!");

        foreach (var item in inventory)
        {
            item.Use(hero);
        }

        Console.WriteLine($"{hero.Name} has {hero.Health} health remaining after using items.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Play();
    }
}





