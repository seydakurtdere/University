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
    public class StudentService : BaseService, IService<StudentDTO>
    {
        public StudentDTO Add(StudentDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var enties = Mapper.Map<StudentDTO, Student>(obj);

                    enties.StudentCourses = new List<StudentCours>();

                    foreach (var item in obj.StudentCoursList)
                    {
                        var studentCoursEntity = Mapper.Map<StudentCoursDTO, StudentCours>(item);

                        enties.StudentCourses.Add(studentCoursEntity);
                    }

                    var studentDTO = uow.Students.Add(enties);

                    uow.Commit();

                    return Mapper.Map<Student, StudentDTO>(studentDTO);

                }
                catch (Exception)
                {
                    uow.RollBack();
                    return null;
                }

            }

        }

        public StudentDTO Get(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = uow.Students.Get(id);
                    var student = Mapper.Map<Student, StudentDTO>(entity);
                    student.RecordStatusName = entity.RecordStatus.RecordStatusName;
                    student.BranchName = entity.Branch.BranchName;
                    student.StudentCoursList = new List<StudentCoursDTO>();
                    foreach (var item in entity.StudentCourses.ToList())
                    {
                        var cours = Mapper.Map<StudentCours, StudentCoursDTO>(item);
                        student.StudentCoursList.Add(cours);
                    }
                    return student;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<StudentDTO> List()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entities = uow.Students.List();

                    List<StudentDTO> list = new List<StudentDTO>();

                    foreach (var item in entities)
                    {
                        StudentDTO studentDTO = new StudentDTO
                        {
                            StudentId = item.StudentId,
                            FirstName = item.FirstName,
                            LastName = item.LastName,
                            TcNumber = item.TcNumber,
                            MobilePhone = item.MobilePhone,
                            EmailAddress = item.EmailAddress,
                            BranchName = item.Branch.BranchName,
                            RecordStatusName = item.RecordStatus.RecordStatusName,
                        };
                        list.Add(studentDTO);
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

        }

        public bool Update(StudentDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    if (obj.RecordStatusId == 1)
                    {
                        obj.ModifiedDate = DateTime.Now;
                    }
                    else
                    {
                        obj.DeletedDate = DateTime.Now;
                    }

                    var entity = Mapper.Map<StudentDTO, Student>(obj);

                    uow.Students.Update(entity);
                    uow.Commit();
                    return true;

                }
                catch (Exception)
                {
                    uow.RollBack();
                    return false;
                }
            }

        }

    }
}
