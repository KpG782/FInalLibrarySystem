using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class BorrowerList : UserControl
    {
        private Users usersManager;

        public BorrowerList()
        {
            InitializeComponent();
            usersManager = new Users();
        }

        private void BorrowerList_Load(object sender, EventArgs e)
        {
            LoadStudentData();

            dgvStudents.Visible = true;
            teacher1.Visible = false;

        }

        //data of the students
        private void LoadStudentData()
        {
            dgvStudents.Rows.Clear();

            List<Users.User> students = usersManager.GetAllStudents();

            foreach (var student in students)
            {
                // Create an image from the byte[] picture data
                Image studentImage = ByteArrayToImage(student.Picture);

                dgvStudents.Rows.Add(
                    student.Id,
                    student.Username,
                    student.FirstName,
                    student.LastName,
                    student.MiddleInitial,
                    student.Email,
                    student.StudentID,
                    student.Section,
                    student.Year

                // Add more columns as neededa
                ); ;
            }
        }

        // Helper method to convert byte array to Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BorrowerList b1 = new BorrowerList();
            b1.Visible = false;
            teacher1.Visible = true;
        }


        

        private void teacher1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvStudents.Visible = true;
            teacher1.Visible = false;
        }

        private void dgvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teacher2_Load(object sender, EventArgs e)
        {

        }

        private void lnkTeacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvStudents.Visible = false;
            teacher1.Visible = true;
        }
    }
}
