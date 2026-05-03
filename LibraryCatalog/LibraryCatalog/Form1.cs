using LibraryCatalog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCatalog
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
            books.Add(new Book());
            RefreshListBox();
            listBooks.SelectedIndexChanged += listBooks_SelectedIndexChanged;
        }

        private void RefreshListBox()
        {
            listBooks.Items.Clear();
            foreach (Book b in books)
                listBooks.Items.Add($"{b.Title} — {b.ISBN}");
        }

        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBooks.SelectedIndex >= 0)
                textDetails.Text = books[listBooks.SelectedIndex].GetDetails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string isbn = textISBN.Text.Trim();
            string title = textTitle.Text.Trim();
            string author = textAuthor.Text.Trim();
            string yearTxt = textYear.Text.Trim();
            string copiesTxt = textCopies.Text.Trim();

            if (isbn == "" || title == "" || author == "")
            {
                MessageBox.Show("ISBN, Title, and Author are required.", "Missing Fields");
                return;
            }

            Book newBook;

            if (yearTxt == "" && copiesTxt == "")
            {
                newBook = new Book(isbn, title, author);
            }
            else
            {
                if (!int.TryParse(yearTxt, out int year))
                {
                    MessageBox.Show("Year must be a valid number.", "Invalid Input");
                    return;
                }
                if (!int.TryParse(copiesTxt, out int copies))
                {
                    MessageBox.Show("Copies must be a valid number.", "Invalid Input");
                    return;
                }
                newBook = new Book(isbn, title, author, year, copies);
            }

            books.Add(newBook);
            RefreshListBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textISBN.Clear();
            textTitle.Clear();
            textAuthor.Clear();
            textYear.Clear();
            textCopies.Clear();
            textISBN.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int idx = listBooks.SelectedIndex;
            if (idx >= 0)
            {
                books.RemoveAt(idx);
                textDetails.Clear();
                RefreshListBox();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int idx = listBooks.SelectedIndex;
            if (idx < 0) return;

            bool success = books[idx].BorrowCopy();
            if (!success)
                MessageBox.Show("No copies available to borrow.", "Out of Copies");

            textDetails.Text = books[idx].GetDetails();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int idx = listBooks.SelectedIndex;
            if (idx < 0) return;

            bool success = books[idx].ReturnCopy();
            if (!success)
                MessageBox.Show("All copies are already returned.", "Max Copies Reached");

            textDetails.Text = books[idx].GetDetails();
        }
    }
}