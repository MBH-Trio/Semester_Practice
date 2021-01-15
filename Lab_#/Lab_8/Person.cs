namespace Lab_8
{
    internal class Person
    {
        public string name;
        public string last_name;
        public string city;
        public string state;
        public string country;

        public Person(string name, string last_name, string city, string state, string country)
        {
            this.name = name;
            this.last_name = last_name;
            this.city = city;
            this.state = state;
            this.country = country;
        }
        public override string ToString()
        {
            return name;
        }
    }
}