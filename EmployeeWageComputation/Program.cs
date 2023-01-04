namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0,3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present and Working FullTime");
                empHrs = 8;
            }
            else if (empCheck == 0)
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            else
            {
                Console.WriteLine("Employee is Working PartTime");
                empHrs = 4;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage : "+empWage);
        }
    }
}