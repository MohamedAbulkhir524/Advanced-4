using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_4
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String? ClubName { get; set; }
        List<Employee> Members;

        public Club()
        {
            Members = new List<Employee>();
        }

        public void AddMember(Employee E)
        {
            if (E != null && !Members.Contains(E))
            {
                Members.Add(E);
                E.EmployeeLayOff += this.RemoveMember;


            }






        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee E && Members.Contains(E) && e.Cause == LayOffCause.VacationStock)
            {
                Members.Remove(E);
                Console.WriteLine($"{E} has been removed from Department {this.ClubName}");
                Console.WriteLine($"the reason for laying off is {e.Cause}");
            }


        }
    }
}
