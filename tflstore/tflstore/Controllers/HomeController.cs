using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;
using User;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace tflstore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Registration()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    List<Student> students = new List<Student>();
    public IActionResult InsertData(int rollno, string fullName, string motherName, string fatherName, DateOnly dob,
    string gender, string address, string state, int pincode, string course, string email, string password)
    {
        students.Add(new Student(rollno, fullName, motherName, fatherName, dob, gender, address, state, pincode, course, email, password));
        var options=new JsonSerializerOptions {IncludeFields=true};
        string studJson = JsonSerializer.Serialize<List<Student>>(students,options);
        var fileName = @"G:\dotnet\DOTNET\tflstore\tflstore\studets.json";
        System.IO.File.WriteAllText(fileName, studJson);
        return Redirect("/home/Login");
    }


    public IActionResult Validate(string email, string password)
    {
        var fileName = @"G:\dotnet\DOTNET\tflstore\tflstore\studets.json";
        string studentJson = System.IO.File.ReadAllText(fileName);
        Console.WriteLine("File Read Successfull");
        List<Student> studs = JsonSerializer.Deserialize<List<Student>>(studentJson);
        Console.WriteLine("Deserialize Successfull");
        foreach (Student s in studs)
        {
            Console.WriteLine(s.Email + " " + s.Password);
            if (email == s.Email && password == s.Password)
            {
                return Redirect("/home/Index");
            }
        }
        return Redirect("/home/Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
