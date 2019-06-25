using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DTO
{
    public class BranchDTO : IEntity
    {
        public short BranchId { get; set; }
        public string BranchName { get; set; }
        public byte FacultyId { get; set; }
    }
}
