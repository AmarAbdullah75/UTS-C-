namespace PRG2_20232_P7_3_90
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
            this.handleSimpan = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.id_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.handleProdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // handleSimpan
            // 
            this.handleSimpan.BackColor = System.Drawing.Color.LimeGreen;
            this.handleSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handleSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleSimpan.ForeColor = System.Drawing.Color.White;
            this.handleSimpan.Location = new System.Drawing.Point(284, 375);
            this.handleSimpan.Name = "handleSimpan";
            this.handleSimpan.Size = new System.Drawing.Size(98, 33);
            this.handleSimpan.TabIndex = 3;
            this.handleSimpan.Text = "Simpan";
            this.handleSimpan.UseVisualStyleBackColor = false;
            this.handleSimpan.Click += new System.EventHandler(this.handleSimpan_Click);
            this.handleSimpan.MouseEnter += new System.EventHandler(this.handleSimpan_Enter);
            this.handleSimpan.MouseLeave += new System.EventHandler(this.handleSimpan_Leave);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_supplier,
            this.nama_supplier,
            this.telp,
            this.alamat});
            this.dgvSupplier.Location = new System.Drawing.Point(106, 53);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.RowTemplate.Height = 24;
            this.dgvSupplier.Size = new System.Drawing.Size(745, 278);
            this.dgvSupplier.TabIndex = 2;
            // 
            // id_supplier
            // 
            this.id_supplier.HeaderText = "ID Supplier";
            this.id_supplier.MinimumWidth = 6;
            this.id_supplier.Name = "id_supplier";
            this.id_supplier.Width = 125;
            // 
            // nama_supplier
            // 
            this.nama_supplier.HeaderText = "Nama Supplier";
            this.nama_supplier.MinimumWidth = 6;
            this.nama_supplier.Name = "nama_supplier";
            this.nama_supplier.Width = 125;
            // 
            // telp
            // 
            this.telp.HeaderText = "No Telepon";
            this.telp.MinimumWidth = 6;
            this.telp.Name = "telp";
            this.telp.Width = 125;
            // 
            // alamat
            // 
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 6;
            this.alamat.Name = "alamat";
            this.alamat.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Banyak Data Supplier";
            // 
            // handleProdi
            // 
            this.handleProdi.BackColor = System.Drawing.Color.LimeGreen;
            this.handleProdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handleProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleProdi.ForeColor = System.Drawing.Color.White;
            this.handleProdi.Location = new System.Drawing.Point(483, 375);
            this.handleProdi.Name = "handleProdi";
            this.handleProdi.Size = new System.Drawing.Size(98, 33);
            this.handleProdi.TabIndex = 5;
            this.handleProdi.Text = "Input Prodi";
            this.handleProdi.UseVisualStyleBackColor = false;
            this.handleProdi.Click += new System.EventHandler(this.handleProdi_Click);
            this.handleProdi.MouseEnter += new System.EventHandler(this.handleSimpan_Enter);
            this.handleProdi.MouseLeave += new System.EventHandler(this.handleSimpan_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.handleProdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.handleSimpan);
            this.Controls.Add(this.dgvSupplier);
            this.Name = "Form1";
            this.Text = "Input Banyak Data Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button handleSimpan;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.Button handleProdi;
    }
}

