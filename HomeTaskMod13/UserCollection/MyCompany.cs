using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    public delegate void NewEmployeeAdded(Employee newEmployee);
    public delegate void RemovedEmployee(Employee newEmployee);

    internal class MyCompany
    {
        public event NewEmployeeAdded Welcome;
        public event RemovedEmployee EmployeeHasBeenRemoved;
        List<Employee> myCompany = new List<Employee>();
        public CEO chief { get; set; }
        public MyCompany(List<Employee> myEmployees)
        {
            myCompany = myEmployees;
        }

        public List<Employee> GetList() 
        {
            return myCompany;
        }
        public void Add(Employee obj)
        {
            myCompany.Add(obj);
            myCompany.Sort();
            Welcome(obj);
            foreach (var item in myCompany)
            {
                Console.WriteLine($"ID - {item.IdNumber}.  {item.FirstName} {item.LastName}. Должность - {item.Position}");
            }
        }

        public void ShowEmployees()
        {
            myCompany.Sort();
            foreach (var item in myCompany)
            {
                Console.WriteLine($"ID - {item.IdNumber}.  {item.FirstName} {item.LastName}. Должность - {item.Position}");
            }
        }
        public void RemoveEmployee(Employee employee)
        {
            for (int i = 0; i < myCompany.Count; i++)
            {

                if (myCompany[i] == employee)
                {
                    Console.WriteLine();
                    myCompany.Remove(myCompany[i]);
                }
            }
            foreach (var item in myCompany) 
            {
                Console.WriteLine($"ID - {item.IdNumber}.  {item.FirstName} {item.LastName}. Должность - {item.Position}");
            }
            EmployeeHasBeenRemoved(employee);
        }
    }
}
