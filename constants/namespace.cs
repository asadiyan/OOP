using characters;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(190, 80, "abi", 40);
        Warrior theBadGuy = new Warrior(170, 90, "hamidreza", 26);
        Warrior youngGuy = new Warrior(150, 50);

        System.Console.WriteLine(theGoodGuy.Id);
        System.Console.WriteLine(theBadGuy.Id);
        System.Console.WriteLine(youngGuy.Id);
        //System.Console.WriteLine(theGoodGuy.Height);
        //System.Console.WriteLine(theBadGuy.Height);
        //System.Console.WriteLine(theGoodGuy.Age);
        //System.Console.WriteLine(theBadGuy.Age);
        //System.Console.WriteLine(youngGuy.Age);

        //theGoodGuy.Greeting(theBadGuy);

        //System.Console.WriteLine(theGoodGuy.SwordWeapon.Damage);

    }
}
