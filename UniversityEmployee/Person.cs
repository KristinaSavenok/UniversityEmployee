namespace UniversityEmployee
{
	public class Person
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
       public Person(string firstName, string lastName)

        {
            FirstName = firstName;
            LastName = "Pan " + lastName;
        }
        public Person()
        {
            FirstName = "NoName";
            LastName = "NoName";
        }
        public string GetInfo()
        {
            return FirstName + LastName;
        }
    }
}

