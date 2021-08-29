
namespace Login_2
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.btnViewandUpdate = new System.Windows.Forms.Button();
            this.btnViewBooks = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBooks.SuspendLayout();
            this.panelStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 585);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Calligraphy", 40F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(604, 390);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(275, 70);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(656, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 81);
            this.label3.TabIndex = 1;
            this.label3.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(535, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(659, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.panelBooks);
            this.panel2.Controls.Add(this.panelStudents);
            this.panel2.Controls.Add(this.btnCategories);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnTransaction);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 206);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDate.Location = new System.Drawing.Point(2, 24);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(32, 17);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTime.Location = new System.Drawing.Point(2, 7);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 17);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // panelBooks
            // 
            this.panelBooks.Controls.Add(this.btnReturnBooks);
            this.panelBooks.Controls.Add(this.btnIssueBooks);
            this.panelBooks.Controls.Add(this.btnViewandUpdate);
            this.panelBooks.Controls.Add(this.btnViewBooks);
            this.panelBooks.Controls.Add(this.btnAddBooks);
            this.panelBooks.Controls.Add(this.btnBooks);
            this.panelBooks.Location = new System.Drawing.Point(430, 10);
            this.panelBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(112, 31);
            this.panelBooks.TabIndex = 7;
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBooks.FlatAppearance.BorderSize = 0;
            this.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBooks.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBooks.ForeColor = System.Drawing.Color.White;
            this.btnReturnBooks.Location = new System.Drawing.Point(0, 119);
            this.btnReturnBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReturnBooks.Size = new System.Drawing.Size(94, 23);
            this.btnReturnBooks.TabIndex = 0;
            this.btnReturnBooks.Text = "RETURN BOOKS";
            this.btnReturnBooks.UseVisualStyleBackColor = false;
            this.btnReturnBooks.Click += new System.EventHandler(this.button6_Click);
            this.btnReturnBooks.MouseLeave += new System.EventHandler(this.btnReturnBooks_MouseLeave);
            this.btnReturnBooks.MouseHover += new System.EventHandler(this.btnReturnBooks_MouseHover);
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnIssueBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBooks.FlatAppearance.BorderSize = 0;
            this.btnIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBooks.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnIssueBooks.Location = new System.Drawing.Point(0, 93);
            this.btnIssueBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIssueBooks.Size = new System.Drawing.Size(94, 23);
            this.btnIssueBooks.TabIndex = 0;
            this.btnIssueBooks.Text = "ISSUE BOOKS";
            this.btnIssueBooks.UseVisualStyleBackColor = false;
            this.btnIssueBooks.Click += new System.EventHandler(this.button5_Click);
            this.btnIssueBooks.MouseLeave += new System.EventHandler(this.btnIssueBooks_MouseLeave);
            this.btnIssueBooks.MouseHover += new System.EventHandler(this.btnIssueBooks_MouseHover);
            // 
            // btnViewandUpdate
            // 
            this.btnViewandUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnViewandUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewandUpdate.FlatAppearance.BorderSize = 0;
            this.btnViewandUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewandUpdate.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewandUpdate.ForeColor = System.Drawing.Color.White;
            this.btnViewandUpdate.Location = new System.Drawing.Point(-18, 147);
            this.btnViewandUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewandUpdate.Name = "btnViewandUpdate";
            this.btnViewandUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewandUpdate.Size = new System.Drawing.Size(137, 23);
            this.btnViewandUpdate.TabIndex = 0;
            this.btnViewandUpdate.Text = "UPDATE and DELETE";
            this.btnViewandUpdate.UseVisualStyleBackColor = false;
            this.btnViewandUpdate.Click += new System.EventHandler(this.button8_Click);
            this.btnViewandUpdate.MouseLeave += new System.EventHandler(this.btnViewandUpdate_MouseLeave);
            this.btnViewandUpdate.MouseHover += new System.EventHandler(this.btnViewandUpdate_MouseHover);
            // 
            // btnViewBooks
            // 
            this.btnViewBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnViewBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBooks.FlatAppearance.BorderSize = 0;
            this.btnViewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBooks.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooks.ForeColor = System.Drawing.Color.White;
            this.btnViewBooks.Location = new System.Drawing.Point(0, 64);
            this.btnViewBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewBooks.Size = new System.Drawing.Size(94, 23);
            this.btnViewBooks.TabIndex = 0;
            this.btnViewBooks.Text = "VIEW BOOKS";
            this.btnViewBooks.UseVisualStyleBackColor = false;
            this.btnViewBooks.Click += new System.EventHandler(this.button3_Click);
            this.btnViewBooks.MouseLeave += new System.EventHandler(this.btnViewBooks_MouseLeave);
            this.btnViewBooks.MouseHover += new System.EventHandler(this.btnViewBooks_MouseHover);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBooks.FlatAppearance.BorderSize = 0;
            this.btnAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooks.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooks.ForeColor = System.Drawing.Color.White;
            this.btnAddBooks.Location = new System.Drawing.Point(0, 37);
            this.btnAddBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddBooks.Size = new System.Drawing.Size(94, 23);
            this.btnAddBooks.TabIndex = 0;
            this.btnAddBooks.Text = "ADD BOOKS";
            this.btnAddBooks.UseVisualStyleBackColor = false;
            this.btnAddBooks.ClientSizeChanged += new System.EventHandler(this.btnAddBooks_ClientSizeChanged);
            this.btnAddBooks.Click += new System.EventHandler(this.button2_Click);
            this.btnAddBooks.MouseLeave += new System.EventHandler(this.btnAddBooks_MouseLeave);
            this.btnAddBooks.MouseHover += new System.EventHandler(this.btnAddBooks_MouseHover);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Location = new System.Drawing.Point(0, 0);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBooks.Size = new System.Drawing.Size(112, 32);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "BOOKS";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.button1_Click);
            this.btnBooks.MouseLeave += new System.EventHandler(this.btnBooks_MouseLeave);
            this.btnBooks.MouseHover += new System.EventHandler(this.btnBooks_MouseHover);
            // 
            // panelStudents
            // 
            this.panelStudents.BackColor = System.Drawing.Color.Transparent;
            this.panelStudents.Controls.Add(this.btnViewStudents);
            this.panelStudents.Controls.Add(this.btnAddStudents);
            this.panelStudents.Controls.Add(this.btnStudent);
            this.panelStudents.ForeColor = System.Drawing.Color.White;
            this.panelStudents.Location = new System.Drawing.Point(548, 10);
            this.panelStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(90, 31);
            this.panelStudents.TabIndex = 6;
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnViewStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStudents.FlatAppearance.BorderSize = 0;
            this.btnViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudents.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudents.ForeColor = System.Drawing.Color.White;
            this.btnViewStudents.Location = new System.Drawing.Point(-1, 67);
            this.btnViewStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(97, 23);
            this.btnViewStudents.TabIndex = 0;
            this.btnViewStudents.Text = "VIEW STUDENTS";
            this.btnViewStudents.UseVisualStyleBackColor = false;
            this.btnViewStudents.Click += new System.EventHandler(this.button9_Click);
            this.btnViewStudents.MouseLeave += new System.EventHandler(this.btnViewStudents_MouseLeave);
            this.btnViewStudents.MouseHover += new System.EventHandler(this.btnViewStudents_MouseHover);
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudents.FlatAppearance.BorderSize = 0;
            this.btnAddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudents.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudents.ForeColor = System.Drawing.Color.White;
            this.btnAddStudents.Location = new System.Drawing.Point(-1, 37);
            this.btnAddStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(97, 23);
            this.btnAddStudents.TabIndex = 0;
            this.btnAddStudents.Text = "ADD STUDENTS";
            this.btnAddStudents.UseVisualStyleBackColor = false;
            this.btnAddStudents.Click += new System.EventHandler(this.button7_Click);
            this.btnAddStudents.MouseLeave += new System.EventHandler(this.btnAddStudents_MouseLeave);
            this.btnAddStudents.MouseHover += new System.EventHandler(this.btnAddStudents_MouseHover);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(0, 0);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(90, 32);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "STUDENTS";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            this.btnStudent.MouseLeave += new System.EventHandler(this.btnStudent_MouseLeave);
            this.btnStudent.MouseHover += new System.EventHandler(this.btnStudent_MouseHover);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(647, 10);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(99, 32);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "CATEGORIES";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCatogories_Click);
            this.btnCategories.MouseLeave += new System.EventHandler(this.btnCategories_MouseLeave);
            this.btnCategories.MouseHover += new System.EventHandler(this.btnCategories_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(853, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 49);
            this.button4.TabIndex = 0;
            this.button4.Text = "INVENTORY REPORTS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(744, 10);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(104, 34);
            this.btnTransaction.TabIndex = 0;
            this.btnTransaction.Text = "TRANSACTION";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            this.btnTransaction.MouseLeave += new System.EventHandler(this.btnTransaction_MouseLeave);
            this.btnTransaction.MouseHover += new System.EventHandler(this.btnTransaction_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBooks.ResumeLayout(false);
            this.panelStudents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.Button btnViewandUpdate;
        private System.Windows.Forms.Button btnViewBooks;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}