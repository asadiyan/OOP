namespace characters
{
    public class Warrior
    {
        private int height; // here the height is field of Warrior class because it start with lowercase(h)
        private int weight; // here the weight is field of Warrior class because it start with lowercase(w)
        private string name; // here the name is field of Warrior class because it start with lowercase(w)

        // here the Height is property of Warrior class because it start with Upercase(H)
        // the way of defining property is like u see here
        // get; and set; allow us to get and set the Height variable
        public int Height
        {
            // here our height is just read only because we dont have the setter we cant write anything inside it
            get
            {
                return height;
            }
            //set
            //{
            //    height = value;
            //}
        }

        public int Weight
        {
            // here weight is just write only because we dont have geteer, we cant read anything form inside it

            //get
            //{
            //    return weight;
            //}
            set
            {
                weight = value;
            }
        }

        public string Name
        {
            // here our name is read and write because we have the both get and set inside of property
            get
            {
                return name;
            }
            private set // by having private set we cant set name outside of class, we can set it in the first but we cant change it after
            {
                name = value;
            }
        }
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
}
