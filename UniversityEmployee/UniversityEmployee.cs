namespace UniversityEmployee
{
	public class UniversityEmployeeItem
	{
		public Person PersonEmployee { get; set; }
		public int TaxID { get; set; }

		public UniversityEmployeeItem(Person person, int taxID)
		{
			PersonEmployee = person;
			TaxID = taxID;
		}
	}
}

