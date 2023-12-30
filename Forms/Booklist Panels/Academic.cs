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
    public partial class Academic : UserControl
    {
        private Books booksManager;

        public Academic()
        {
            booksManager = new Books();
            InitializeComponent();
        }


        private void Academic_Load(object sender, EventArgs e)
        {
            LoadAcademicData();
        }

        private void LoadAcademicData()
        {


            List<Book> academicBooks = booksManager.GetAcademicBooks();

            foreach (var book in academicBooks)
            {

                // Create an image from the byte[] cover data
                Image coverImage = ByteArrayToImage(book.Cover);

                // Check if the current book is "Introduction to Algorithms"
                if (book.Title == "Introduction to Algorithms")
                {
                    // Set the cover image for "Introduction to Algorithms" in the PictureBox
                    bk1pb1.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk1lbl1.Text = book.Title;
                    bk1lbl2.Text = book.ISBN;
                    bk1lbl3.Text = book.Category;
                    bk1lbl4.Text = book.Author;
                    bk1lbl5.Text = book.Copyright.ToString();
                    bk1lbl6.Text = book.Publisher;
                    bk1lbl7.Text = book.Status;
                    bk1lbl8.Text = book.Description;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }

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

        private void bk1pb1_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl1_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl2_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl3_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl4_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl5_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl6_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl7_Click(object sender, EventArgs e)
        {

        }

        private void bklbl8_Click(object sender, EventArgs e)
        {

        }

        private void grpBook1_Enter(object sender, EventArgs e)
        {

        }
    }
}
