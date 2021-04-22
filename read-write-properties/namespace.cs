using characters;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(190, 80, "abi");

        Warrior theBadGuy = new Warrior(170, 90, "hamidreza");

        System.Console.WriteLine(theGoodGuy.Height);
        System.Console.WriteLine(theBadGuy.Height);

        theGoodGuy.Greeting(theBadGuy);

    }
}
