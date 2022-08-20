using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                //----------------------------------------------------------------------1
                List<Employee> Employees = new List<Employee>()
                {
                    new Employee
                    {
                        Id = 1,
                        FirstName="William",
                        LastName="Kelly",
                    },

                    new Employee
                    {
                        Id = 2,
                        FirstName="John",
                        LastName="Moore",
                    },

                    new Employee
                    {
                        Id = 3,
                        FirstName="Daniel",
                        LastName="Walsh",
                    },

                    new Employee
                    {
                        Id = 4,
                        FirstName="Oliver",
                        LastName="Lynch",
                    },

                    new Employee
                    {
                        Id = 5,
                        FirstName="Joe",
                        LastName="Kelly",
                    },

                    new Employee
                    {
                        Id = 6,
                        FirstName="Matthew",
                        LastName="Kelly",
                    },

                    new Employee
                    {
                        Id = 7,
                        FirstName="Joe",
                        LastName="Healy",
                    },

                    new Employee
                    {
                        Id = 8,
                        FirstName="Joe",
                        LastName="Bell",
                    },

                    new Employee
                    {
                        Id = 9,
                        FirstName="Isabella",
                        LastName="O'Connor",
                    },

                    new Employee
                    {
                        Id = 10,
                        FirstName="Dylan",
                        LastName="Johnson",
                    },

                };

                //-------------------------------------------------------------------------2
                // using foreach loop
                int counter = 0;
                foreach (Employee employee in Employees)
                {
                    if (employee.FirstName == "Joe")
                    {
                        counter++;
                    }
                }
                Console.WriteLine("There is {0} employees called Joe!, -> Foreach used!", counter);

                //-------------------------------------------------------------------------3
                //using lambda function
                int count = Employees.Count(x => x.FirstName == "Joe");
                Console.WriteLine("There is {0} employees called Joe!, -> Lambda (Count) function used!", count);

                //just a different example of using lambda function...

                int count1 = (Employees.FindAll(x => x.FirstName == "Joe")).Count();

                Console.WriteLine("There is {0} employees called Joe!, -> Lambda (FindAll) function used! \n", count1);


                //-------------------------------------------------------------------------4


                List<Employee> EmployeesID = new List<Employee>();
                EmployeesID = Employees.FindAll(y => (y.Id > 5));

                Console.WriteLine("Employees with Id greater than 5 :");

                foreach (Employee employee1 in EmployeesID)
                {
                    Console.WriteLine("{0} {1} {2}", employee1.Id, employee1.FirstName, employee1.LastName);
                }

                Console.ReadKey();

            }



        }
        class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
