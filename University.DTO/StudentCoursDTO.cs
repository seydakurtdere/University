using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DTO
{
    public class StudentCoursDTO
    {
        public int StudentCourseId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public string StudentName { get; set; }
        public string CourseName { get; set; }
    }
}
