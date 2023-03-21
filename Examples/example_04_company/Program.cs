using System;
using System.IO;
using System.Text.Json;

string jsonFile = @"./company_info.json";

 var json = File.ReadAllText(jsonFile);

//Console.WriteLine(json);

var options = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};
Company microsoft = JsonSerializer.Deserialize<Company>(json, options);

// Employee emp = microsoft.Employees[1];

//Console.WriteLine("Microsoft has " + microsoft.Employees.Length + " Employees.");
//Console.WriteLine("Employee: " + microsoft.Employees[1].FullName);
//Console.WriteLine($"Employee: {emp.FullName} is paid ${emp.AnnualSalary}.");

//emp.AnnualSalary += 100;

//Console.WriteLine($"Employee: {emp.FullName} is paid ${emp.AnnualSalary}.");

// var softwareEngineerLinq = new List<Employee>();
// softwareEngineerLinq = microsoft.Employees.Where(emp=> emp.Position.Description == "Software Engineer").ToList();

// foreach(var eng in softwareEngineerLinq){
//     Console.WriteLine(eng.FullName);
// }


// var moreOptions = new JsonSerializerOptions{WriteIndented = true};
// string jsonString = JsonSerializer.Serialize(microsoft, moreOptions);

// File.WriteAllText(jsonFile, jsonString);

// Console.WriteLine(); 


/**************************
Directory Example Begin
***************************/


// string dirPathB = "./photo";
// string fileName = "tester.txt";

//Console.WriteLine($"Before we are currently at: {Directory.GetCurrentDirectory}");

// if(Directory.Exists(dirPathB)){
//     Console.WriteLine("Exists!");
// }else{
//     Console.WriteLine("Doesn't Exist!");
//     Directory.CreateDirectory(dirPathB);
//     Console.WriteLine("... But Now It Does!");
// }

//Directory.SetCurrentDirectory(dirPathB);

// string content = $@"The names: 
//                     - {dirPathB}
//                     - {fileName}
//                     are some ridiculous names";

//File.WriteAllText(fileName, content);

string business = "./my_employees";

if(!Directory.Exists(business)){
    Directory.CreateDirectory(business);
}
Directory.SetCurrentDirectory(business);

Employee emp = microsoft.Employees[0];


string empFile = $"{emp.Id}.txt";

string empContent = $@"Employee Id: {emp.Id}
Employee Name: {emp.FullName}
Employee Annual Salary: {emp.AnnualSalary}
Employee Position: {emp.Position.Id}
Employee Position Description: {emp.Position.Description}
Benefits: 
";
foreach(Benefit benefit in emp.Benefits){
empContent += $@"   ID: {benefit.Id}
    Description: {benefit.Description}
    Additional Amount: {benefit.Additional}
    ---------------------------
";
}


 File.WriteAllText(empFile, empContent);



/**************************
Directory Example End
***************************/
Console.WriteLine("didn't crash");