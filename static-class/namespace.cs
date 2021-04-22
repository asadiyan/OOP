using characters;

public class EntryPoint
{
    static void Main()
    {
        Warrior.GetDefaultValue();

        Warrior theGoodGuy = new Warrior(190, 80, "abi", 40);
        Warrior theBadGuy = new Warrior(170, 90, "hamidreza", 26);
        Warrior theYoungGuy = new Warrior(150, 50);


        Tools.ColorFullWriteLine(theGoodGuy.Id.ToString(), System.ConsoleColor.Blue);
        Tools.ColorFullWriteLine(theBadGuy.Id.ToString(), System.ConsoleColor.Red);
        Tools.ColorFullWriteLine(theYoungGuy.Id.ToString(), System.ConsoleColor.Green);

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
