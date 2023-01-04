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
            int totalEmpWage = 0;
            int days = 1;
            int totalHrs = 0;
            while (days <= 20 && totalHrs < 100)
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
                totalHrs += empHrs;
                Console.WriteLine("Day : "+days+" Emp hrs : "+empHrs);
                days++;                
            }
            totalEmpWage = totalHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage : "+totalEmpWage);
            
        }
    }
}