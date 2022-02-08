using Supermarket.Models.DTO;
using Supermarket.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.DL.InMemoryDb
{
    public class ShiftInMemoryCollection
    {
        public static List<Shift> ShiftDB = new List<Shift>()
        {


            new Shift()
        {
            Id =1,
            WorkingDays = WorkingDays.Saturday,
            Employees = new List<Employee>
            {
            new Employee()
        {
                Id = 1,
                Name = "Ivan",
                Salary = 850
        }
            }
            },
            new Shift()
            {
                Id =2,
                WorkingDays = WorkingDays.Monday,
                Employees = new List<Employee>{

            new Employee(){
                Id = 2,
                Name = "Petko",
                Salary = 1000
          }
          }
            },
            new Shift()
            {
                Id =3,
                WorkingDays = WorkingDays.Thursday,
                Employees = new List<Employee>{
                new Employee(){
                Id = 3,
                Name = "Dimityr",
                Salary = 1200
        }

        }
        }
    };
    }
}
