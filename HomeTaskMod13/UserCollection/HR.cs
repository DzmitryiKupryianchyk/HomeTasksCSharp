using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    internal class HR
    {
        string firstNameOfNewEmployee;
        string lastNameOfNewEmployee;
        string positionOfNewEmployee;
        private bool correct = false;
        int idOfNewEmployee;
        public Employee HireNewEmployee()
        {
            Console.WriteLine("Введите ID нового сотрудника");
            while (!correct)
            {
                string idOfNew = Console.ReadLine();
                if (int.TryParse(idOfNew, out int id))
                {
                    correct = true;
                    idOfNewEmployee = id;
                }
                else { Console.WriteLine("Ошибка. ID может состоять только из целых чисел. Попробуйте снова."); }
            }

            Console.WriteLine("Введите имя нового сотрудника");
            while (string.IsNullOrEmpty(firstNameOfNewEmployee))
            {
                firstNameOfNewEmployee = Console.ReadLine();
            }
            Console.WriteLine("Введите фамилию нового сотрудника");
            while (string.IsNullOrEmpty(lastNameOfNewEmployee))
            {
                lastNameOfNewEmployee = Console.ReadLine();
            }
            Console.WriteLine("Введите должность нового сотрудника");
            while (string.IsNullOrEmpty(positionOfNewEmployee))
            {
                positionOfNewEmployee = Console.ReadLine();
            }
            Employee newEmployee = new Employee() { IdNumber = idOfNewEmployee, FirstName = firstNameOfNewEmployee, LastName = lastNameOfNewEmployee, Position = positionOfNewEmployee };
            return newEmployee;
        }
        public Employee RemoveByIdNumber(List<Employee> employees) 
        {
            Employee employeeToRemove = new Employee();
            bool correct = false;
            bool finish = false;    
            int idOfRemovedEmployee = 0;
            Console.WriteLine("Введите ID сотрудника");
            while (!correct | !finish)
            {
                string idOfEmp = Console.ReadLine();
                if (int.TryParse(idOfEmp, out int id))
                {
                    correct = true;
                    idOfRemovedEmployee = id;
                }
                else { Console.WriteLine("Ошибка. ID может состоять только из целых чисел. Попробуйте снова."); }
                for (int i = 0; i < employees.Count; i++)
                {

                    if (employees[i].IdNumber == idOfRemovedEmployee)
                    {
                        finish = true;
                        employeeToRemove = employees[i];
                        break;
                    }
                    else if (i == employees.Count - 1 && employees[i].IdNumber != idOfRemovedEmployee)
                    {
                        Console.WriteLine("Нет сотрудника с таким ID");
                    }
                }
            }
            return employeeToRemove;
        }
    }
}
