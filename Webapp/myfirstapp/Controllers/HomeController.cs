using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfirstapp.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace myfirstapp.Controllers;

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
    public IActionResult Validate(string nm,string pass)
    {   
        string filename=@"D:\DotNet\Dotnet try\Day9\Webapp\myfirstapp\person.json";
        string bad=System.IO.File.ReadAllText(filename);
        per=JsonSerializer.Deserialize<List<Person>>(bad);

        Person p=per.Find(obj=>obj.EmailId==nm);

        if(nm==p.EmailId && pass==p.Password)
        {
            return Redirect("/home/index");
        }
        
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
    static List<Person> per=new List<Person>();
     public IActionResult login(string nm,string email,string pass)
    {


        per.Add(new Person(){UserName=nm,EmailId=email,Password=pass});

        var json=JsonSerializer.Serialize(per);
        string filename=@"D:\DotNet\Dotnet try\Day9\Webapp\myfirstapp\person.json";
        System.IO.File.WriteAllText(filename,json);

        per.ForEach(pers=>Console.WriteLine(pers));

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult welcome()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
