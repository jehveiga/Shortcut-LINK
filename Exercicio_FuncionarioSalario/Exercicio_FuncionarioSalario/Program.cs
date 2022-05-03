// See https://aka.ms/new-console-template for more information
using Exercicio_FuncionarioSalario.Entities;
using System.Globalization;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

List<Employee> employees = new List<Employee>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(','); // Separando a string por virgula e colocando no vetor criado
        string name = fields[0];
        string email = fields[1];
        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
        employees.Add(new Employee(name, email, salary));
    }
}

Console.Write("Enter salary: ");
double inputSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine($"Email of people whose salary is more than {inputSalary.ToString("F2", CultureInfo.InvariantCulture)}:");

var orderEmails = employees.Where(e => e.Salary > inputSalary).OrderBy(e => e.Email).Select(e => e.Email);
foreach(var email in orderEmails)
{
    Console.WriteLine(email);
}

var totalSalary = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
Console.WriteLine($"Sum of salary of people whose name starts with 'M': {totalSalary.ToString("F2", CultureInfo.InvariantCulture)}");

