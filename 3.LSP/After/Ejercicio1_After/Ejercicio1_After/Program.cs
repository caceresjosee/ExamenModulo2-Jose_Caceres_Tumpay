using Ejercicio1_After;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("----- Part time  --------");
        IEmployee employee = new PartTime();
        employee.FirstName = "Gonzalo";
        employee.LastName = "Caceres";
        Console.Write($"{employee.FirstName} {employee.LastName} {Environment.NewLine}");


        Console.WriteLine(new string('*', 50));
        Console.WriteLine("----- Fulltime  --------");


        IEmployeeDepartment employee1 = new FullTime();
        employee1.FirstName = "Gabriel";
        employee1.LastName = "Retamozo";
        employee1.AssignDepartment(new Department { Name = "IT" });
        Console.Write($"{employee1.FirstName} {employee1.LastName} /  departamento: {employee1.Department.Name} / tipo de empleo:  {employee1.ContractType}");
      
        Console.ReadLine();

    }
}