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
using System.Windows.Forms.VisualStyles;
using FInalLibrarySystem.Database;

namespace FInalLibrarySystem
{
    public partial class Profile : UserControl
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Profile()
        {
            InitializeComponent();
        }

        public int UserId { get; set; } = 1;// Public property for user ID

        private void Profile_Load(object sender, EventArgs e)
        {
            LBLHello.Text = $"Hello, {FirstName} {LastName}!";

        }

        private void PBNonFictional_Click(object sender, EventArgs e)
        {

        }

        private void PBFictional_Click(object sender, EventArgs e)
        {

        }

        private void PBAcademics_Click(object sender, EventArgs e)
        {

        }

        private void LBLHello_Click(object sender, EventArgs e)
        {

        }

        private void LBLAvailable_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBLNonFictional_Click(object sender, EventArgs e)
        {

        }

        private void LBLFictional_Click(object sender, EventArgs e)
        {

        }

        private void LBLAcademic_Click(object sender, EventArgs e)
        {

        }

        private void PBNonFictional_Click_1(object sender, EventArgs e)
        {

        }

        private void PBFictional_Click_1(object sender, EventArgs e)
        {

        }

        private void LBLCategories_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void PBAcademics_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNBorrowed_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBLBorrowed_Click(object sender, EventArgs e)
        {

        }

        private void LBLBorrowed2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBLReserved2_Click(object sender, EventArgs e)
        {

        }

        private void LBLReserved_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBLFictional2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}