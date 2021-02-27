using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.AdoNet.BookStoreBase
{
    public partial class BookForm : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapBook;
        private DataSet dataSetBook;
        private DataGridViewCell clickedCell;

        public BookForm()
        {
            InitializeComponent();
        }

        private bool IsNullValid()
        {
            if (txtName.Text != "" || txtAuthorId.Text != "" || txtPublicationYear.Text != "" || txtPublisherId.Text != "" || txtPrice.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Заполните все доступные поля");
                return false;
            }
        }

        //SqlCommand
        private void СomExecSql(string comandString, string connectString)
        {
            using (sqlConnection = new SqlConnection(connectString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = sqlConnection;
                    command.CommandText = comandString;
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        //SELECT
        private void SelectBase()
        {
            string connectString = "Data Source=.;Initial Catalog = BookStore_Test; Integrated Security = True";

            using (sqlConnection = new SqlConnection(connectString))
            {
                sqlConnection.Open();
                string comandString = "SELECT [BookId], [Name], [AuthorId], [PublicationYear], [PublisherId], [Price] FROM [dbo].[Book]";

                using (sqlDataAdapBook = new SqlDataAdapter(comandString, sqlConnection))
                {
                    using (dataSetBook = new DataSet())
                    {
                        sqlDataAdapBook.Fill(dataSetBook, "Book");

                        dataGridView.DataSource = dataSetBook.Tables["Book"];
                    }
                }
            }
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            SelectBase();
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo hit = dataGridView.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    clickedCell = dataGridView.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
                }
            }
        }

        //INSERT
        private void btnNewBook_Click(object sender, EventArgs e)
        {
            if (IsNullValid())
            {
                try
                {
                    string Name = txtName.Text;
                    string AuthorId = txtAuthorId.Text;
                    string PublicationYear = txtPublicationYear.Text;
                    string PublisherId = txtPublisherId.Text;
                    string Price = txtPrice.Text;

                    string connectString = "Data Source=.;Initial Catalog = BookStore_Test; Integrated Security = True";
                    string comandString = string.Format("INSERT INTO [dbo].[Book] ([Name] ,[AuthorId] ,[PublicationYear] ,[PublisherId] ,[Price]) " +
                            "VALUES ('{0}','{1}','{2}','{3}','{4}')", Name, AuthorId, PublicationYear, PublisherId, Price);

                    СomExecSql(comandString, connectString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtName.Clear();
                    txtAuthorId.Clear();
                    txtPublicationYear.Clear();
                    txtPublisherId.Clear();
                    txtPrice.Clear();
                    SelectBase();
                }
            }
        }

        //EDIT
        private void btnEnditBook_Click(object sender, EventArgs e)
        {
            if (clickedCell != null)
            {
                try
                {
                    int ind = clickedCell.RowIndex;

                    txtBookId.Text = Convert.ToString(dataGridView.Rows[ind].Cells["BookId"].Value);
                    txtName.Text = Convert.ToString(dataGridView.Rows[ind].Cells["Name"].Value);
                    txtAuthorId.Text = Convert.ToString(dataGridView.Rows[ind].Cells["AuthorId"].Value);
                    txtPublicationYear.Text = Convert.ToString(dataGridView.Rows[ind].Cells["PublicationYear"].Value);
                    txtPublisherId.Text = Convert.ToString(dataGridView.Rows[ind].Cells["PublisherId"].Value);
                    txtPrice.Text = Convert.ToString(dataGridView.Rows[ind].Cells["Price"].Value);                   
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    SelectBase();
                }
            }
            else
            {
                MessageBox.Show("Выберите строчку для редакторования");
            }
        }

        //UPDATE
        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (clickedCell != null && IsNullValid())
            {
                try
                {
                    int ind = clickedCell.RowIndex;
                    string bookId = Convert.ToString(dataGridView.Rows[ind].Cells["BookId"].Value);

                    string Name = txtName.Text;
                    string AuthorId = txtAuthorId.Text;
                    string PublicationYear = txtPublicationYear.Text;
                    string PublisherId = txtPublisherId.Text;
                    string Price = txtPrice.Text;

                    string connectString = "Data Source=.;Initial Catalog = BookStore_Test; Integrated Security = True";
                    string comandString = string.Format("UPDATE[dbo].[Book] SET [Name] = '{1}',[AuthorId] = '{2}',[PublicationYear] = '{3}',[PublisherId] = '{4}',[Price] = '{5}' " +
                        "WHERE [BookId] = '{0}'", bookId, Name, AuthorId, PublicationYear, PublisherId, Price);

                    СomExecSql(comandString, connectString);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    SelectBase();
                }
            }
        }

        //DELETE
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (clickedCell != null)
            {
                try
                {
                    int ind = clickedCell.RowIndex;
                    string bookId = Convert.ToString(dataGridView.Rows[ind].Cells["BookId"].Value);

                    string connectString = "Data Source=.;Initial Catalog = BookStore_Test; Integrated Security = True";
                    string comandString = string.Format("DELETE FROM [dbo].[Book] WHERE [BookId] = '{0}'", bookId);

                    СomExecSql(comandString, connectString);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    SelectBase();
                }
            }
            else
            {
                MessageBox.Show("Выберите строчку для удаления");
            }
        }
    }
}
