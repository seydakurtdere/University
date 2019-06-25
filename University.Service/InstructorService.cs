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
    public class InstructorService : BaseService, IService<InstructorDTO>
    {
        public InstructorDTO Add(InstructorDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var enties = Mapper.Map<InstructorDTO, Instructor>(obj);

                    enties.InstructorCourses = new List<InstructorCours>();

                    foreach (var item in obj.InstructorCoursList)
                    {
                        var instructorCoursEntity = Mapper.Map<InstructorCoursDTO, InstructorCours>(item);

                        enties.InstructorCourses.Add(instructorCoursEntity);
                    }

                    var instructorDTO = uow.Instructors.Add(enties);

                    uow.Commit();

                    return Mapper.Map<Instructor, InstructorDTO>(instructorDTO);

                }
                catch (Exception)
                {
                    uow.RollBack();
                    return null;
                }

            }

        }

        public InstructorDTO Get(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = uow.Instructors.Get(id);
                    var instructor = Mapper.Map<Instructor, InstructorDTO>(entity);
                    instructor.RecordStatusName = entity.RecordStatus.RecordStatusName;
                   
                    instructor.InstructorCoursList = new List<InstructorCoursDTO>();
                    foreach (var item in entity.InstructorCourses.ToList())
                    {
                        var cours = Mapper.Map<InstructorCours, InstructorCoursDTO>(item);
                        instructor.InstructorCoursList.Add(cours);
                    }
                    return instructor;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<InstructorDTO> List()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entities = uow.Instructors.List();

                    List<InstructorDTO> list = new List<InstructorDTO>();

                    foreach (var item in entities)
                    {
                        InstructorDTO instructorDTO = new InstructorDTO
                        {
                            InstructorId = item.InstructorId,
                            FirstName = item.FirstName,
                            LastName = item.LastName,                           
                            MobilePhone = item.MobilePhone,
                            EmailAddress = item.EmailAddress,                           
                            RecordStatusName = item.RecordStatus.RecordStatusName,
                        };
                        list.Add(instructorDTO);
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

        }

        public bool Update(InstructorDTO obj)
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

                    var entity = Mapper.Map<InstructorDTO, Instructor>(obj);

                    uow.Instructors.Update(entity);
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
