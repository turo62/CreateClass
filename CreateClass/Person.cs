using System;

namespace CreateClass

{
    class Person

    {
        private string Name { get; set; }

        private DateTime birthDay;

        public Gender gender;

        public DateTime BirthDay
        {
            get => birthDay;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Set birthday with past dates!");
                }
                birthDay = value;
            }
        }

        public Gender Gender { get => gender; set => gender = value; }

        public Person(string myName, DateTime birthDay, Gender gender)
        {
            Name = myName;
            BirthDay = birthDay;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format("The person\'s name: {0}, birthday: {1}, gender: {2}", Name, BirthDay, Gender);
        }
    }

    enum Gender
    {
        male,
        female
    };

}
