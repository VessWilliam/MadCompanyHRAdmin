using MadCompanyHR_API;

Console.WriteLine("Welcome MadTaddy Company!");

decimal totalSalary = 0;
var employees = new List<IMadEmployee>();

SeedData(employees);

foreach (var item in employees)
{
  
    totalSalary += item.Salary; 

}

Console.WriteLine($"Total Annual Salary (Include Bonus): {totalSalary}");


Console.ReadKey();




static void SeedData(List<IMadEmployee> employees)
{

    var teacher1 = new Teacher
    {
        Id = 1,
        FirstName = "Kelly",
        LastName = "Jones",
        Salary = 4000
    };
    var teacher2 = new Teacher
    {
        Id = 2,
        FirstName = "Celestine",
        LastName = "Edwards",
        Salary = 4000
    };

    var headOfDepartment = new HOD
    {
        Id = 3,
        FirstName = "Henry",
        LastName = "Marks",
        Salary = 8000
    };
    var ceo = new CEO
    {
        Id = 4,
        FirstName = "Elbert",
        LastName = "Esteins",
        Salary = 10000
    };
    var headMaster = new HM
    {
        Id = 5,
        FirstName = "Elon",
        LastName = "Musk",
        Salary = 100000
    };
    employees.Add(teacher1);
    employees.Add(teacher2);
    employees.Add(headOfDepartment);
    employees.Add(ceo);
    employees.Add(headMaster);
}



public class Teacher : MadEmployeeBase
{

    public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }

}
public class HOD : MadEmployeeBase
{

    public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }

}
public class CEO : MadEmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }


}
public class HM : MadEmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }

}