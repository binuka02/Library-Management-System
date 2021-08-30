
namespace Login_2
{
    partial class Kids
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataKids = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataKids)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(346, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 69);
            this.label1.TabIndex = 42;
            this.label1.Text = "KIDS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(263, 514);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(369, 39);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dataKids
            // 
            this.dataKids.BackgroundColor = System.Drawing.Color.White;
            this.dataKids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKids.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dataKids.Location = new System.Drawing.Point(47, 129);
            this.dataKids.Name = "dataKids";
            this.dataKids.RowHeadersWidth = 51;
            this.dataKids.RowTemplate.Height = 24;
            this.dataKids.Size = new System.Drawing.Size(805, 336);
            this.dataKids.TabIndex = 40;
            this.dataKids.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBiographiess_CellContentClick);
            // 
            // Kids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataKids);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kids";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kids";
            ((System.ComponentModel.ISupportInitialize)(this.dataKids)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dataKids;
    }
}