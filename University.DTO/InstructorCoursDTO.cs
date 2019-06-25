using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DTO
{
    public class InstructorCoursDTO : IEntity
    {
        public int InstructorCourseId { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
    }
}
