public class Warrior
{
    public int height;
    public int weight;
}

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior();
        theGoodGuy.height = 190;
        theGoodGuy.weight = 80;

        Warrior theBadGuy = new Warrior();
        theBadGuy.height = 170;
        theBadGuy.weight = 90;

        System.Console.WriteLine(theGoodGuy);
        System.Console.WriteLine(theBadGuy);

    }
}
