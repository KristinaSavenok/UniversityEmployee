namespace UniversityEmployee
{
	public class UniversityEmployeeItem
	{
		public Person PersonEmployee { get; set; }
		public int TaxId { get; set; }

		public UniversityEmployeeItem(Person person, int taxId)
		{
			PersonEmployee = person;
			TaxId = taxId;
		}

        public virtual string GetOfficialDuties()
        {
			return "University Employee Title";
        }
    }
}

