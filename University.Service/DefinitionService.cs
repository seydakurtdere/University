using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DATA;
using University.DATA.UnitOfWork;
using University.DTO;

namespace University.Service
{
    public class DefinitionService : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<BranchDTO> GetBranches()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var branches = uow.Branches.List();
                List<BranchDTO> list = new List<BranchDTO>();
                foreach (var item in branches)
                {
                    list.Add(Mapper.Map<Branch, BranchDTO>(item));
                }
                return list;
            }
        }

        public List<CoursDTO> GetCourses()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var courses = uow.Courses.List();
                List<CoursDTO> list = new List<CoursDTO>();
                foreach (var item in courses)
                {
                    list.Add(Mapper.Map<Cours, CoursDTO>(item));
                }
                return list;
            }
        }

        public List<FacultyDTO> GetFaculties()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var faculties = uow.Faculties.List();
                List<FacultyDTO> list = new List<FacultyDTO>();
                foreach (var item in faculties)
                {
                    list.Add(Mapper.Map<Faculty, FacultyDTO>(item));
                }
                return list;
            }
        }

        public List<RecordStatusDTO> GetRecordStatus()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var recordstatuses = uow.RecordStatuses.List();
                List<RecordStatusDTO> list = new List<RecordStatusDTO>();
                foreach (var item in recordstatuses)
                {
                    list.Add(Mapper.Map<RecordStatus, RecordStatusDTO>(item));
                }
                return list;
            }
        }
    }
}
