using System;
using System.IO;
using System.Text.Json;

string jsonFile = @"./company_info.json";

var json = File.ReadAllText(jsonFile);

//Console.WriteLine(json);

var options = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};
Company microsoft = JsonSerializer.Deserialize<Company>(json, options);

Employee emp = microsoft.Employees[1];

//Console.WriteLine("Microsoft has " + microsoft.Employees.Length + " Employees.");
//Console.WriteLine("Employee: " + microsoft.Employees[1].FullName);
//Console.WriteLine($"Employee: {emp.FullName} is paid ${emp.AnnualSalary}.");

//emp.AnnualSalary += 100;

//Console.WriteLine($"Employee: {emp.FullName} is paid ${emp.AnnualSalary}.");

var softwareEngineerLinq = new List<Employee>();
softwareEngineerLinq = microsoft.Employees.Where(emp=> emp.Position.Description == "Software Engineer").ToList();

foreach(var eng in softwareEngineerLinq){
    Console.WriteLine(eng.FullName);
}


var moreOptions = new JsonSerializerOptions{WriteIndented = true};
string jsonString = JsonSerializer.Serialize(microsoft, moreOptions);

File.WriteAllText(jsonFile, jsonString);

Console.WriteLine();
Console.WriteLine("didn't crash");