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
    public partial class Input_Banyak_Data_Prodi : Form{
        public Input_Banyak_Data_Prodi(){
            InitializeComponent();
        }

        private void handleSimpan_Click(object sender, EventArgs e){
            try{
                List<msprodi> prodi = new List<msprodi>();
                LinqDataDataContext linq = new LinqDataDataContext();

                for (int i = 0; i < dgvProdi.Rows.Count - 1; i++){
                    msprodi item = new msprodi();

                    item.id_prodi = dgvProdi.Rows[i].Cells[0].Value.ToString();
                    item.nama_prodi = dgvProdi.Rows[i].Cells[1].Value.ToString();
                    item.singkatan = dgvProdi.Rows[i].Cells[2].Value.ToString();
                    item.ka_prodi = dgvProdi.Rows[i].Cells[3].Value.ToString();
                    item.sek_prodi = dgvProdi.Rows[i].Cells[4].Value.ToString();
                    prodi.Add(item);
                }
                linq.msprodis.InsertAllOnSubmit(prodi);
                linq.SubmitChanges();
                MessageBox.Show("Data Berhasil Ditambahkan");
            }catch (Exception ex){
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void handleSimpan_Enter(object sender, EventArgs e){
            handleSimpan.BackColor = Color.White;
            handleSimpan.ForeColor= Color.LimeGreen;
        }

        private void handleSimpan_leave(object sender, EventArgs e){
            handleSimpan.BackColor = Color.LimeGreen;
            handleSimpan.ForeColor = Color.White;
        }

        private void handleSupplier_Click(object sender, EventArgs e){
            Form1 supp = new Form1();
            supp.Show();
            this.Hide();
        }
    }
}
