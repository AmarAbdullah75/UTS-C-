namespace PRG2_20232_P7_1_90
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
            this.hdlClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTlp = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbTlp = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbJudul = new System.Windows.Forms.Label();
            this.hdlSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hdlClear
            // 
            this.hdlClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.hdlClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hdlClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdlClear.ForeColor = System.Drawing.Color.White;
            this.hdlClear.Location = new System.Drawing.Point(458, 365);
            this.hdlClear.Name = "hdlClear";
            this.hdlClear.Size = new System.Drawing.Size(113, 44);
            this.hdlClear.TabIndex = 21;
            this.hdlClear.Text = "&Clear";
            this.hdlClear.UseVisualStyleBackColor = false;
            this.hdlClear.Click += new System.EventHandler(this.hdlClear_Click);
            this.hdlClear.MouseEnter += new System.EventHandler(this.hdlClear_MouseEnter);
            this.hdlClear.MouseLeave += new System.EventHandler(this.hdlClear_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(208, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Alamat                         :";
            // 
            // lbTlp
            // 
            this.lbTlp.AutoSize = true;
            this.lbTlp.BackColor = System.Drawing.Color.Transparent;
            this.lbTlp.Location = new System.Drawing.Point(208, 217);
            this.lbTlp.Name = "lbTlp";
            this.lbTlp.Size = new System.Drawing.Size(127, 16);
            this.lbTlp.TabIndex = 19;
            this.lbTlp.Text = "Telepon                      :";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.BackColor = System.Drawing.Color.Transparent;
            this.lbNama.Location = new System.Drawing.Point(208, 164);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(127, 16);
            this.lbNama.TabIndex = 18;
            this.lbNama.Text = "Nama Supplier         :";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Location = new System.Drawing.Point(208, 119);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(127, 16);
            this.lbID.TabIndex = 17;
            this.lbID.Text = "ID Supplier                 :";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(360, 269);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(233, 22);
            this.tbAlamat.TabIndex = 16;
            // 
            // tbTlp
            // 
            this.tbTlp.Location = new System.Drawing.Point(360, 214);
            this.tbTlp.Name = "tbTlp";
            this.tbTlp.Size = new System.Drawing.Size(233, 22);
            this.tbTlp.TabIndex = 15;
            this.tbTlp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTlp_KeyPress);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(360, 161);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(233, 22);
            this.tbNama.TabIndex = 14;
            this.tbNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNama_KeyPress);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(360, 116);
            this.tbID.MaxLength = 5;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(233, 22);
            this.tbID.TabIndex = 13;
            // 
            // lbJudul
            // 
            this.lbJudul.AutoSize = true;
            this.lbJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudul.Location = new System.Drawing.Point(290, 41);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(281, 32);
            this.lbJudul.TabIndex = 12;
            this.lbJudul.Text = "Form Input Supplier";
            // 
            // hdlSave
            // 
            this.hdlSave.BackColor = System.Drawing.Color.LimeGreen;
            this.hdlSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hdlSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdlSave.ForeColor = System.Drawing.Color.White;
            this.hdlSave.Location = new System.Drawing.Point(242, 365);
            this.hdlSave.Name = "hdlSave";
            this.hdlSave.Size = new System.Drawing.Size(113, 44);
            this.hdlSave.TabIndex = 11;
            this.hdlSave.Text = "&Save";
            this.hdlSave.UseVisualStyleBackColor = false;
            this.hdlSave.Click += new System.EventHandler(this.hdlSave_Click);
            this.hdlSave.MouseEnter += new System.EventHandler(this.hdlSave_MouseEnter);
            this.hdlSave.MouseLeave += new System.EventHandler(this.hdlSave_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hdlClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTlp);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbTlp);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbJudul);
            this.Controls.Add(this.hdlSave);
            this.Name = "Form1";
            this.Text = "Form Input Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hdlClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTlp;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbTlp;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbJudul;
        private System.Windows.Forms.Button hdlSave;
    }
}

