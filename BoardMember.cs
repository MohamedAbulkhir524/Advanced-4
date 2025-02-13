using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_4
{
    internal class BoardMember : Employee
    {
        public override int VacationStock { get; set; }

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Resigned });
            Console.WriteLine($"{this}has been resigned");



        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.Resigned)
                base.OnEmployeeLayOff(e);
        }



    }
}
