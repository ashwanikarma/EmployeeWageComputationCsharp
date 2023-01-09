namespace EmployeeWageComputation
{
    internal class Program
    {

        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public static void computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, empTotalWorkingDays=1;
            int totalEmpWage = 0;  
            int totalHrs = 0;
            while (totalHrs <= maxHoursPerMonth && empTotalWorkingDays <= numOfWorkingDays)
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
                Console.WriteLine("Day : "+empTotalWorkingDays+" Emp hrs : "+empHrs);
                empTotalWorkingDays++;                
            }
            totalEmpWage = totalHrs * empRatePerHour;
            Console.WriteLine("Total Hours worked : " + totalHrs );
            Console.WriteLine("Total Employee Wage for company : " +company + " is : "+totalEmpWage);
          
        }
        static void Main(string[] args)
        {
            computeEmpWage("Dmart", 20, 10, 80);
            computeEmpWage("Bigbazaar", 15, 15, 100);
        }
    }
}