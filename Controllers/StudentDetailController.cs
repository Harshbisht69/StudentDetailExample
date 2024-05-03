using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetail.Model;
using static StudentDetail.Model.StudentDetailModel;

namespace StudentDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDetailController : ControllerBase
    {

        [HttpPost]
        public string SaveStudentDetails(StudentDetailProperties studentDetailPropertyObj)
        {
            StudentDetailModel.StudentDetailOperations studentDetailObj = new StudentDetailModel.StudentDetailOperations();
            studentDetailObj.SaveStudentDetails(studentDetailPropertyObj);
            return "success";
        }
    }
}
