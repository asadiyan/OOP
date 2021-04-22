public class Warrior
{
    private int height; // here the height is fields of Warrior class because it start with lowercase(h)
    private int weight; // here the weight is fields of Warrior class because it start with lowercase(w)

    // here the Height is property of Warrior class because it start with Upercase(H)
    // the way of defining property is like u see here
    // get; and set; allow us to get and set the Height variable
    public int Height { get; set; }
    public int Weight { get; set; }

// feilds are for internal use only
// propertes are for external use only
}


public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior();
        theGoodGuy.Height = 190;
        theGoodGuy.Weight = 80;

        Warrior theBadGuy = new Warrior();
        theBadGuy.Height = 170;
        theBadGuy.Weight = 90;

        System.Console.WriteLine(theGoodGuy.Height);
        System.Console.WriteLine(theBadGuy.Height);

    }
}
