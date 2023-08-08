namespace CSProjects;

class Program
{
    static void Main(string[] args)
    {
        string? employeeID;
        DateTime dateOfJoining;
        string? employeeName;
        string? jobTitle;
        string? dateOfJoiningNullable;
        string dateOfJoiningString;
        string[] dateOfJoiningArray;
        string dateOfJoiningStringReversed;
        string? salary;
        double basicPay;
        string? empStatusStr;
        char employmentStatus;
        int experienceInYears;
        TimeSpan experience;
        

        try
        {

            Console.WriteLine("Emplyee ID: ");
            employeeID = Console.ReadLine();

            Console.WriteLine("Enter Your Name: ");
            employeeName = Console.ReadLine();

            Console.WriteLine("Enter Job Title: ");
            jobTitle = Console.ReadLine();

            Console.WriteLine("Enter Date of Joining (in DD/MM/YYYY format): ");
            dateOfJoiningNullable = Console.ReadLine();
            dateOfJoiningString = dateOfJoiningNullable ?? "01/01/2021";
            // split the date string into day, month and year




            dateOfJoiningArray = dateOfJoiningString.Split('/');
            // reverse the array to get the year, month and day
            Array.Reverse(dateOfJoiningArray);
            // join the array elements into a string
            dateOfJoiningStringReversed = string.Join('/', dateOfJoiningArray);
            // convert the string into a DateTime object
            dateOfJoining = Convert.ToDateTime(dateOfJoiningStringReversed);
            Console.WriteLine("Your basic Pay: ");
            salary = Console.ReadLine();
            basicPay = Convert.ToDouble(salary);
            Console.WriteLine("Employment Status (Permanent or Temporary) indicated by 'P' or 'T'");
            empStatusStr = Console.ReadLine();
            empStatusStr ??= "X";;
            employmentStatus = char.ToUpper(empStatusStr[0]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        experience = DateTime.Now - dateOfJoining;
        experienceInYears = (int)(experience.TotalDays / 365);





        double livingAllowance = CalculateLivingAllowance(employmentStatus, experienceInYears, basicPay);
        double bounusAmount = CalculateBounus(employmentStatus, experienceInYears, basicPay);
        // make totalEarnings variable

        double totalEarnings = basicPay + livingAllowance + bounusAmount;
        double netSalary = totalEarnings; // deduct if any

        string employeeDetails = @$"
------------------- Salary Slip -------------------
Employee ID:     {employeeID}
Employee Name:   {employeeName}
Job Title:       {jobTitle}
Date of Joining: {dateOfJoining:dd/MM/yyyy}
Eperiance:       {experienceInYears} yrs
--------------------------------------------------
            
Earnings:           
Basic Salary:    {basicPay,14:C2}
Living Allowance:{livingAllowance,14:C2}
Bonus:           {bounusAmount,14:C2}
Total Earnings:  {totalEarnings,14:C2}
            
--------------------------------------------------
Net Salary:       {netSalary,14:C2}
--------------------------------------------------
";




        Console.WriteLine(employeeDetails);


    }

    static double CalculateLivingAllowance(char employmentStatus, int experienceInYears, double basicPay)
    {
        double livingAllowance;


        if (employmentStatus == 'P')
        {
            if (experienceInYears >= 5 * 385) // 5 years in days (365 days/year * 5 years)
            {
                livingAllowance = basicPay * 0.1; // 10% of basic pay
            }
            else
            {
                livingAllowance = basicPay * 0.05; // 5% of basic pay
            }
        }
        else
        {
            livingAllowance = 0;
        }
        // 4995.00 (5yrs)

        return livingAllowance;
    }


    // Calculate the Bonus based on the following criteria:
    // For Permanent employees:
    // If experience is greater than 25 years, the Bonus is 20% of the Basic Pay.
    // If experience is between 15 and 25 years (inclusive), the Bonus is 15% of the Basic Pay.
    // If experience is between 5 and 15 years (inclusive), the Bonus is 10% of the Basic Pay.
    // If experience is less than 5 years, the Bonus is 5% of the Basic Pay.
    // For Temporary employees, the Bonus is 3% of the Basic Pay.

    // lest make a function to calculate bounus

    static double CalculateBounus(char employmentStatus, int experienceInYears, double basicPay)
    {
        double bonus;
        


        if (employmentStatus == 'P')
        {
            if (experienceInYears > 25)
            {
                bonus = 0.2 * basicPay;
            }
            else if (experienceInYears > 15)
            {
                bonus = 0.15 * basicPay;
            }
            else if (experienceInYears > 5)
            {
                bonus = 0.1 * basicPay;
            }
            else
            {
                bonus = 0.05 * basicPay;
            }
        }
        else
        {
            bonus = 0.03 * basicPay;
        }

        return bonus;
    }


}

