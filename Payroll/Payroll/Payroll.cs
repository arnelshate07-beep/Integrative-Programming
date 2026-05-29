using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Payroll
    {
        private string employeeName;
        private double hoursWorked;
        private double hourlyRate;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public Payroll(string name, double hours, double rate)
        {
            employeeName = name;
            hoursWorked = hours;
            hourlyRate = rate;
        }

        public virtual double ComputeSalary()
        {
            return hoursWorked * hourlyRate;
        }
    }

    class FullTime : Payroll
    {
        private double monthlyBonus;

        public double MonthlyBonus
        {
            get { return monthlyBonus; }
        }

        public FullTime(string name, double hours, double rate, double bonus)
            : base(name, hours, rate)
        {
            monthlyBonus = bonus;
        }

        public override double ComputeSalary()
        {
            return base.ComputeSalary() + monthlyBonus;
        }
    }

    class PartTime : Payroll
    {
        private double deduction;

        public double Deduction
        {
            get { return deduction; }
        }

        public PartTime(string name, double hours, double rate, double deduction)
            : base(name, hours, rate)
        {
            this.deduction = deduction;
        }

        public override double ComputeSalary()
        {
            return base.ComputeSalary() - deduction;
        }
    }

    class EmployeeDatabase
    {
        public static List<Payroll> Employees = new List<Payroll>()
        {

            new FullTime("Patrick Herrera", 160, 100, 500),
            new FullTime("Justin Sulit", 160, 120, 800),
            new FullTime("Clark Bautista", 160, 90, 600),

            new PartTime("Rodd Vincent", 80, 80, 200),
            new PartTime("Justine Bantigue", 60, 75, 150),
            new PartTime("Renz Andrada", 40, 70, 100)
        };
    }
}