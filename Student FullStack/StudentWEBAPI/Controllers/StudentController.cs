using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using BOL;
using DAL;
namespace StudentWEBAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    [EnableCors()]

    public IEnumerable<Student> GetAllStudent()
    {
        List<Student> stud=StudentDataAccess.GetAllStudent();
        return stud;
    }

    [Route("{id}")]
    [HttpGet]
    [EnableCors()]
    public ActionResult<Student> GetOneStudent(int id)
    {
        Student stud = StudentDataAccess.GetUserById(id);
        return stud;
    }

    [HttpPost]
    [EnableCors()]
    public IActionResult InsertNewUser(Student stud)
    {
        StudentDataAccess.SaveNewUser(stud);
        return Ok(new { message = "Student Added" });
    }

    [Route("{id}")]
    [HttpDelete]
    [EnableCors()]
    public ActionResult<Student> DeleteOneUser(int id)
    {
        StudentDataAccess.DeleteUserById(id);
        return Ok(new { message = "User deleted" });
    }
}