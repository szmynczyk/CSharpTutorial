using System;

namespace ListyILINQ
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public int PhoneNumber { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, DateTime birthDate, Sex sex, int phoneNumber)
        {
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
        }

        public void Introduce(bool showBirthDate = false, bool showPhoneNumber = false)
        {
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Last name: {LastName}");
            if(showBirthDate)
            {
                Console.WriteLine($"Birth date: {BirthDate.ToShortDateString()}");
            }
            Console.WriteLine($"Sex: {Sex}");
            if (showPhoneNumber)
            {
                Console.WriteLine($"First name: {PhoneNumber}");
            }
        }
    }

    public enum Sex
    {
        Male,
        Female
    }
}
