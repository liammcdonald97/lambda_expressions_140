using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expressions_140
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of 10 employees with first name, last name, and Id properties
            List<Employee> list1 = new List<Employee>();
            list1.Add(new Employee() { firstName = "Joe", lastName = "Meyers", id = 1 });
            list1.Add(new Employee() { firstName = "Joe", lastName = "Montana", id = 2} );
            list1.Add(new Employee() { firstName = "Jim", lastName = "Smith", id = 3 });
            list1.Add(new Employee() { firstName = "Betsy", lastName = "Williams", id = 4 });
            list1.Add(new Employee() { firstName = "Sarah", lastName = "Johnson", id = 5 });
            list1.Add(new Employee() { firstName = "Sidney", lastName = "Crosby", id = 6 });
            list1.Add(new Employee() { firstName = "Antonio", lastName = "Brown", id = 7 });
            list1.Add(new Employee() { firstName = "Lebron", lastName = "James", id = 8 });
            list1.Add(new Employee() { firstName = "Serena", lastName = "Williams", id = 9 });
            list1.Add(new Employee() { firstName = "Jack", lastName = "Johnson", id = 10 });

            //foreach loop that creates a new list of employees with the first name "Joe"
            foreach (Employee employee in list1)
            {
                if(employee.firstName == "Joe")
                {
                    List<Employee> list2 = new List<Employee>();
                    list2.Add(new Employee());
                }
            }
            
            //lambda expression that creates a new list of employees with the first name "Joe"
            List<Employee> list3 = list1.Where(x => x.firstName == "Joe").ToList();

            //lambda expression that creates a new list of all employees with an Id number greater than 5
            List<Employee> list4 = list1.Where(x => x.id > 5).ToList();

            Console.ReadLine();
        }
    }
}
