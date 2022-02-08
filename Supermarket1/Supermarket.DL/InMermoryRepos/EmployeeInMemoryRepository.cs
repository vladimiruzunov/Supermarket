﻿using Supermarket.DL.InMemoryDb;
using Supermarket.DL.Interfaces;
using Supermarket.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.DL.InMermoryRepos
{
    public class EmployeeInMemoryRepository : IEmployeeRepository
    {
        public EmployeeInMemoryRepository()
        {

        }

        public Employee Create(Employee employee)
        {
            EmployeeInMemoryCollection.EmployeeDB.Add(employee);

            return employee;
        }
        public Employee Delete(int id)
        {
            var employee = EmployeeInMemoryCollection.EmployeeDB.FirstOrDefault(employee => employee.Id == id);
            EmployeeInMemoryCollection.EmployeeDB.Remove(employee);
            return employee;
        }

        public Employee GetById(int id)
        {
            return EmployeeInMemoryCollection.EmployeeDB.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return EmployeeInMemoryCollection.EmployeeDB;
        }
        public Employee Update(Employee employee)
        {
            {

                var result = EmployeeInMemoryCollection.EmployeeDB.FirstOrDefault(x => x.Id == employee.Id);

                result.Name = employee.Name;
                result.Salary = employee.Salary;

                return result;

            }
        }
    }
}
