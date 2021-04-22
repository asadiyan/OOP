namespace characters
{
    public class Warrior
    {
        private int height; // here the height is field of Warrior class because it start with lowercase(h)
        private int weight; // here the weight is field of Warrior class because it start with lowercase(w)
        private int age;    //here the age is field of Warrior class because it start with lowercase(a)
        private string name;// here the name is field of Warrior class because it start with lowercase(n)

        // here the Height is property of Warrior class because it start with Upercase(H)
        // the way of defining property is like u see here
        // get; and set; allow us to get and set the Height variable
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value >= 18 && value <= 45)
                {
                    this.age = value;
                }
                else
                {
                    // when code gets here exeption cause to stop the progra from compile and run
                    throw new System.ArgumentOutOfRangeException(string.Empty, $@"the selected age for {this.name} is not a proper age for a warrior, the age should be between 18  and 45!");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        // feilds are for internal use only
        // propertes are for external use only

        // creating constructor:
        public Warrior(int height, int weight, string name, int age)
        {
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = age;
        }


        // this is a function inside a class because of that we call it method or action inside class
        public void Greeting(Warrior warrior)
        {
            System.Console.WriteLine($@"{this.name} Greetes {warrior.Name}!");
        }
    }
}
