namespace characters
{
        public class Character
        {
            private int healthPoint;
            private int weight;
            private int age;


            public int HealthPoint
            {
                get
                {
                    return this.healthPoint;
                }
                set
                {
                    this.healthPoint = value;
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
                    this.age = value;
                }
            }
        }
}
