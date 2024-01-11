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
    }
}