using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.AdoNet.BookStoreBase
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAuthorTables_Click(object sender, EventArgs e)
        {
            AuthorForm aForm = new AuthorForm();
            aForm.Show();
        }

        private void btnBookTables_Click(object sender, EventArgs e)
        {
            BookForm bForm = new BookForm();
            bForm.Show();
        }
    }
}
