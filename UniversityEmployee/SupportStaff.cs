namespace UniversityEmployee
{
    internal class SupportStaff : UniversityEmployeeItem
    {
        public string StaffName { get; set; }
        public string Duties { get; set; }
       

        public SupportStaff(Person person, int taxID, string staffName, string duties) : base(person, taxID)
        {
            StaffName = staffName;
            Duties = duties;
        }

        public override string GetOfficialDuties()
        {
            return $"Employee {PersonEmployee.FirstName} {PersonEmployee.LastName} works as {StaffName} and has {Duties}";
        }
    }
}

