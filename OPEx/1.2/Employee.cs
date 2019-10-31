using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Employee
    {
        private int id;
        private string FirstName;
        private string LastName;
        private int _Salary;
        public Employee(int ID,string firstName,string lastName,int salary)
        {
            id = ID;
            FirstName = firstName;
            LastName = lastName;
            _Salary = salary;
        }
        public int Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                this._Salary = value;
            }
        }
        public int GetID()
        {
            return id;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetName()
        {
            return FirstName + " "+LastName;
        }
        public int GetAnnualSalary()
        {
            return this._Salary * 12;
        }
        public int RaiseSalary(int percent)
        {
            return this._Salary + (this._Salary * (percent / 100));
        }
    }
}
