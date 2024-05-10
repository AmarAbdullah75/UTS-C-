namespace PRG2_20232_P7_3_90
{
    partial class Input_Banyak_Data_Prodi
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
            this.handleSimpan = new System.Windows.Forms.Button();
            this.dgvProdi = new System.Windows.Forms.DataGridView();
            this.id_Prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_Prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ka_prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sek_prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handleSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input Banyak Data Prodi";
            // 
            // handleSimpan
            // 
            this.handleSimpan.BackColor = System.Drawing.Color.LimeGreen;
            this.handleSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handleSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleSimpan.ForeColor = System.Drawing.Color.White;
            this.handleSimpan.Location = new System.Drawing.Point(305, 386);
            this.handleSimpan.Name = "handleSimpan";
            this.handleSimpan.Size = new System.Drawing.Size(96, 32);
            this.handleSimpan.TabIndex = 6;
            this.handleSimpan.Text = "Simpan";
            this.handleSimpan.UseVisualStyleBackColor = false;
            this.handleSimpan.Click += new System.EventHandler(this.handleSimpan_Click);
            this.handleSimpan.MouseEnter += new System.EventHandler(this.handleSimpan_Enter);
            this.handleSimpan.MouseLeave += new System.EventHandler(this.handleSimpan_leave);
            // 
            // dgvProdi
            // 
            this.dgvProdi.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Prodi,
            this.nama_Prodi,
            this.singkatan,
            this.ka_prodi,
            this.sek_prodi});
            this.dgvProdi.Location = new System.Drawing.Point(57, 67);
            this.dgvProdi.Name = "dgvProdi";
            this.dgvProdi.RowHeadersWidth = 51;
            this.dgvProdi.RowTemplate.Height = 24;
            this.dgvProdi.Size = new System.Drawing.Size(976, 278);
            this.dgvProdi.TabIndex = 5;
            // 
            // id_Prodi
            // 
            this.id_Prodi.HeaderText = "ID Prodi";
            this.id_Prodi.MinimumWidth = 6;
            this.id_Prodi.Name = "id_Prodi";
            this.id_Prodi.Width = 125;
            // 
            // nama_Prodi
            // 
            this.nama_Prodi.HeaderText = "Nama Prodi";
            this.nama_Prodi.MinimumWidth = 6;
            this.nama_Prodi.Name = "nama_Prodi";
            this.nama_Prodi.Width = 125;
            // 
            // singkatan
            // 
            this.singkatan.HeaderText = "Singkatan";
            this.singkatan.MinimumWidth = 6;
            this.singkatan.Name = "singkatan";
            this.singkatan.Width = 125;
            // 
            // ka_prodi
            // 
            this.ka_prodi.HeaderText = "Ketua Prodi";
            this.ka_prodi.MinimumWidth = 6;
            this.ka_prodi.Name = "ka_prodi";
            this.ka_prodi.Width = 125;
            // 
            // sek_prodi
            // 
            this.sek_prodi.HeaderText = "Sekretaris Prodi";
            this.sek_prodi.MinimumWidth = 6;
            this.sek_prodi.Name = "sek_prodi";
            this.sek_prodi.Width = 125;
            // 
            // handleSupplier
            // 
            this.handleSupplier.BackColor = System.Drawing.Color.LimeGreen;
            this.handleSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handleSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleSupplier.ForeColor = System.Drawing.Color.White;
            this.handleSupplier.Location = new System.Drawing.Point(575, 386);
            this.handleSupplier.Name = "handleSupplier";
            this.handleSupplier.Size = new System.Drawing.Size(119, 32);
            this.handleSupplier.TabIndex = 8;
            this.handleSupplier.Text = "Input Supplier";
            this.handleSupplier.UseVisualStyleBackColor = false;
            this.handleSupplier.Click += new System.EventHandler(this.handleSupplier_Click);
            this.handleSupplier.MouseEnter += new System.EventHandler(this.handleSimpan_Enter);
            this.handleSupplier.MouseLeave += new System.EventHandler(this.handleSimpan_leave);
            // 
            // Input_Banyak_Data_Prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.handleSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.handleSimpan);
            this.Controls.Add(this.dgvProdi);
            this.Name = "Input_Banyak_Data_Prodi";
            this.Text = "Input Banyak Data Prodi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button handleSimpan;
        private System.Windows.Forms.DataGridView dgvProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_Prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn singkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ka_prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sek_prodi;
        private System.Windows.Forms.Button handleSupplier;
    }
}