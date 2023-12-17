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
        //set global object

        BookBorrowing bookBorrowing = new BookBorrowing();
        BookList bookList = new BookList();
        BookReservation bookReservation = new BookReservation();
        BookReturning bookReturning = new BookReturning();
        BorrowerList borrowerList = new BorrowerList();
        Profile profile = new Profile();
        Penalty penalty = new Penalty();


        public MainPage()
        {
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

            //set if visibile or not
            
            bookBorrowing.Visible = false;
            bookList.Visible = false;
            bookReservation.Visible = false;
            profile.Visible = false;
            penalty.Visible = false;
            bookReturning.Visible = false;
            borrowerList.Visible = false;

        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            
            bookBorrowing.Visible = false;
            bookList.Visible = false;
            bookReservation.Visible = false;
            profile.Visible = true;
            penalty.Visible = false;
            bookReturning.Visible = false;
            borrowerList.Visible = false;
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            //set if visibile or not
           
            bookBorrowing.Visible = false;
            bookList.Visible = true;
            bookReservation.Visible = false;
            profile.Visible = false;
            penalty.Visible = false;
            bookReturning.Visible = false;
            borrowerList.Visible = false;
        }

        private void btnBorList_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            
            bookBorrowing.Visible = false;
            bookList.Visible = false;
            bookReservation.Visible = false;
            profile.Visible = false;
            penalty.Visible = false;
            bookReturning.Visible = false;
            borrowerList.Visible = true;
        }

        private void btnBookBor_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            
            bookBorrowing.Visible = true;
            bookList.Visible = false;
            bookReservation.Visible = false;
            profile.Visible = false;
            penalty.Visible = false;
            bookReturning.Visible = false;
            borrowerList.Visible = false;
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            
            bookBorrowing.Visible = false;
            bookList.Visible = false;
            bookReservation.Visible = false;
            profile.Visible = false;
            penalty.Visible = false;
            bookReturning.Visible = true;
            borrowerList.Visible = true;
        }

        private void bookReserv_Click(object sender, EventArgs e)
        {
            //set if visibile or not
            
            bookBorrowing.Visible = false;
            bookList.Visible = false;
            bookReservation.Visible = true;
            profile.Visible = false;
            penalty.Visible = false;
            bookReturning.Visible = false;
            borrowerList.Visible = false;
        }

        private void btnBookPenalty_Click(object sender, EventArgs e)
        {
            //set if visibile or not
           
            bookBorrowing.Visible = false;
            bookList.Visible = false;
            bookReservation.Visible = false;
            profile.Visible = false;
            penalty.Visible = true;
            bookReturning.Visible = false;
            borrowerList.Visible = false;
        }

        private void bookReturning1_Load(object sender, EventArgs e)
        {

        }
    }
}
