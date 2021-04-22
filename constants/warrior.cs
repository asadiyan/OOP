namespace characters
{
    public class Warrior
    {
        private const int DEFAULT_HEIGHT = 150;
        private const int DEFAULT_WEIGHT = 50;
        private const string DEFAULT_NAME = "unKnownWarrior";
        private const int DEFAULT_AGE = 18;

        // we cant assign object to a const constant so we use readonly constant
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        // initoalizing static field
        private static int idCounter;

        // readonly is a way to declare constant, now id is constant we can put anything in it after decleration
        private readonly int id;
        private int height;                 // here the height is field of Warrior class because it start with lowercase(h)
        private int weight;                 // here the weight is field of Warrior class because it start with lowercase(w)
        private int age;                    // here the age is field of Warrior class because it start with lowercase(a)
        private string name;                // here the name is field of Warrior class because it start with lowercase(n)
        private Sword swordWeapon;          // here the swordWeapon is field of Warrior class because it start with lowercase(s)

        // here the Height is property of Warrior class because it start with Upercase(H)
        // the way of defining property is like u see here
        // get; and set; allow us to get and set the Height variable
        public static int IdCounter
        {
            get
            {
                return idCounter;
            }
            private set
            {
                idCounter = value;
            }
        }


        public int Id
        {
            get
            {
                return this.id;
            }
        }



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


        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        // feilds are for internal use only
        // propertes are for external use only

        // creating constructor:
        public Warrior(int height, int weight, string name, int age)
        {
            idCounter++;
            this.id = idCounter;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = age;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;
        }

        // creating second constructor
        public Warrior(int weight, int height)
            :this(weight, height, DEFAULT_NAME, DEFAULT_AGE)
        {

        }

        // creating third constructor
        public Warrior()
            :this(DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {

        }

        // this is a function inside a class because of that we call it method or action inside class
        public void Greeting(Warrior warrior)
        {
            System.Console.WriteLine($@"{this.name} Greetes {warrior.Name}!");
        }
    }
}
