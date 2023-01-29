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
            // ComputeEmployeeWageforMultipleCompany.computeEmployeeWageforMultipleCompany("DMart", 20, 2, 10);
            // ComputeEmployeeWageforMultipleCompany.computeEmployeeWageforMultipleCompany("Relince", 10, 4, 20);
            /* EmployeeTotalWageEachCompany DMart = new EmployeeTotalWageEachCompany("DMart", 20, 2, 10);
             EmployeeTotalWageEachCompany Reliance = new EmployeeTotalWageEachCompany("Reliance", 30, 2, 20);
             DMart.check();
             Reliance.check(); */
            EMP obj = new EMP();
            obj.addCompanyWage( "dmart", 20, 2, 10);
            obj.addCompanyWage( "reliance", 25, 12, 30);
            obj.addCompanyWage( "nike", 10, 13, 35);
            obj.check();

        }
    }
}