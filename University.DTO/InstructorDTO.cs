using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DTO
{
    public class InstructorDTO : IEntity
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public byte RecordStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }

        public string RecordStatusName { get; set; }

        public string DisplayString { get { return "Ad Soyad: " + FirstName + " " + LastName; } }

        public List<InstructorCoursDTO> InstructorCoursList { get; set; }
    }
}
