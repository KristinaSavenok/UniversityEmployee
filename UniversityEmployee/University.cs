namespace UniversityEmployee
{
	public class University
	{
		public Rector Rector { get; set; }
		public UniversityEmployeeItem[] UniversityEmployeeItems { get; set; }
        public Building[] Buildings { get; set; }
        public Address Address { get; set; }

        public University(Rector rector, UniversityEmployeeItem[] universityEmployeeItems, Building[] buildings, Address address)
        {
            Rector = rector;
            UniversityEmployeeItems = universityEmployeeItems;
            Buildings = buildings;
            Address = address;
        }
    }	
}

