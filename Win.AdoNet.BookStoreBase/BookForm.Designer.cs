
namespace Win.AdoNet.BookStoreBase
{
    partial class BookForm
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
            this.bookGroupBox = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPublisherId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.btnEnditBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookGroupBox
            // 
            this.bookGroupBox.Controls.Add(this.txtPrice);
            this.bookGroupBox.Controls.Add(this.txtPublisherId);
            this.bookGroupBox.Controls.Add(this.label7);
            this.bookGroupBox.Controls.Add(this.label5);
            this.bookGroupBox.Controls.Add(this.txtPublicationYear);
            this.bookGroupBox.Controls.Add(this.btnDeleteBook);
            this.bookGroupBox.Controls.Add(this.label4);
            this.bookGroupBox.Controls.Add(this.btnSaveBook);
            this.bookGroupBox.Controls.Add(this.txtAuthorId);
            this.bookGroupBox.Controls.Add(this.btnEnditBook);
            this.bookGroupBox.Controls.Add(this.label3);
            this.bookGroupBox.Controls.Add(this.btnNewBook);
            this.bookGroupBox.Controls.Add(this.txtName);
            this.bookGroupBox.Controls.Add(this.label2);
            this.bookGroupBox.Controls.Add(this.txtBookId);
            this.bookGroupBox.Controls.Add(this.label1);
            this.bookGroupBox.Location = new System.Drawing.Point(4, 4);
            this.bookGroupBox.Name = "bookGroupBox";
            this.bookGroupBox.Size = new System.Drawing.Size(394, 180);
            this.bookGroupBox.TabIndex = 4;
            this.bookGroupBox.TabStop = false;
            this.bookGroupBox.Text = "Book";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(109, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(185, 20);
            this.txtPrice.TabIndex = 29;
            // 
            // txtPublisherId
            // 
            this.txtPublisherId.Location = new System.Drawing.Point(109, 119);
            this.txtPublisherId.Name = "txtPublisherId";
            this.txtPublisherId.Size = new System.Drawing.Size(185, 20);
            this.txtPublisherId.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "PublisherId";
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Location = new System.Drawing.Point(109, 93);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(185, 20);
            this.txtPublicationYear.TabIndex = 21;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(314, 152);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 1;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Publication Year";
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Location = new System.Drawing.Point(314, 123);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBook.TabIndex = 1;
            this.btnSaveBook.Text = "Save";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(109, 67);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(185, 20);
            this.txtAuthorId.TabIndex = 20;
            // 
            // btnEnditBook
            // 
            this.btnEnditBook.Location = new System.Drawing.Point(314, 96);
            this.btnEnditBook.Name = "btnEnditBook";
            this.btnEnditBook.Size = new System.Drawing.Size(75, 23);
            this.btnEnditBook.TabIndex = 1;
            this.btnEnditBook.Text = "Endit";
            this.btnEnditBook.UseVisualStyleBackColor = true;
            this.btnEnditBook.Click += new System.EventHandler(this.btnEnditBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "AuthorId";
            // 
            // btnNewBook
            // 
            this.btnNewBook.Location = new System.Drawing.Point(314, 67);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(75, 23);
            this.btnNewBook.TabIndex = 1;
            this.btnNewBook.Text = "Nwe";
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(109, 15);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(75, 20);
            this.txtBookId.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "BookId";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 190);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(404, 170);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 360);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bookGroupBox);
            this.Name = "BookForm";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.bookGroupBox.ResumeLayout(false);
            this.bookGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bookGroupBox;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPublisherId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.Button btnEnditBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}