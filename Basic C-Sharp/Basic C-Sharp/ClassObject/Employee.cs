using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cahpter7_ClassObject
{
    class Employee
    {
        private int Experience;
        private double Salary;

        public int getExp()
        {
            return Experience;
        }

        public void setExp(int val)
        {
            Experience = val;
        }

        public double EmSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }
    }
}
