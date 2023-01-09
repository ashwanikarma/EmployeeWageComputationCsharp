namespace EmployeeWageComputation
{
    internal class Program
    {

        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public Program(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays= numOfWorkingDays;
            this.maxHoursPerMonth= maxHoursPerMonth;   
        }
        public  void computeEmpWage()
        {
            int empHrs = 0, empTotalWorkingDays=1;           
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
            this.totalEmpWage = totalHrs * this.empRatePerHour;
            Console.WriteLine("Total Hours worked : " + totalHrs );
          //  Console.WriteLine("Total Employee Wage for company : " +company + " is : "+totalEmpWage);
          
        }

        public void toString()
        {
            Console.WriteLine("Total Employee Wage for company : " + this.company + " is : " + this.totalEmpWage);
        }
        static void Main(string[] args)
        {
            Program dMart = new Program("Dmart", 20, 10, 80);
            Program bigBazaar = new Program("Bigbazaar", 15, 15, 100);
            dMart.computeEmpWage();
            dMart.toString();
            bigBazaar.computeEmpWage();
            bigBazaar.toString();
        }
    }
}