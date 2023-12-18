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


    public partial class MainPage : Form
    {
        
       


        public MainPage()
        {
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

            //set if visibile or not
            profile1.Visible = true;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
            penalty1.Visible = false;

        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = true;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
            penalty1.Visible = false;
        }

        private void btnBorList_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = true;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
            penalty1.Visible = false;

        }

        private void btnBookBor_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = true;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
            penalty1.Visible = false;
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = true;
            bookReservation1.Visible = false;
            penalty1.Visible = false;
        }

        private void bookReserv_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation1.Visible = true;
            penalty1.Visible = false;
        }

        private void btnBookPenalty_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
            penalty1.Visible = true;
        }

        private void bookReturning1_Load(object sender, EventArgs e)
        {

        }

        private void penalty1_Load(object sender, EventArgs e)
        {

        }
    }
}
