namespace UniversityEmployee
{
    public class Room
    {
        private int _number;
        public string RoomType { get; set; }
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value > 0)
                {
                    _number = value;
                }
            }
        }

        public Room(string roomType, int number)
        {
            RoomType = roomType;
            Number = number;
        }

    }
}

