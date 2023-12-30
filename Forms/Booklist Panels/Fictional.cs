using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class Fictional : UserControl
    {
        private Books booksManager1;

        public Fictional()
        {
            InitializeComponent();
            booksManager1 = new Books();
        }

        private void Fictional_Load(object sender, EventArgs e)
        {
            LoadFictionalData();
        }

        private void LoadFictionalData()
        {
            // Assuming you have a DataGridView named Fictional in your form
            dgvFictional.Rows.Clear();

            List<Book> fictionalBooks = booksManager1.GetFictionalBooks();

            foreach (var book in fictionalBooks)
            {

                // Create an image from the byte[] cover data
                Image coverImage = ByteArrayToImage(book.Cover);

                // Check if the current book is "To KIll a Mockingbird"
                if (book.Title == "To Kill a Mockingbird")
                {
                    // Set the cover image for "To Kill a Mockingbird" in the PictureBox
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

                dgvFictional.Rows.Add(
                    book.Id,
                    book.Title,
                    book.ISBN,
                    book.Author,
                    book.Category,
                    book.Copyright,
                    book.Publisher,
                    book.Status,
                    book.Description,
                    coverImage
                // Add more columns as needed
                );
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
    }
}
