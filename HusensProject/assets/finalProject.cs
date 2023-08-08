namespace CSProjects;

class Program
{
    static void Main(string[] args)
    {

        int employeeID = 1;
        DateTime dateOfJoining;

        Console.WriteLine("Enter Your Name: ");
        string? employeeName = Console.ReadLine();

        Console.WriteLine("Enter Job Title: ");
        string? jobTitle = Console.ReadLine();

        Console.WriteLine("Enter Date of Joining (in DD/MM/YYYY format): ");
        string? dateOfJoiningNullable = Console.ReadLine();
        string dateOfJoiningString = dateOfJoiningNullable ?? "01/01/2021";
        // split the date string into day, month and year



        try
        {
            string[] dateOfJoiningArray = dateOfJoiningString.Split('/');
            // reverse the array to get the year, month and day
            Array.Reverse(dateOfJoiningArray);
            // join the array elements into a string
            string dateOfJoiningStringReversed = string.Join('/', dateOfJoiningArray);
            // convert the string into a DateTime object
            dateOfJoining = Convert.ToDateTime(dateOfJoiningStringReversed);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        double basicPay = 100000.01;
        char employmentStatus = 'P';


        string livingAllowance = CalculateLivingAllowance(employmentStatus, dateOfJoining, basicPay);
        string bounusAmount = CalculateBounus(employmentStatus, dateOfJoining, basicPay);

        string employeeDetails = @$" 
            Employee ID: {employeeID}
            Employee Name: {employeeName}
            Job Title: {jobTitle}
            Date of Joining: {dateOfJoining}
            Basic Pay: {basicPay}
            Living Allowance: {livingAllowance}
            Bounus: {bounusAmount}
            Total Pay: {basicPay + livingAllowance + bounusAmount}
              ";  



        Console.WriteLine(employeeDetails);


    }

    static string CalculateLivingAllowance(char employmentStatus, DateTime dateOfJoining, double basicPay)
    {
        double livingAllowance;
        int experienceInYears = 0;
        TimeSpan experience = DateTime.Now - dateOfJoining;
        experienceInYears = (int)(experience.TotalDays / 365);
        string LivingAllowanceString = "";


        if (employmentStatus == 'P')
        {
            if (experience.TotalDays >= 5 * 385) // 5 years in days (365 days/year * 5 years)
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
        LivingAllowanceString = @$"{livingAllowance} ({experienceInYears}yrs))";

        return LivingAllowanceString;
    }


    // Calculate the Bonus based on the following criteria:
    // For Permanent employees:
    // If experience is greater than 25 years, the Bonus is 20% of the Basic Pay.
    // If experience is between 15 and 25 years (inclusive), the Bonus is 15% of the Basic Pay.
    // If experience is between 5 and 15 years (inclusive), the Bonus is 10% of the Basic Pay.
    // If experience is less than 5 years, the Bonus is 5% of the Basic Pay.
    // For Temporary employees, the Bonus is 3% of the Basic Pay.

    // lest make a function to calculate bounus

    static string CalculateBounus(char employmentStatus, DateTime dateOfJoining, double basicPay)
    {
        double bonus = 0;
        int experienceInYears = 0;
        TimeSpan experience = DateTime.Now - dateOfJoining;
        experienceInYears = (int)(experience.TotalDays / 365);
        string bounusString = "";


        if (employmentStatus == 'P')
        {
            if (experience.TotalDays > 25 * 365)
            {
                bonus = 0.2 * basicPay;
            }
            else if (experience.TotalDays > 15 * 365)
            {
                bonus = 0.15 * basicPay;
            }
            else if (experience.TotalDays > 5 * 365)
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

        bounusString = @$"{bonus} ({experienceInYears}yrs))";
        return bounusString;
    }

}



