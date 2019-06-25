using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DATA.Repository;

namespace University.DATA.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private UniversityDBEntities db;
        private DbContextTransaction transaction;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public UnitOfWork()
        {
            db = new UniversityDBEntities();
        }

        public bool Commit()
        {
            transaction = db.Database.BeginTransaction();
            int affected = db.SaveChanges();
            transaction.Commit();
            return affected > 0;
        }

        public void RollBack()
        {
            transaction.Rollback();

        }

        public Repository<Branch> Branches { get { return new Repository<Branch>(db); } }
        public Repository<Cours> Courses { get { return new Repository<Cours>(db); } }
        public Repository<Faculty> Faculties { get { return new Repository<Faculty>(db); } }
        public Repository<Instructor> Instructors { get { return new Repository<Instructor>(db); } }
        public Repository<InstructorCours> InstructorCourses { get { return new Repository<InstructorCours>(db); } }
        public Repository<RecordStatus> RecordStatuses { get { return new Repository<RecordStatus>(db); } }
        public Repository<Student> Students { get { return new Repository<Student>(db); } }
        public Repository<StudentCours> StudentCourses { get { return new Repository<StudentCours>(db); } }
        public Repository<User> Users { get { return new Repository<User>(db); } }



    }
}
