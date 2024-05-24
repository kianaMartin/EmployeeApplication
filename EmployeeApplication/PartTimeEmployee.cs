﻿using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    internal class PartTimeEmployee: IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public  PartTimeEmployee(string FName, string Lname, string dept, String job)
        {
            FirstName = FName;
            LastName = Lname;
            Department = dept;
            JobTitle = job;

        }
        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            BasicSalary = hoursWorked * ratePerHour ;
        }
        public string FirstName
        {
            get
            {
                return this.first_name;
            }
            set
            {
                this.first_name = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.last_name;
            }
            set
            {
                this.last_name = value;
            }
        }
        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return this.job_title;
            }
            set
            {
                this.job_title = value;
            }
        }
        public double BasicSalary
        {
            get
            {
                return this.basic_salary;
            }
            set
            {
                this.basic_salary = value;
            }
        }
        public double getSalary()
        {
            return BasicSalary;
        }
      
    }
}
