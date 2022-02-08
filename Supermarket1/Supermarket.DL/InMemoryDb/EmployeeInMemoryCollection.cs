using Supermarket.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.DL.InMemoryDb
{
    public class EmployeeInMemoryCollection
    {
        public static List<Employee> EmployeeDB = new List<Employee>()
        {
            new Employee()
        {
            Id = 1,
            Name = "Ivan",
            Salary = 850
        },
            new Employee(){
            Id = 2,
            Name = "Petko",
            Salary = 1000
        },
            new Employee(){
            Id = 3,
            Name = "Dimityr",
            Salary = 1200
        }
            };

    }
}
