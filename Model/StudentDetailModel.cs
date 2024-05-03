using StudentDetailBL.Shared;

namespace StudentDetail.Model
{
    public class StudentDetailModel
    {
        public class StudentDetailOperations
        {
            public string SaveStudentDetails(StudentDetailProperties studentDetailPropertyObj)
            {
                StudentDetailBL.Contracts.Request.StudentDetailRequest studentRequestObj = new StudentDetailBL.Contracts.Request.StudentDetailRequest();

                studentRequestObj.address = studentDetailPropertyObj.address;
                studentRequestObj.studentName = studentDetailPropertyObj.studentName;
                studentRequestObj.rollNumber = studentDetailPropertyObj.rollNumber;

                studentRequestObj.BehaviourAction = "insert_student_details";
                studentRequestObj.BehaviourClass = "StudentDetailBL.Behaviour.StudentDetailBehaviour";

                //StudentDetailBL.Behaviour.StudentDetailBehaviour studentBehObj = new StudentDetailBL.Behaviour.StudentDetailBehaviour();
                //studentBehObj.SaveStudentDetails(studentRequestObj);

                ServiceLocator serviceLocatorOb = new ServiceLocator();
                serviceLocatorOb.Execute(studentRequestObj);

                return "success";
            }
        }

        public class StudentDetailProperties
        {
            public string studentName { get; set; }
            public string address { get; set; }
            public string rollNumber { get; set; }
        }
        
    }

    

}
