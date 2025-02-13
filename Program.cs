namespace Advanced_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee()
            {
                Name = "Mohamed",
                EmployeeID = 10,
                BirthDate = new DateTime(1999, 11, 28),
                VacationStock = 10
            };

            Employee Emp2 = new Employee()
            {
                Name = "Ali",
                EmployeeID = 20,
                BirthDate = new DateTime(1999, 11, 28),
                VacationStock = 1
            };

            SalesPerson Sp = new SalesPerson()
            {
                Name = "Ahemd",
                EmployeeID = 30,
                BirthDate = new DateTime(1997, 11, 28),
                VacationStock = 20,
                AchievedTarget = 5000
            };
            BoardMember BEmp = new BoardMember()
            {
                Name = "saad",
                EmployeeID = 40,
                BirthDate = new DateTime(1997, 11, 29),
                VacationStock = 20,
            };

            Department Dept01 = new Department()
            {
                DeptID = 2020,
                DeptName = "SD"
            };

            Club C1 = new Club()
            {
                ClubID = 22,
                ClubName = "Al ahly"
            };

            Dept01.AddStaff(Emp);
            C1.AddMember(Emp);
            Dept01.AddStaff(Emp2);
            C1.AddMember(Emp2);
            Dept01.AddStaff(Sp);
            C1.AddMember(Sp);
            Dept01.AddStaff(BEmp);
            C1.AddMember(BEmp);

            Emp2.BirthDate = new DateTime(1900, 11, 1);
            Console.WriteLine("----------------------------");
            Emp.VacationStock -= 16;
            Console.WriteLine("----------------------------");
            Sp.CheckTarget(100);
            Console.WriteLine("----------------------------");

            BEmp.BirthDate = new DateTime(1900, 11, 1);
            BEmp.Resign();
            Console.WriteLine("----------------------------");



        }
    }
}
