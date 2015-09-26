using System;

namespace HumanStudentWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private float workHoursPerDay;
        private decimal moneyPerHour;

        public Worker(string firstName, string lastName, decimal weekSalary, float workHoursPerDay, decimal moneyPerHour) : base(firstName, lastName)
        {
            this.MoneyPerHour = moneyPerHour;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("WeekSalary","The salary cannot be a negative number!");
                }
                this.weekSalary = value;
            }
        }
        public decimal MoneyPerHour
        {
            get { return this.moneyPerHour; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("MoneyPerHour", "The salary cannot be a negative number!");
                }
                this.moneyPerHour = value;
            }
        }

        public float WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("WorkHours","Work hours cannot be a negative number!");
                }
                this.workHoursPerDay = value;
            }
        }
    }
}
