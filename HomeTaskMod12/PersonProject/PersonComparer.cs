using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    internal class PersonComparer : IComparer<Person?>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x is null || y is null)
                throw new ArgumentException("Некорректное значение параметра");
            else if (x.gender == GenderEnum.female && y.gender == GenderEnum.male) 
            {
                return -1;
            }
            else if (x.gender == GenderEnum.male && y.gender == GenderEnum.female)
            {
                return 1;
            }
            return x.age.CompareTo(y.age);
        }
    }
}
