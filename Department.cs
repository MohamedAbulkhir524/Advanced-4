using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_4
{
    public class Department
    {
        public int DeptID { get; set; }
        public string? DeptName { get; set; }

        List<Employee> Staff;

        public Department()
        {
            Staff = new List<Employee>();

        }

        public void AddStaff(Employee E)
        {
            if (E != null && !Staff.Contains(E))
            {
                Staff.Add(E);
                E.EmployeeLayOff += this.RemoveStaff;


            }




        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee E && Staff.Contains(E))
            {
                Staff.Remove(E);
                Console.WriteLine($"{E} has been removed from Department {this.DeptName}");
                Console.WriteLine($"the reason for laying off is {e.Cause}");
            }


        }
    }
}
