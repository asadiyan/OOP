using characters;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior.GetDefaultValue();

        Warrior firstWarrior = new Warrior(190, 90, "abi", 40, Faction.GoodGuy);
        Warrior secondWarrior = new Warrior(170, 70, "hamidreza", 26, Faction.BadGuy);
        Warrior thirdWarrior = new Warrior(150, 50, "someOne", 23, Faction.BadGuy);
        Warrior fourthWarrior = new Warrior(180, 80, "someName", 25, Faction.GoodGuy);

        Console.WriteLine(secondWarrior.HealthPoint);
        //Tools.ColorFullWriteLine(theGoodGuy.Id.ToString(), System.ConsoleColor.Blue);
        //Tools.ColorFullWriteLine(theBadGuy.Id.ToString(), System.ConsoleColor.Red);
        //Tools.ColorFullWriteLine(theYoungGuy.Id.ToString(), System.ConsoleColor.Green);

        //System.Console.WriteLine(theGoodGuy.Id);
        //System.Console.WriteLine(theBadGuy.Id);
        //System.Console.WriteLine(youngGuy.Id);
        //System.Console.WriteLine(theGoodGuy.Height);
        //System.Console.WriteLine(theBadGuy.Height);
        //System.Console.WriteLine(theGoodGuy.Age);
        //System.Console.WriteLine(theBadGuy.Age);
        //System.Console.WriteLine(youngGuy.Age);

        //theGoodGuy.Greeting(theBadGuy);

        //System.Console.WriteLine(theGoodGuy.SwordWeapon.Damage);

    }
}
