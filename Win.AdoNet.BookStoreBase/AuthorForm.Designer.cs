
namespace Win.AdoNet.BookStoreBase
{
    partial class AuthorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorGroupBox = new System.Windows.Forms.GroupBox();
            this.txtYearsOfBirth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnSaveAuthor = new System.Windows.Forms.Button();
            this.btnEnditAuthor = new System.Windows.Forms.Button();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.authorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // authorGroupBox
            // 
            this.authorGroupBox.Controls.Add(this.txtYearsOfBirth);
            this.authorGroupBox.Controls.Add(this.label6);
            this.authorGroupBox.Controls.Add(this.txtPatronymic);
            this.authorGroupBox.Controls.Add(this.label8);
            this.authorGroupBox.Controls.Add(this.txtFirstName);
            this.authorGroupBox.Controls.Add(this.btnDeleteAuthor);
            this.authorGroupBox.Controls.Add(this.btnSaveAuthor);
            this.authorGroupBox.Controls.Add(this.btnEnditAuthor);
            this.authorGroupBox.Controls.Add(this.btnNewAuthor);
            this.authorGroupBox.Controls.Add(this.label9);
            this.authorGroupBox.Controls.Add(this.txtLastName);
            this.authorGroupBox.Controls.Add(this.label10);
            this.authorGroupBox.Controls.Add(this.txtAuthor);
            this.authorGroupBox.Controls.Add(this.label11);
            this.authorGroupBox.Location = new System.Drawing.Point(3, 3);
            this.authorGroupBox.Name = "authorGroupBox";
            this.authorGroupBox.Size = new System.Drawing.Size(378, 180);
            this.authorGroupBox.TabIndex = 4;
            this.authorGroupBox.TabStop = false;
            this.authorGroupBox.Text = "Author";
            // 
            // txtYearsOfBirth
            // 
            this.txtYearsOfBirth.Location = new System.Drawing.Point(106, 132);
            this.txtYearsOfBirth.Name = "txtYearsOfBirth";
            this.txtYearsOfBirth.Size = new System.Drawing.Size(185, 20);
            this.txtYearsOfBirth.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Years of Birth";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(106, 106);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(185, 20);
            this.txtPatronymic.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Patronymic";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(106, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Location = new System.Drawing.Point(302, 155);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAuthor.TabIndex = 1;
            this.btnDeleteAuthor.Text = "Delete";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnSaveAuthor
            // 
            this.btnSaveAuthor.Location = new System.Drawing.Point(302, 126);
            this.btnSaveAuthor.Name = "btnSaveAuthor";
            this.btnSaveAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAuthor.TabIndex = 1;
            this.btnSaveAuthor.Text = "Save";
            this.btnSaveAuthor.UseVisualStyleBackColor = true;
            this.btnSaveAuthor.Click += new System.EventHandler(this.btnSaveAuthor_Click);
            // 
            // btnEnditAuthor
            // 
            this.btnEnditAuthor.Location = new System.Drawing.Point(302, 99);
            this.btnEnditAuthor.Name = "btnEnditAuthor";
            this.btnEnditAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnEnditAuthor.TabIndex = 1;
            this.btnEnditAuthor.Text = "Endit";
            this.btnEnditAuthor.UseVisualStyleBackColor = true;
            this.btnEnditAuthor.Click += new System.EventHandler(this.btnEnditAuthor_Click);
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.Location = new System.Drawing.Point(302, 70);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnNewAuthor.TabIndex = 1;
            this.btnNewAuthor.Text = "Nwe";
            this.btnNewAuthor.UseVisualStyleBackColor = true;
            this.btnNewAuthor.Click += new System.EventHandler(this.btnNewAuthor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(106, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Last Name";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(106, 28);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(75, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "AuthorId";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 189);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(385, 170);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 359);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.authorGroupBox);
            this.Name = "AuthorForm";
            this.Text = "Author";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            this.authorGroupBox.ResumeLayout(false);
            this.authorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox authorGroupBox;
        private System.Windows.Forms.TextBox txtYearsOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnSaveAuthor;
        private System.Windows.Forms.Button btnEnditAuthor;
        private System.Windows.Forms.Button btnNewAuthor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}