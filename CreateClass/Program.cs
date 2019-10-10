using System;

namespace CreateClass

{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, Gender.male, "léhűtő", 1000); ;
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
