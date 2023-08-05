// See https://aka.ms/new-console-template for more information

/*
1. Topic: Statements and Operators

    Implement the Employee Bonus Calculator program
    Write a program that takes the following details from the user:
    a. Employee ID
    b. Employee Name
    c. Job Title
    d. Date of Joining (in DD/MM/YYYY format)
    e. Basic Pay
    f. Employment Status (Permanent or Temporary) indicated by 'P' or 'T'

*/

// Declare variables
int employeeID;
string employeeName;
string jobTitle;
DateTime dateOfJoining;
double basicPay;
char employmentStatus;

// Declare variables for calculated values
Console.WriteLine("Enter Employee ID: ");
employeeID = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Employee Name: ");
employeeName = Console.ReadLine();

Console.WriteLine("Enter Job Title: ");
jobTitle = Console.ReadLine();

Console.WriteLine("Enter Date of Joining (in DD/MM/YYYY format): ");
dateOfJoining = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Enter Basic Pay: ");
basicPay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Employment Status (Permanent or Temporary) indicated by 'P' or 'T': ");
employmentStatus = Convert.ToChar(Console.ReadLine());


/*
Calculate the Living Allowance based on the following criteria:
For Permanent employees:
If experience is greater than 5 years, the Living Allowance is 10% of the Basic Pay. If experience is less than 5 years, the Living Allowance is 5% of the Basic Pay.
For Temporary employees:
There is no Living Allowance.
*/




// Calculate the Living Allowance
if (employmentStatus == 'P')
{
    // For permanent employees, bonus is 10% of basic pay
    bonus = 0.1 * basicPay;
}
else if (employmentStatus == 'T')
{
    // For temporary employees, bonus is 5% of basic pay
    bonus = 0.05 * basicPay;
}
else
{
    Console.WriteLine("Invalid employment status entered. Please enter 'P' for Permanent or 'T' for Temporary.");
    return;
}

// Output the employee details and calculated bonus
Console.WriteLine("\nSalary:");
Console.WriteLine("Employee ID: " + employeeID);
Console.WriteLine("Employee Name: " + employeeName);
Console.WriteLine("Job Title: " + jobTitle);
Console.WriteLine("Date of Joining: " + dateOfJoining);
Console.WriteLine("Basic Pay: " + basicPay);
Console.WriteLine("Bonus: " + bonus);