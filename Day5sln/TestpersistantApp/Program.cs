using Catalog;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Product p1 = new Product { Id = 200, Title = "title2", Desc = "desc2", Price = "price2" };
Product p2 = new Product { Id = 300, Title = "title3", Desc = "desc3", Price = "price3" };
Product p3 = new Product { Id = 400, Title = "title4", Desc = "desc4", Price = "price4" };
Product p4 = new Product { Id = 500, Title = "title5", Desc = "desc5", Price = "price5" };


//Adding into DS
// namespace: using System.Collections.Generic;
List<Product> plist = new List<Product>();
plist.Add(p1);
plist.Add(p2);
plist.Add(p3);
plist.Add(p4);


//Serialization
var Jsonobj = new JsonSerializerOptions { IncludeFields = true };
var produtsJson = JsonSerializer.Serialize<List<Product>>(plist, Jsonobj);

string filepath = @"G:\dotnet\DOTNET\Day5sln\TestpersistantApp\productnamegivenbyRushabh.json";
//productnamegivenbyRushabh.json this file is not created after running this json file is created


File.WriteAllText(filepath, produtsJson);//writing file on file path
// output after runn
//[{"Id":200,"Title":"title2","Desc":"desc2","Price":"price2"},{"Id":300,"Title":"title3","Desc":"desc3","Price":"price3"},
//{"Id":400,"Title":"title4","Desc":"desc4","Price":"price4"},{"Id":500,"Title":"title5","Desc":"desc5","Price":"price5"}]



//Deserialization
string stringjson = File.ReadAllText(filepath);
List<Product> productlistafterDeserialise = JsonSerializer.Deserialize<List<Product>>(stringjson);
Console.WriteLine("\n JSON :Deserializing data from json file\n \n");

foreach (Product p in productlistafterDeserialise)
{
    Console.WriteLine(p.Id + " " + p.Title + " " + p.Desc + " " + p.Price + "\n");
}




bool exit = false;
while (!exit)
{
    Console.WriteLine("1.add 2.remove 4.display 3.edit");
    Console.WriteLine("choice");
    string Val = Console.ReadLine();
    switch (Convert.ToInt32(Val))
    {
        case 1:
            Console.WriteLine("hiii");
            string str = Console.ReadLine();
            plist.Add(new Product(Convert.ToInt32(str), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));

            break;
        case 2:
            foreach (Product p in plist)
            {
                Console.WriteLine(p.Id + " " + p.Title);
            }
            Console.WriteLine("Which data to be remove");
            string str3 = Console.ReadLine();
            plist.RemoveAt(Convert.ToInt32(str3));
            break;
        case 3: 
        
        break;
        case 4:
            foreach (Product p in plist)
                Console.WriteLine(p.Id + " " + p.Title);

            break;

    }
}





// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



