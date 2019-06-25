using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.DTO;
using University.Service;

namespace University.WinUI
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        List<StudentCoursDTO> studentcourses = new List<StudentCoursDTO>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StudentService studentService = new StudentService())
            {
                DialogResult dr = MessageBox.Show("Kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    StudentDTO student = new StudentDTO
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        TcNumber = txtTCNumber.Text,
                        MobilePhone = txtMobilePhone.Text,
                        EmailAddress = txtEmailAdress.Text,
                        CreatedBy = 1
                    };

                    var result = studentService.Add(student);

                    student.StudentCoursList = studentcourses;

                    if (result != null)
                    {
                        MessageBox.Show("Kayıt başarılı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Kayıt sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            using (DefinitionService definitionService = new DefinitionService())
            {
                cmbBranch.DataSource = definitionService.GetBranches();
                cmbBranch.DisplayMember = "BranchName";
                cmbBranch.ValueMember = "BranchId";

            }
            using (DefinitionService definitionService = new DefinitionService())
            {
                cmbCourse.DataSource = definitionService.GetCourses();
                cmbCourse.DisplayMember = "CourseName";
                cmbCourse.ValueMember = "CourseId";

            }
            using (DefinitionService definitionService = new DefinitionService())
            {
                cmbFaculty.DataSource = definitionService.GetFaculties();
                cmbFaculty.DisplayMember = "FacultyName";
                cmbFaculty.ValueMember = "FacultyId";

            }
        }
    }
}
