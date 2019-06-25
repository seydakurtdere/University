using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University.DTO;
using University.Service;

namespace UniversityUnitTest
{
   
    [TestClass]
    public class InstructorUT
    {
        private InstructorService instructorService;

        [TestInitialize]
        public void Setup()
        {
            instructorService = new InstructorService();
        }
        [TestMethod]
        public void Add()
        {
            InstructorDTO instructor = new InstructorDTO
            {
                FirstName = "Seyda",
                LastName = "Kurtdere",               
                MobilePhone = "05348754962",
                EmailAddress = "s.kurtdere@gmail.com",
                RecordStatusId = 1,
                CreatedDate = DateTime.Now,
                CreatedBy = 1,
        
            };
            instructor.InstructorCoursList = new System.Collections.Generic.List<InstructorCoursDTO>();
            InstructorCoursDTO instructorCours1 = new InstructorCoursDTO { CourseId = 1 };
            InstructorCoursDTO instructorCours2 = new InstructorCoursDTO { CourseId = 2 };

            instructor.InstructorCoursList.Add(instructorCours1);
            instructor.InstructorCoursList.Add(instructorCours2);

            var result = instructorService.Add(instructor);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void List()
        {
            var result = instructorService.List();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Get()
        {
            int id = 1;
            var result = instructorService.Get(id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Update()
        {
            InstructorDTO instructorDTO = new InstructorDTO
            {
                InstructorId = 1,
                FirstName = "Seyda",
                LastName = "Kurtdere",
                MobilePhone = "05348754962",
                EmailAddress = "s.kurtdere@gmail.com",
                RecordStatusId = 1,
                CreatedDate = DateTime.Now,
                CreatedBy = 1,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now
            };

            var result = instructorService.Update(instructorDTO);

            Assert.IsTrue(result);

        }

    }
}
