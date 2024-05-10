using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_20232_P7_3_90{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void handleSimpan_Click(object sender, EventArgs e){
            try{
                List<ms_supplier> supplier = new List<ms_supplier>();
                LinqDataDataContext linq = new LinqDataDataContext();

                for (int i = 0; i < dgvSupplier.Rows.Count - 1; i++){
                    ms_supplier item = new ms_supplier();

                    item.id_supplier = dgvSupplier.Rows[i].Cells[0].Value.ToString();
                    item.nama_supplier = dgvSupplier.Rows[i].Cells[1].Value.ToString();
                    item.telp = dgvSupplier.Rows[i].Cells[2].Value.ToString();
                    item.alamat = dgvSupplier.Rows[i].Cells[3].Value.ToString();
                    supplier.Add(item);
                }
                linq.ms_suppliers.InsertAllOnSubmit(supplier);
                linq.SubmitChanges();
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
            catch (Exception ex){
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void handleSimpan_Enter(object sender, EventArgs e){
            handleSimpan.BackColor = Color.White;
            handleSimpan.ForeColor = Color.LimeGreen;
        }

        private void handleSimpan_Leave(object sender, EventArgs e){
            handleSimpan.BackColor = Color.LimeGreen;
            handleSimpan.ForeColor = Color.White;
        }

        private void handleProdi_Click(object sender, EventArgs e){
            Input_Banyak_Data_Prodi prodi = new Input_Banyak_Data_Prodi();
            prodi.Show();
            this.Hide();
        }
    }
}
