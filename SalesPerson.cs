using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_4
{
    internal class SalesPerson : Employee
    {
        public override int VacationStock { get; set; }

        int achievedTarget;
        public int AchievedTarget
        {
            get => achievedTarget;
            set => achievedTarget = value;
        }
        public bool CheckTarget(int Quota)
        {
            if (Quota >= AchievedTarget)
                return true;
            else
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.TargetFailed });
                return false;
            }




        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause != LayOffCause.VacationStock)
                base.OnEmployeeLayOff(e);
        }




    }
}
