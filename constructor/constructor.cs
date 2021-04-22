public class Warrior
{
    private int height; // here the height is field of Warrior class because it start with lowercase(h)
    private int weight; // here the weight is field of Warrior class because it start with lowercase(w)
    private string name; // here the name is field of Warrior class because it start with lowercase(w)

    // here the Height is property of Warrior class because it start with Upercase(H)
    // the way of defining property is like u see here
    // get; and set; allow us to get and set the Height variable
    public int Height { get; set; }
    public int Weight { get; set; }
    public string Name { get; set; }
    // feilds are for internal use only
    // propertes are for external use only

    // creating constructor:
    public Warrior(int height, int weight, string name)
    {
        Height = height;
        Weight = weight;
        Name = name;
    }


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
        Warrior theGoodGuy = new Warrior(190, 80, "abi");

        Warrior theBadGuy = new Warrior(170, 90, "hamidreza");

        System.Console.WriteLine(theGoodGuy.Height);
        System.Console.WriteLine(theBadGuy.Height);

        theGoodGuy.Greeting(theBadGuy);

    }
}
