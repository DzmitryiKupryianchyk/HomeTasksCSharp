using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    internal class Person : IComparable<Person>
    {
        public string firstName;
        public string lastName;
        public int age;
        public GenderEnum gender;
        public Person(string firstName, string lastName, int age, GenderEnum gender) 
        { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
        }

        public string GetFirstName() 
        { 
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public GenderEnum GetGender()
        {
            return gender;
        }
        public string GetAge()
        {
            return age.ToString();
        }

        public int CompareTo(Person? person)
        {
            if (person is null) throw new ArgumentException("Некорректное значение параметра");
            else if (gender == GenderEnum.female && person.gender == GenderEnum.male)
            {
                return -1;
            }
            else if (gender == GenderEnum.male && person.gender == GenderEnum.female) 
            {
                return 1;
            }
            return age.CompareTo(person.age);
        }
    }
}
