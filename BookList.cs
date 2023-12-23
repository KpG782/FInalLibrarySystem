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
    public partial class BookList : UserControl
    {


        //array for the books



        public BookList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BookList_Load(object sender, EventArgs e)
        {
            fictional1.Visible = false;
            nonFictional1.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fictional1.Visible = false;
            nonFictional1.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fictional1.Visible = false;
            nonFictional1.Visible = true;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void lblFBooks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fictional1.Visible = true;
            nonFictional1.Visible = false;
        }
    }
}
