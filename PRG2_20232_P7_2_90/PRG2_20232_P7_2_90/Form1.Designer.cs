namespace PRG2_20232_P7_2_90
{
    partial class Form1
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
            this.handleSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.handleClr = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.handleUpd = new System.Windows.Forms.Button();
            this.tbTlp = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.handleDlt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // handleSearch
            // 
            this.handleSearch.Location = new System.Drawing.Point(383, 118);
            this.handleSearch.Name = "handleSearch";
            this.handleSearch.Size = new System.Drawing.Size(67, 22);
            this.handleSearch.TabIndex = 35;
            this.handleSearch.Text = "Cari";
            this.handleSearch.UseVisualStyleBackColor = true;
            this.handleSearch.Click += new System.EventHandler(this.handleSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Telepon";
            // 
            // handleClr
            // 
            this.handleClr.BackColor = System.Drawing.Color.Lime;
            this.handleClr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handleClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleClr.ForeColor = System.Drawing.Color.White;
            this.handleClr.Location = new System.Drawing.Point(363, 325);
            this.handleClr.Name = "handleClr";
            this.handleClr.Size = new System.Drawing.Size(98, 44);
            this.handleClr.TabIndex = 32;
            this.handleClr.Text = "Clear";
            this.handleClr.UseVisualStyleBackColor = false;
            this.handleClr.Click += new System.EventHandler(this.handleClr_Click);
            this.handleClr.MouseEnter += new System.EventHandler(this.handleClr_MouseEnter);
            this.handleClr.MouseLeave += new System.EventHandler(this.handleClr_MouseLeave);
            // 
            // tbNama
            // 
            this.tbNama.Enabled = false;
            this.tbNama.Location = new System.Drawing.Point(258, 157);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(192, 22);
            this.tbNama.TabIndex = 31;
            this.tbNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNama_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nama Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID Supplier";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(258, 118);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(108, 22);
            this.tbID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(254, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Form Update Supplier";
            // 
            // handleUpd
            // 
            this.handleUpd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.handleUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handleUpd.Enabled = false;
            this.handleUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleUpd.ForeColor = System.Drawing.Color.White;
            this.handleUpd.Location = new System.Drawing.Point(101, 325);
            this.handleUpd.Name = "handleUpd";
            this.handleUpd.Size = new System.Drawing.Size(98, 44);
            this.handleUpd.TabIndex = 26;
            this.handleUpd.Text = "Update";
            this.handleUpd.UseVisualStyleBackColor = false;
            this.handleUpd.Click += new System.EventHandler(this.handleUpd_Click);
            this.handleUpd.MouseEnter += new System.EventHandler(this.handleUpd_MouseEnter);
            this.handleUpd.MouseLeave += new System.EventHandler(this.handleUpd_MouseLeave);
            // 
            // tbTlp
            // 
            this.tbTlp.Enabled = false;
            this.tbTlp.Location = new System.Drawing.Point(258, 202);
            this.tbTlp.Multiline = true;
            this.tbTlp.Name = "tbTlp";
            this.tbTlp.Size = new System.Drawing.Size(192, 22);
            this.tbTlp.TabIndex = 36;
            this.tbTlp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTlp_KeyPress);
            // 
            // tbAlamat
            // 
            this.tbAlamat.Enabled = false;
            this.tbAlamat.Location = new System.Drawing.Point(258, 247);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(192, 22);
            this.tbAlamat.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Alamat";
            // 
            // handleDlt
            // 
            this.handleDlt.BackColor = System.Drawing.Color.Red;
            this.handleDlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handleDlt.Enabled = false;
            this.handleDlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleDlt.ForeColor = System.Drawing.Color.White;
            this.handleDlt.Location = new System.Drawing.Point(235, 325);
            this.handleDlt.Name = "handleDlt";
            this.handleDlt.Size = new System.Drawing.Size(98, 44);
            this.handleDlt.TabIndex = 39;
            this.handleDlt.Text = "Delete";
            this.handleDlt.UseVisualStyleBackColor = false;
            this.handleDlt.Click += new System.EventHandler(this.handleDlt_Click);
            this.handleDlt.MouseEnter += new System.EventHandler(this.handleDlt_MouseEnter);
            this.handleDlt.MouseLeave += new System.EventHandler(this.handleDlt_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 490);
            this.Controls.Add(this.handleDlt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbTlp);
            this.Controls.Add(this.handleSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.handleClr);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.handleUpd);
            this.Name = "Form1";
            this.Text = "Master Supplier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button handleSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button handleClr;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button handleUpd;
        private System.Windows.Forms.TextBox tbTlp;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button handleDlt;
    }
}

