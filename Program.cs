using OOP_HRSystem.Core.Entities;


var salariedEmployee = new SalariedEmployee();
salariedEmployee.SetName("Abdullah","Yousry");
salariedEmployee.SetBirthDate(new DateOnly(1998,1,1));
salariedEmployee.BasicSalary = 2000;
salariedEmployee.Transportation = 300;
salariedEmployee.Housing = 1000;
//Console.WriteLine($"Salary of Salaried employee:\t{salariedEmployee.GetSalary():0.00}");
Console.WriteLine("-----------------------------------");
var hourlyEmployee = new HourlyEmployee();
hourlyEmployee.SetName("Abdullah", "Yousry");
hourlyEmployee.SetBirthDate(new DateOnly(1998, 1, 1));
hourlyEmployee.HourRate = 100;
hourlyEmployee.TotalWorkingHours = 60;
//Console.WriteLine($"Salary of Hourly employee:\t{hourlyEmployee.GetSalary():0.00}");
Console.WriteLine("-----------------------------------");
var internEmployee = new InternEmployee();
internEmployee.SetName("Abdullah", "Yousry");
internEmployee.SetBirthDate(new DateOnly(1998, 1, 1));
//Console.WriteLine($"Salary of Hourly employee:\t{internEmployee.GetSalary():0.00}");
Console.WriteLine("-----------------------------------");
Console.ReadLine();

DismissEmployee(hourlyEmployee);

void DismissEmployee(DismissableEmployee employee)
{
    employee.Dismiss();
    Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} has been dismissed.");
}
//var applicant = new Applicant();
//applicant.SetName("Abdullah", "Yousry2");
//applicant.SetBirthDate(new DateOnly(1997, 1, 1));
//PrintPersonDetails(applicant);

//Console.ReadLine();


//void PrintPersonDetails(Person person)
//{
//    Console.WriteLine($"Full Name:\t{person.FirstName} {person.LastName}");
//    Console.WriteLine($"Birth Date:\t{person.BirthDate}");
//}





