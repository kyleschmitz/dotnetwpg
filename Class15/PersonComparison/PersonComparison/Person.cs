namespace Person
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public bool Equals(Person person)
        {
            return (FirstName == person.FirstName && LastName == person.LastName);
        }
    }
}