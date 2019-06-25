using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öğrenciKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudent newStudentForm = new NewStudent();
            newStudentForm.MdiParent = this;
            newStudentForm.WindowState = FormWindowState.Maximized;
            newStudentForm.Show();
        }

        private void öğrenciDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent editStudentForm = new EditStudent();
            editStudentForm.MdiParent = this;
            editStudentForm.WindowState = FormWindowState.Maximized;
            editStudentForm.Show();
        }

        private void eğitmenKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInstructor newInstructorForm = new NewInstructor();
            newInstructorForm.MdiParent = this;
            newInstructorForm.WindowState = FormWindowState.Maximized;
            newInstructorForm.Show();
        }

        private void eğitmenDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditInstructor editInstructorForm = new EditInstructor();
            editInstructorForm.MdiParent = this;
            editInstructorForm.WindowState = FormWindowState.Maximized;
            editInstructorForm.Show();
        }
    }
}
