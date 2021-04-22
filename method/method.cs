public class Warrior
{
    private int height; // here the height is fields of Warrior class because it start with lowercase(h)
    private int weight; // here the weight is fields of Warrior class because it start with lowercase(w)

    // here the Height is property of Warrior class because it start with Upercase(H)
    // the way of defining property is like u see here
    // get; and set; allow us to get and set the Height variable
    public int Height { get; set; }
    public int Weight { get; set; }
    public string Name { get; set; }
    // feilds are for internal use only
    // propertes are for external use only

    // this is a function inside a class because of that we call it method or action inside class
    public void Greeting(Warrior warrior)
    {
        System.Console.WriteLine($@"Greetings {warrior.Name}!");
    }
}


public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior();
        theGoodGuy.Height = 190;
        theGoodGuy.Weight = 80;
        theGoodGuy.Name = "abi";

        Warrior theBadGuy = new Warrior();
        theBadGuy.Height = 170;
        theBadGuy.Weight = 90;
        theBadGuy.Name = "hamidreza";

        System.Console.WriteLine(theGoodGuy.Height);
        System.Console.WriteLine(theBadGuy.Height);

        theGoodGuy.Greeting(theBadGuy);

    }
}
