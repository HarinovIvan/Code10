using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Reflection.Metadata;

// Идея игры:
// Игрок управляет героем, который может сражаться с монстрами и собирать сокровища.
// В игре есть несколько типов монстров и предметов. Герой может атаковать и получать урон.


// Creature - абстрактный базовый класс, представляющий общее существо с именем и здоровьем. Включает абстрактный метод Attack и виртуальный метод TakeDamage.
// Hero - класс, представляющий героя, наследует Creature. Реализует метод Attack, который атакует другое существо.
// Monster - класс, представляющий монстра, наследует Creature. Также реализует метод Attack.
// Item - базовый класс для предметов, содержит имя и описание, а также виртуальный метод Use.
// HealingPotion - класс, представляющий зелье лечения, наследует Item. Переопределяет метод Use, чтобы увеличивать здоровье героя.
// Game - класс, управляющий игрой. Содержит героя, список монстров и инвентарь предметов. Метод Play запускает игру, где герой сражается с монстрами и использует предметы.
// Program - основной класс, запускающий игру.
>>>>>>> upstream/main

abstract class Creature
{
    public string Name { get; set; }
    public int Health { get; set; }

<<<<<<< HEAD
    public Creature (string name, int health)
=======
    public Creature(string name, int health)
>>>>>>> upstream/main
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack(Creature target);
<<<<<<< HEAD
    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if(Health < 0)
=======
    public virtual void TakeDamage(int damage) 
    {
        Health -= damage;
        if (Health < 0)
>>>>>>> upstream/main
        {
            Health = 0;
        }
    }
}

class Hero : Creature
{
    public int AttackPower { get; set; }
<<<<<<< HEAD

    public Hero(string name, int health, int AttackPower) : base(name, health)
=======
    public Hero(string name, int health, int attackPower) : base(name, health)
>>>>>>> upstream/main
    {
        AttackPower = attackPower;
    }

    public override void Attack(Creature target)
    {
        target.TakeDamage(AttackPower);
<<<<<<< HEAD
        Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage");
    }

}

class Monster : Creature 
{
    public int AttackPower{get; set;}
=======
        System.Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage");
    }
}

class Monster : Creature
{
    public int AttackPower { get; set; }

>>>>>>> upstream/main
    public Monster(string name, int health, int attackPower) : base(name, health)
    {
        AttackPower = attackPower;
    }

    public override void Attack(Creature target)
    {
        target.TakeDamage(AttackPower);
<<<<<<< HEAD
        System.Console.WriteLine($"{name} attacks {target.Name} for {AttackPower} damage");
=======
        System.Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage");
>>>>>>> upstream/main
    }
}

class Item
{
<<<<<<< HEAD
    public string Name {get; set;}
    public string Description {get; set;}
=======
    public string Name { get; set; }
    public string Description { get; set; }
>>>>>>> upstream/main

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }

<<<<<<< HEAD
    public virtual void Use(Hero hero)
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





=======
    public virtual void Use(Hero player)
    {
        // Практика B 3.
    }
}



public class Program
{
    public static void Main()
    {

    }
}
>>>>>>> upstream/main
