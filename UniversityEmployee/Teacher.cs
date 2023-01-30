namespace UniversityEmployee
{
	internal class Teacher : UniversityEmployeeItem
    {
		public Course Course { get; set; }

		public Teacher(Person person, int taxId, Course course) : base(person, taxId)
		{
			Course = course;
		}

        public override string GetOfficialDuties()
        {
            return $"Teacher {PersonEmployee.FirstName} {PersonEmployee.LastName} has {Course.Name} {Course.Description} course";
        }
    }

}

