﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManegement
{
    internal class EmployeeTotalWageEachCompany
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        private string company;
        private int empPerHours;
        private int NoOfWorkingDays;
        private int maxHrsInMonth;
        public int tew;

        public EmployeeTotalWageEachCompany(string company, int empPerHours, int NoOfWorkingDays, int maxHrsInMonth)
        {
            this.company = company;
            this.empPerHours = empPerHours;
            this.NoOfWorkingDays = NoOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
        public void check()
        {

            int totalEmpHr = 0, TotalWorkingDays = 0, empHr = 0;
            while (totalEmpHr <= maxHrsInMonth && TotalWorkingDays <= NoOfWorkingDays)
            {
                TotalWorkingDays++;

                Random obj = new Random();

                int empCheck = obj.Next(0, 3);

                switch (empCheck)
                {

                    case PartTime:

                        empHr = 4;
                        break;

                    case FullTime:

                        empHr = 8;
                        break;

                    default:
                        empHr = 0;

                        break;

                }
                totalEmpHr += empHr;


            }
            int TotalEmpWage = totalEmpHr * empPerHours;

            Console.WriteLine("The total wage of the company" + TotalEmpWage);
        }
    }
}
