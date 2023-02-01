namespace UniversityEmployee
{
	public class Rector : UniversityEmployeeItem
	{
		public Rector(Person person, int taxId) : base(person, taxId)
		{
		}

        public override string GetOfficialDuties()
        {
            return "I am Rector";
        }
    }
}

