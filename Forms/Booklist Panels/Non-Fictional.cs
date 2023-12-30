using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class Non_Fictional : UserControl
    {
        private Books booksManager;

        public Non_Fictional()
        {
            InitializeComponent();
            booksManager = new Books();
        }

        private void Non_Fictional_Load(object sender, EventArgs e)
        {
            LoadNonFictionalData();
        }

        private void LoadNonFictionalData()
        {

            List<Book> nonFictionalBooks = booksManager.GetNonFictionalBooks();

            foreach (var book in nonFictionalBooks)
            {
                // Create an image from the byte[] cover data
                Image coverImage = ByteArrayToImage(book.Cover);

                // Check if the current book is "Sapiens: A Brief History of Humankind"
                if (book.Title == "Sapiens: A Brief History of Humankind")
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

                // add another book
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

        private void UProfileLinkList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Handle link clicked event if needed
        }

        private void bk1lbl5_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }
    }
}
