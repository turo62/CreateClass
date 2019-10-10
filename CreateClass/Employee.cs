using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private decimal Salary { get; }

        private string Profession { get; }

        private Room room;

        public Room Room { get => room; set => room = value; }

        public Employee(string name, DateTime birthDay, Gender gender, string profession, decimal salary) : base(name, birthDay, gender)
        {
            Salary = salary;
            Profession = profession;
        }


        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }

        public override string ToString()
        {
            return string.Format("{0} profession: {1} salary: {2} room: {3}", base.ToString(), Profession, Salary, Room.RoomNumber);
        }
    }
}
