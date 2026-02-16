using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay06
{
    internal struct Employee
    {
        #region Problem03
        private int empId;
        private string name;
        private double salary;
        public Employee(int _EmpId, string _name, double _salary)
        {
            empId = _EmpId;
            name = _name;
            salary = _salary;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        #endregion

        #region Problem06
        public void modifyemployee(int _empId , string _name, double _salary)
        {
            empId = _empId;
            name = _name;
            salary = _salary;
        }
        #endregion
    }
}
