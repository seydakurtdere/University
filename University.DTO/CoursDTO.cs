using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DTO
{
    public class CoursDTO : IEntity
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public short BranchId { get; set; }
    }
}
