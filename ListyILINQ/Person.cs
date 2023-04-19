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
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Sex = sex;
            PhoneNumber = phoneNumber;
        }

        public string Introduce()
        {
            string personData = $"First name: {FirstName}, Last name: {LastName}, " +
                $"date of birth: {BirthDate.ToShortDateString()}, sex: {Sex}, " +
                $"phone number: {PhoneNumber}";

            return personData;
        }
    }

    public enum Sex
    {
        Male,
        Female
    }
}
