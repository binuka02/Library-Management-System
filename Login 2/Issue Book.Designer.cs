
namespace Login_2
{
    partial class Issue_Book
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
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookQuantity = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.txtNoOfBorrowedBooks = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.Color.White;
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookID.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(215, 165);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(168, 22);
            this.txtBookID.TabIndex = 5;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(271, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Book ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtNoOfBorrowedBooks);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.txtBookQuantity);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStudentID);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.txtBookID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 539);
            this.panel1.TabIndex = 35;
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.AutoSize = true;
            this.txtBookQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtBookQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.txtBookQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtBookQuantity.Location = new System.Drawing.Point(385, 176);
            this.txtBookQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(77, 13);
            this.txtBookQuantity.TabIndex = 14;
            this.txtBookQuantity.Text = "Book Quantity";
            // 
            // txtBookName
            // 
            this.txtBookName.AutoSize = true;
            this.txtBookName.BackColor = System.Drawing.Color.Transparent;
            this.txtBookName.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.txtBookName.ForeColor = System.Drawing.Color.Black;
            this.txtBookName.Location = new System.Drawing.Point(385, 163);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(64, 13);
            this.txtBookName.TabIndex = 13;
            this.txtBookName.Text = "Book Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(170, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "VIEW ISSUED BOOKS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblBack.Location = new System.Drawing.Point(510, 496);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(36, 13);
            this.lblBack.TabIndex = 11;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(269, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(215, 232);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(168, 22);
            this.txtStudentID.TabIndex = 9;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonSearch.Location = new System.Drawing.Point(248, 287);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 26);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "View All Books";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClear.Location = new System.Drawing.Point(170, 373);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(277, 28);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(137, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "ISSUE  BOOKS";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(170, 342);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(277, 28);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "ISSUE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // txtNoOfBorrowedBooks
            // 
            this.txtNoOfBorrowedBooks.AutoSize = true;
            this.txtNoOfBorrowedBooks.BackColor = System.Drawing.Color.Transparent;
            this.txtNoOfBorrowedBooks.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.txtNoOfBorrowedBooks.ForeColor = System.Drawing.Color.Black;
            this.txtNoOfBorrowedBooks.Location = new System.Drawing.Point(385, 244);
            this.txtNoOfBorrowedBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNoOfBorrowedBooks.Name = "txtNoOfBorrowedBooks";
            this.txtNoOfBorrowedBooks.Size = new System.Drawing.Size(120, 13);
            this.txtNoOfBorrowedBooks.TabIndex = 16;
            this.txtNoOfBorrowedBooks.Text = "No of Borrowed Books";
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoSize = true;
            this.txtStudentName.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentName.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.txtStudentName.ForeColor = System.Drawing.Color.Black;
            this.txtStudentName.Location = new System.Drawing.Point(385, 231);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(74, 13);
            this.txtStudentName.TabIndex = 15;
            this.txtStudentName.Text = "Student Name";
            this.txtStudentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Issue_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 531);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Issue_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue_Book";
            this.Load += new System.EventHandler(this.Issue_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtBookQuantity;
        private System.Windows.Forms.Label txtBookName;
        private System.Windows.Forms.Label txtNoOfBorrowedBooks;
        private System.Windows.Forms.Label txtStudentName;
    }
}