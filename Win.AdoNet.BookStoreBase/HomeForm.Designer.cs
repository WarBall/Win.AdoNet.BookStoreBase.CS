
namespace Win.AdoNet.BookStoreBase
{
    partial class HomeForm
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
            this.btnAuthorTables = new System.Windows.Forms.Button();
            this.btnBookTables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuthorTables
            // 
            this.btnAuthorTables.Location = new System.Drawing.Point(12, 12);
            this.btnAuthorTables.Name = "btnAuthorTables";
            this.btnAuthorTables.Size = new System.Drawing.Size(140, 83);
            this.btnAuthorTables.TabIndex = 0;
            this.btnAuthorTables.Text = "Работать с таблицей \"Author\"";
            this.btnAuthorTables.UseVisualStyleBackColor = true;
            this.btnAuthorTables.Click += new System.EventHandler(this.btnAuthorTables_Click);
            // 
            // btnBookTables
            // 
            this.btnBookTables.Location = new System.Drawing.Point(158, 12);
            this.btnBookTables.Name = "btnBookTables";
            this.btnBookTables.Size = new System.Drawing.Size(140, 83);
            this.btnBookTables.TabIndex = 0;
            this.btnBookTables.Text = "Работать с таблицей \"Book\"";
            this.btnBookTables.UseVisualStyleBackColor = true;
            this.btnBookTables.Click += new System.EventHandler(this.btnBookTables_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 107);
            this.Controls.Add(this.btnBookTables);
            this.Controls.Add(this.btnAuthorTables);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Store Base";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthorTables;
        private System.Windows.Forms.Button btnBookTables;
    }
}

