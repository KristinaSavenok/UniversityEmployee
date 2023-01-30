namespace UniversityEmployee
{
	public class University
	{
		public string Rector;
		public UniversityEmployeeItem[] UniversityEmployeeItems;
		public Building[] Buildings;
		public string Address;

        public University(string rector, UniversityEmployeeItem[] universityEmployeeItems, Building[] buildings, string address)
        {
            Rector = rector;
            UniversityEmployeeItems = universityEmployeeItems;
            Buildings = buildings;
            Address = address;
        }
    }	
}

