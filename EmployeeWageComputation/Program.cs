namespace EmployeeWageComputation
{
    internal class Program
    {

        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int EMP_TOTAL_WORKING_DAY = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < EMP_TOTAL_WORKING_DAY; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is Working FullTime");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Working PartTIme");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage+= empWage;
            }
            Console.WriteLine("Total Employee Wage : "+totalEmpWage);
        }
    }
}