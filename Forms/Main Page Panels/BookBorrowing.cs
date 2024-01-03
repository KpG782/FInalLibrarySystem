using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class BookBorrowing : UserControl
    {

        private Books booksManager1;

        public BookBorrowing()
        {
            InitializeComponent();
            booksManager1 = new Books();
        }



        private void LoadAllBooks()
        {


            List<Book> fictionalBooks = booksManager1.GetAllBooks();

            foreach (var book in fictionalBooks)
            {

                // Create an image from the byte[] cover data
                Image coverImage = ByteArrayToImage(book.Cover);

                // Check if the current book is "To KIll a Mockingbird"



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



        private void BookBorrowing_Load(object sender, EventArgs e)
        {
            LoadAllBooks();
        }
    }
}
