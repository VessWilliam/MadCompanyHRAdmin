﻿using MadCompanyHR_API;
using MadCompanyHRAdmin;
using static MadCompanyHRAdmin.MadEmployeeType;


Console.WriteLine("Welcome MadTaddy Company!");

var employees = new List<IMadEmployee>();
SeedData(employees);
//decimal totalSalary = 0;


/*foreach (var item in employees)
{
  
    totalSalary += item.Salary; 

}*/

Console.WriteLine($"Total Annual Salary (Include Bonus): {employees.Sum(t => t.Salary)}");


Console.ReadKey();




static void SeedData(List<IMadEmployee?> employees)
{

    var teacher1 = MadEmployeeFactory.GetEmployeeInstance(MadEmployeeType.Teacher, 1, "Kelly", "Jones", 4000);
    var teacher2 = MadEmployeeFactory.GetEmployeeInstance(MadEmployeeType.Teacher, 2, "Celestine", "Edwards", 4000);
    var headOfDepartment = MadEmployeeFactory.GetEmployeeInstance(MadEmployeeType.Teacher, 2, "Henry", "Marks", 8000);
    var ceo = MadEmployeeFactory.GetEmployeeInstance(MadEmployeeType.CEO, 4, "Elbert", "Esteins", 10000);
    var headMaster = MadEmployeeFactory.GetEmployeeInstance(MadEmployeeType.CEO, 5, "Elon", "Musk", 100000);


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

public static class MadEmployeeFactory
{
    public static IMadEmployee GetEmployeeInstance(MadEmployeeType type, int id, string firstname, string lastname, decimal salary)
    {
        IMadEmployee? employee = null;

        switch (type)
        {
            case MadEmployeeType.Teacher:
                employee = FactoryPattern<IMadEmployee, Teacher>.GetInstance();
                break;
            case MadEmployeeType.HOD:
                employee = FactoryPattern<IMadEmployee, HOD>.GetInstance();
                break;
            case MadEmployeeType.CEO:
                employee = FactoryPattern<IMadEmployee, CEO>.GetInstance();
                break;
            case MadEmployeeType.HM:
                employee = FactoryPattern<IMadEmployee, HM>.GetInstance();
                break;
            default:
                break;
        }
        if (employee == null)
        {
            throw new NullReferenceException();
        }
        employee.Id = id;
        employee.FirstName = firstname;
        employee.LastName = lastname;
        employee.Salary = salary;
        return employee;
    }
}