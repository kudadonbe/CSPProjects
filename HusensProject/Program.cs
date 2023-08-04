// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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
If experience is greater than 5 years, the Living Allowance is 10% of the Basic Pay. If experience is less than 5 years, the Living Allowance is 5% of the Basic Pay.
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

int employeeID;
string employeeName;
string jobTitle;
DateTime dateOfJoining;
double basicPay;
char employmentStatus;

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
Console.WriteLine("\nEmployee Details:");
Console.WriteLine("Employee ID: " + employeeID);
Console.WriteLine("Employee Name: " + employeeName);
Console.WriteLine("Job Title: " + jobTitle);
Console.WriteLine("Date of Joining: " + dateOfJoining);
Console.WriteLine("Basic Pay: " + basicPay);
Console.WriteLine("Bonus: " + bonus);