using System;
using System.IO;
using System.Text.Json;
using BCrypt.Net;

/*
    Create a class which models the fruit from 
    the Json file. 

    Once that is done, read all of the objects 
    from the Json into a fruit list.
*/

string jsonFile = @"./fruits.json";

var json = File.ReadAllText(jsonFile);

var options = new JsonSerializerOptions();
List<Fruit> fruitList = JsonSerializer.Deserialize< List<Fruit> >(json, options);

HashSet<string> fruitColors = new HashSet<string>();
foreach (Fruit fruit in fruitList)
{
    fruitColors.Add(fruit.Color);
}

foreach (string Color in fruitColors){
    Console.WriteLine(Color);
    foreach (Fruit frui in fruitList)
    {
        if(Color == frui.Color){
            Console.WriteLine($@"    {frui.Name}");
        }
    }
}

// foreach (Fruit fruit in fruitList)
// {
//     Console.WriteLine($"{fruit.Name}: {fruit.Color}");
// }

//===================================
string plainText = "hello";

string passwordHash = BCrypt.Net.BCrypt.HashPassword(plainText);

Console.WriteLine(plainText);
Console.WriteLine(passwordHash);

//=====================================


