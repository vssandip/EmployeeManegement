using EmpolyeeManegement;

namespace EmployeeManegement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### WELCOME TO EMPLOYEE MANEGEMENT #####");
            //EmpolyeeAttendance.attendance();
            //  EmployeeWage.empAttandance();
            // PartTimeEmpWage.partTimeWage();
            // EmployeeWageSwitchCase.employeeWageSwitchCase();
            // CalculatingWageForMonth.calculatingWageForMonth();
            //ageWorkingDaysAndWorkingHour.wageWorkingDaysAndWorkingHour();
            // ComputeEmployeeWageUsingClassMethods.computeEmployeeWageUsingClassMethods();
            ComputeEmployeeWageforMultipleCompany.computeEmployeeWageforMultipleCompany("DMart", 20, 2, 10);
            ComputeEmployeeWageforMultipleCompany.computeEmployeeWageforMultipleCompany("Relince", 10, 4, 20);

        }
    }
}