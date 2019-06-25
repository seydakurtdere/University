using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DTO
{
    public class FacultyDTO : IEntity
    {
        public byte FacultyId { get; set; }
        public string FacultyName { get; set; }
    }
}
