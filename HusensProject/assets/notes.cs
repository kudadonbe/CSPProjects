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

Calculate the Living Allowance based on the following criteria:
For Permanent employees:
If experience is greater than 5 years, the Living Allowance is 10% of the Basic Pay.
If experience is less than 5 years, the Living Allowance is 5% of the Basic Pay.
For Temporary employees:
There is no Living Allowance.

Calculate the Bonus based on the following criteria:
For Permanent employees:
If experience is greater than 25 years, the Bonus is 20% of the Basic Pay.
If experience is between 15 and 25 years (inclusive), the Bonus is 15% of the Basic Pay.
If experience is between 5 and 15 years (inclusive), the Bonus is 10% of the Basic Pay.
If experience is less than 5 years, the Bonus is 5% of the Basic Pay.
For Temporary employees, the Bonus is 3% of the Basic Pay.

Calculate the Net Pay:
Net Pay = Basic Pay + Living Allowance + Bonus.
Print a summary of the Salary Slip, including all the calculated values for Employee ID, Employee Name, Job Title, Date of Joining, Basic Pay, Living Allowance, Bonus, and Net Pay.

2. Topic: OOPS- Inheritance
Create a Bus child class that inherits from the Vehicle class. The default fare charge of any vehicle is seating capacity* 100. If Vehicle is Bus instance, we need to add an extra 10% on full fare as a maintenance charge. So total fare for bus instance will become the final amount = total fare + 10% of the total fare.
3. Topic: Class and Methods
Write a class called Student that has a name, a grade, and a GPA. Include methods to calculate the student's letter grade and to determine whether the student is on the honor roll (GPA >= 3.5).
4. Topic: OOPS Design Principles - Inheritance, Polymorphism
Design a class hierarchy for different shapes such as Circle and Triangle. Include appropriate properties and methods in each class. Write code to create objects of these classes and perform calculations like calculating area and perimeter for each shape.
*/


/*



int employeeID = 1;
string employeeName = "Husen";
string jobTitle = "Software Engineer";
DateTime dateOfJoining = new DateTime(2020, 1, 1);
double basicPay = 100000.00;
char employmentStatus = 'P';

string employeeDetails = $@" 
    Employee ID: {employeeID}
    Employee Name: {employeeName}
    Job Title: {jobTitle}
    Date of Joining: {dateOfJoining}
    Basic Pay: {basicPay}
";


Console.WriteLine(employeeDetails);


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
If experience is greater than 5 years, the Living Allowance is 10% of the Basic Pay. 
If experience is less than 5 years, the Living Allowance is 5% of the Basic Pay.
For Temporary employees:
There is no Living Allowance.
*/


double livingAllowance = 0;

DateTime experience = DateTime.Now - dateOfJoining;

if (employmentStatus == 'P')
{
    if (experience.TotalDays > 5 * 365)
    {
        livingAllowance = 0.1 * basicPay;
    }
    else
    {
        livingAllowance = 0.05 * basicPay;
    }
}


/*
    Calculate the Bonus based on the following criteria:
    For Permanent employees:
    If experience is greater than 25 years, the Bonus is 20% of the Basic Pay.
    If experience is between 15 and 25 years (inclusive), the Bonus is 15% of the Basic Pay.
    If experience is between 5 and 15 years (inclusive), the Bonus is 10% of the Basic Pay.
    If experience is less than 5 years, the Bonus is 5% of the Basic Pay.
    For Temporary employees, the Bonus is 3% of the Basic Pay.
*/

double bonus = 0;
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

/*
    Calculate the Net Pay:
    Net Pay = Basic Pay + Living Allowance + Bonus.
    Print a summary of the Salary Slip, including all the calculated values for Employee ID, Employee Name, Job Title, Date of Joining, Basic Pay, Living Allowance, Bonus, and Net Pay.
*/

double netPay = basicPay + livingAllowance + bonus;

string paySlip = $@"
    Employee ID: {employeeID}
    Employee Name: {employeeName}
    Job Title: {jobTitle}
    Date of Joining: {dateOfJoining}
    Basic Pay: {basicPay}
    Living Allowance: {livingAllowance}
    Bonus: {bonus}
    Net Pay: {netPay}
";

Console.WriteLine(paySlip);


// */

