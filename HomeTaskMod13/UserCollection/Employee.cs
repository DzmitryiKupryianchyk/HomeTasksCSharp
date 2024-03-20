using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    public class Employee : IComparable<Employee>
    {
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public int CompareTo(Employee other)
        {
            if (other == null) 
            { 
                return 1;
            }
            return IdNumber.CompareTo(other.IdNumber);
        }
    }
}
