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
using static FInalLibrarySystem.Database.BorrowedDetails;

namespace FInalLibrarySystem
{
    public partial class BookReservation : UserControl
    {

        private BorrowedDetails borrowedDetailsManager;
        public BookReservation()
        {

            InitializeComponent();
            borrowedDetailsManager = new BorrowedDetails();
        }



        private void BookReservation_Load(object sender, EventArgs e)
        {
            LoadBorrowedDetailsData();
        }
        private void LoadBorrowedDetailsData()
        {
        try
            {
                List<BorrowedItem> borrowedDetails = borrowedDetailsManager.GetAllBorrowedDetails();

                foreach (var borrowedItem in borrowedDetails)
        {
            MessageBox.Show("Show this if LoadBorrowedDetailsData is working.");

            dgvBorrowedDetailsDat.Rows.Add(
                borrowedItem.ID,
                borrowedItem.UserID,
                borrowedItem.BookID,
                borrowedItem.BorrowedDate,
                borrowedItem.ReturnedDate,
                borrowedItem.ReservedDate,
                borrowedItem.Note
                // Add more columns as needed
            );
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error: {ex.Message}");
    }
        }





        private void dgvBorrowedDetailsDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
