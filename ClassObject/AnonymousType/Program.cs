using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

class Program
{
    static void Main(string[ ]args)
    {
        var stock = new { Name = "Cichgan Enterpises", Code = 1301, Price = 30000.00 };
        Console.WriteLine("Stock Name: "+ stock.Name);
        Console.WriteLine("Stock Code: " + stock.Code);
        Console.WriteLine("Stock Price: " + stock.Price);
    }
    public static void Main1(string[] args)
    {
        Employee david = new Employee();
        david.DisplayDetails{ new {FirstName = "David",LastName = "Blake", Age = 30}};
    }
}
class Employee
{
    public void DisplayDetails (object emp)
    {
        String fName = "";
        String lName = "";
        int age = 0;
        PropertyInfo[] attrs = emp.GetType().GetProperties();
        foreach(PropertyInfo attr in attrs)
        {
            switch (attr.Name)
            {
                case "FirstName":
                    fName = attr.GetValue(emp, null).ToString();
                    break;
                case "LastName":
                    lName = attr.GetValue(emp, null).ToString();
                    break;
                case "Age":
                    age = (int)attr.GetValue(emp, null);
                    break;
            }
        }
        Console.WriteLine("Name: {0} {1}, Age: {2}",fName,lName,age);
    }
}