namespace DataModel
{
    public class Person
    {
        private string name;

        private int age;

        public Person(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    this.name = value ?? string.Empty;
                }
            }
        }

        public Gender Gender { get; set; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value != age)
                {
                    age = value < 0 ? 0 : value;
                }
            }
        }
    }
}