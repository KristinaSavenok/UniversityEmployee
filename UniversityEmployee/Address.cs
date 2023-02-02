namespace UniversityEmployee
{
	public class Address
	{
		public string Street { get; set; }
		public int Number { get; set; }

		public Address(string street, int number)
		{
			Street = street;
			Number = number;
		}
	}
}

