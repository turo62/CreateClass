using System;

namespace CreateClass
{
    class Person

    {
        protected string name;

        protected DateTime birthDay;

        protected Gender gender;

        public Person(string myName, DateTime myBirthDay, Gender gender)
        {
            this.name = myName;
            this.birthDay = myBirthDay;
            this.gender = gender;
        }

        public Person(string myName, string myBirthDay, Gender gender)
        {
            this.name = myName;
            this.birthDay = DateTime.ParseExact(myBirthDay, "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            this.gender = gender;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return string.Concat("My name is " + name + " I am " + gender + " and I was born at " + birthDay);
        }
    }

    enum Gender
    {
        male,
        female
    };

    public class Room
    {
        int _roomNumber;

        public Room(int myNumber)
        {
            _roomNumber = myNumber;
        }

        public int RoomNumber
        {
            get
            {
                return this._roomNumber;
            }
            set
            {
                this._roomNumber = value;
            }
        }

        public override string ToString()
        {
            return _roomNumber.ToString();
        }

    }

    class Employee : Person
    {
        private int Salary { get; }

        private string Profession { get; }

        public Room room;

        public Employee(string myName, String myBirthDay, Gender gender, int mySalary, string myProfession, Room room) : base(myName, myBirthDay, gender)
        {
            Salary = mySalary;
            Profession = myProfession;
            this.room = room;
        }

        public override string ToString()
        {
            return string.Concat("Employee " + name + " is " + gender + "\n"
                                                        + " was born at " + birthDay + "\n"
                                                        + " having $" + Salary + " salary\n"
                                                        + " works as " + Profession + "\n"
                                                        + " located in Room No. " + room);
        }

        static void Main(string[] args)
        {
            Person kathy = new Person("Kathy", "11/11/1982", Gender.female);
            Employee joe = new Employee("Joe", "07/06/1962", Gender.male, 60000, "Gardener", new Room(1112));

            Console.WriteLine(kathy);
            Console.WriteLine(joe);
            _ = Console.ReadLine();
        }
    }
}
