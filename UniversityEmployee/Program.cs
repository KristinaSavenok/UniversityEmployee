using UniversityEmployee;

Teacher mathTeacher = new Teacher(
    new Person("Ivan", "Popov"), 5, new Course("Math", "2+2=4"));
Teacher englishTeacher = new Teacher(
    new Person("Katsiaryna", "Umnaja"), 99, new Course("English", "london is the capital of great britain"));

DegreeTeacher chemistryTeacher = new DegreeTeacher(
    new Person("Vasil", "Opytnyj"), 77, new Course("Chemistry", "H2O"), "Master", "Professor");
DegreeTeacher lawTeacher = new DegreeTeacher(
    new Person("Yury", "Big"), 3, new Course("Jurisprudence", "court of law"), "Dr", "Assistant Professor");

SupportStaff security = new SupportStaff(
    new Person("Ivan", "Glavnyj"), 100, "Security", "Security");
SupportStaff cleaner = new SupportStaff(
    new Person("Valentina", "Czistaja"), 11, "Cleaner", "Cleaning");
SupportStaff driver = new SupportStaff(
    new Person("Dominic", "Toretto"), 999, "Driver", "Fast Road");

UniversityEmployeeItem[] employeesArray = new UniversityEmployeeItem[]
{
    mathTeacher,
    englishTeacher,
    chemistryTeacher,
    lawTeacher,
    security,
    cleaner,
    driver
};

Console.WriteLine("list of all employees:");
for (int i = 0; i < employeesArray.Length; i++)
{
    Console.WriteLine(employeesArray[i].GetOfficialDuties());
}

Console.WriteLine("list of teachers:");
for (int i = 0; i < employeesArray.Length; i++)
{
    if (employeesArray[i] is Teacher)
    {
        Console.WriteLine(employeesArray[i].GetOfficialDuties());
    }
}

Rector Rector = new Rector(new Person("Nik", "Nok"), 13);
Address Address = new Address("Nowaja", 90);
Room MainBuildingRoom12 = new Room("lecture", 12);
Room MainBuildingRoom34 = new Room("laboratory", 34);
Room MainBuildingRoom222 = new Room("lecture", 222);
Room[] MainBuildingRooms = new Room[]
{
    MainBuildingRoom12,
    MainBuildingRoom34,
    MainBuildingRoom222
};
Building MainBuilding = new Building(MainBuildingRooms, "Minsk, Nowaja st, 1");
Building[] Buildings = new Building[]
{
    MainBuilding
};

University BSU = new University(Rector, employeesArray, Buildings, Address);

Console.WriteLine(BSU.Rector.GetOfficialDuties());