using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class frmPrompt : Form
    {
        public frmPrompt()
        {
            InitializeComponent();
        }

        private void frmPrompt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacher f4 = new frmTeacher();
            f4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent f3 = new frmStudent();
            f3.Show();
        }
    }
}
