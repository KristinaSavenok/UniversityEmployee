namespace UniversityEmployee
{
	public class Building
	{
		public Room[] Rooms { get; set; }
        public string Address { get; set; }

        public Building(Room[] rooms, string address)
        {
            Rooms = rooms;
            Address = address;
        }
    }

}
 
