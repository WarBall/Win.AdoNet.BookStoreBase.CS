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
    public partial class AuthorForm : Form
    {

        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapAuthor;
        private DataSet dataSetAuthor;
        private DataGridViewCell clickedCell;

        public AuthorForm()
        {
            InitializeComponent();
        }

        private bool IsNullValid()
        {
            if (txtLastName.Text != "" || txtFirstName.Text != "" || txtPatronymic.Text != "" || txtYearsOfBirth.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Заполните все доступные поля");
                return false;
            }
        }

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

        private void SelectBase()
        {
            string connectString = "Data Source=.;Initial Catalog = BookStore_Test; Integrated Security = True";

            using (sqlConnection = new SqlConnection(connectString))
            {
                sqlConnection.Open();
                string comandString = "SELECT [AuthorId], [LastName], [FirstName], [Patronymic], [YearsOfBirth] FROM [dbo].[Author]";

                using (sqlDataAdapAuthor = new SqlDataAdapter(comandString, sqlConnection))
                {
                    using (dataSetAuthor = new DataSet())
                    {
                        sqlDataAdapAuthor.Fill(dataSetAuthor, "Author");

                        dataGridView.DataSource = dataSetAuthor.Tables["Author"];
                    }
                }
            }
        }

        private void AuthorForm_Load(object sender, EventArgs e)
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

        private void btnNewAuthor_Click(object sender, EventArgs e)
        {
            if (IsNullValid())
            {
                try
                {
                    string LastName = txtLastName.Text;
                    string FirstName = txtFirstName.Text;
                    string Patronymic = txtPatronymic.Text;
                    string YearsOfBirth = txtYearsOfBirth.Text;

                    string connectString = "Data Source=.;Initial Catalog = BookStore_Test; Integrated Security = True";
                    string comandString = string.Format("INSERT INTO [dbo].[Author] ([LastName],[FirstName],[Patronymic],[YearsOfBirth]) VALUES ('{0}','{1}','{2}','{3}')", LastName, FirstName, Patronymic, YearsOfBirth);

                    СomExecSql(comandString, connectString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtLastName.Clear();
                    txtFirstName.Clear();
                    txtPatronymic.Clear();
                    txtYearsOfBirth.Clear();
                    SelectBase();
                }
            }
        }

        private void btnEnditAuthor_Click(object sender, EventArgs e)
        {
            if (clickedCell != null)
            {
                try
                {
                    int ind = clickedCell.RowIndex;

                    txtAuthor.Text = Convert.ToString(dataGridView.Rows[ind].Cells["AuthorId"].Value);
                    txtLastName.Text = Convert.ToString(dataGridView.Rows[ind].Cells["LastName"].Value);
                    txtFirstName.Text = Convert.ToString(dataGridView.Rows[ind].Cells["FirstName"].Value);
                    txtPatronymic.Text = Convert.ToString(dataGridView.Rows[ind].Cells["Patronymic"].Value);
                    txtYearsOfBirth.Text = Convert.ToString(dataGridView.Rows[ind].Cells["YearsOfBirth"].Value);
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

        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {
            if (clickedCell != null && IsNullValid())
            {
                try
                {
                    int ind = clickedCell.RowIndex;
                    string authorId = Convert.ToString(dataGridView.Rows[ind].Cells["AuthorId"].Value);

                    string LastName = txtLastName.Text;
                    string FirstName = txtFirstName.Text;
                    string Patronymic = txtPatronymic.Text;
                    string YearsOfBirth = txtYearsOfBirth.Text;

                    string connectString = "Data Source=.;Initial Catalog = BookStore_Test; Integrated Security = True";
                    string comandString = string.Format("UPDATE[dbo].[Author] SET [LastName] = '{1}',[FirstName] = '{2}',[Patronymic] = '{3}',[YearsOfBirth] = '{4}' " +
                        "WHERE [AuthorId] = '{0}'", authorId, LastName, FirstName, Patronymic, YearsOfBirth);

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

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (clickedCell != null)
            {
                try
                {
                    int ind = clickedCell.RowIndex;
                    string authorId = Convert.ToString(dataGridView.Rows[ind].Cells["AuthorId"].Value);

                    string connectString = "Data Source=.;Initial Catalog = BookStore_Test; Integrated Security = True";
                    string comandString = string.Format("DELETE FROM [dbo].[Author] WHERE [AuthorId] = '{0}'", authorId);

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
