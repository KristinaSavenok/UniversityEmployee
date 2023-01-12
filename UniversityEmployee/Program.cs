using UniversityEmployee;
Person person1 = new Person("Ivan","Popov");
person1.GetInfo();

Person person2 = new Person();
person2.GetInfo();

UniversityEmployeeItem employee1 = new UniversityEmployeeItem(person1, 10);
employee1.TaxID = 10;

