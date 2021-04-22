using characters;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(190, 80, "abi", 40);

        Warrior theBadGuy = new Warrior(170, 90, "hamidreza", 26);

        System.Console.WriteLine(theGoodGuy.Height);
        System.Console.WriteLine(theBadGuy.Height);
        System.Console.WriteLine(theGoodGuy.Age);
        System.Console.WriteLine(theBadGuy.Age);

        theGoodGuy.Greeting(theBadGuy);

        System.Console.WriteLine(theGoodGuy.SwordWeapon.Damage);

    }
}
