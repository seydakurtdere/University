using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DTO;
using University.Service;

namespace University.UnitTest
{
    [TestClass]
    public class StudentUT
    {
        private StudentService studentService;

        [TestInitialize]
        public void Setup()
        {
            studentService = new StudentService();
        }

        [TestMethod]
        public void Add()
        {
            StudentDTO student = new StudentDTO
            {
                FirstName = "Seyda",
                LastName = "Kurtdere",
                TcNumber = "11111111111",
                MobilePhone = "05348754962",
                EmailAddress = "s.kurtdere@gmail.com",
                BranchId = 1,               
                RecordStatusId = 1,
                CreatedDate = DateTime.Now,
                CreatedBy = 1,
                BranchName = "aaaa"
                
                
            };
            student.StudentCoursList = new System.Collections.Generic.List<StudentCoursDTO>();
            StudentCoursDTO studentCours1 = new StudentCoursDTO { CourseId = 1 };
            StudentCoursDTO studentCours2 = new StudentCoursDTO { CourseId = 2 };

            student.StudentCoursList.Add(studentCours1);
            student.StudentCoursList.Add(studentCours2);

            var result = studentService.Add(student);
            Assert.IsNotNull(result);
        }

    }



}
