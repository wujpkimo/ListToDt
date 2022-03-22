// See https://aka.ms/new-console-template for more information

using System.Data;

var data = new List<Employee>() {
    new Employee(){Id=1,Name="YY",Tel="123"},
    new Employee(){Id=2,Name="KK",Tel="55556123"},
    new Employee(){Id=3,Name="LL",Tel="77777123"}
};

var dt = new DataTable();

dt.Columns.Add("Id");
dt.Columns.Add("Name");
dt.Columns.Add("Tel");

foreach (var item in data)
{
    dt.Rows.Add(new object[] { item.Id, item.Name, item.Tel });
}

foreach (DataRow dataRow in dt.Rows)
{
    Console.WriteLine($"{dataRow["Id"]},{dataRow["Name"]},{dataRow["Tel"]}");
    Console.WriteLine($"{dataRow[nameof(Employee.Id)]},{dataRow[nameof(Employee.Name)]},{dataRow[nameof(Employee.Tel)]}");
}
//Console.WriteLine("123");

internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Tel { get; set; }
}