using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_20232_P7_2_90{
    public partial class Form1 : Form{
        
        public Form1(){
            InitializeComponent();
        }

        private void handleSearch_Click(object sender, EventArgs e){
            Boolean status = false;
            try{
                using (LinqSupplierDataContext context = new LinqSupplierDataContext()){
                    List<ms_supplier> list = context.ms_suppliers.ToList();
                    foreach (ms_supplier supplier in list){
                        if (tbID.Text.Equals(supplier.id_supplier)){
                            tbNama.Text = supplier.nama_supplier;
                            tbTlp.Text = supplier.telp;
                            tbAlamat.Text = supplier.alamat;
                            tbNama.Enabled = true;
                            tbTlp.Enabled = true;
                            tbAlamat.Enabled = true;
                            handleUpd.Enabled = true;
                            handleDlt.Enabled = true;
                            status = true;
                        }
                    }
                    if (!status){
                        MessageBox.Show("Supplier dengan id " + tbID.Text + " tidak ditemukan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch(Exception ex){
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void handleUpd_Click(object sender, EventArgs e){
            if (tbID.Text == "" || tbNama.Text == "" || tbTlp.Text == "" || tbAlamat.Text == ""){
                MessageBox.Show("Semua inputan harus terisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else{
                try{
                    using (LinqSupplierDataContext context = new LinqSupplierDataContext()){
                        List<ms_supplier> list = context.ms_suppliers.ToList();
                        foreach (ms_supplier supplier in list){
                            if (tbID.Text.Equals(supplier.id_supplier)){
                                supplier.nama_supplier = tbNama.Text;
                                supplier.telp = tbTlp.Text;
                                supplier.alamat = tbAlamat.Text;
                                context.SubmitChanges();
                            }
                        }
                        MessageBox.Show("Data Berhasil Diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                }catch (Exception ex){
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void handleDlt_Click(object sender, EventArgs e){
            if (tbID.Text == "" || tbNama.Text == "" || tbTlp.Text == "" || tbAlamat.Text == ""){
                MessageBox.Show("Semua inputan harus terisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else{
                try{
                    using (LinqSupplierDataContext context = new LinqSupplierDataContext()){
                        List<ms_supplier> list = context.ms_suppliers.ToList();
                        foreach (ms_supplier supplier in list){
                            if (tbID.Text.Equals(supplier.id_supplier)){
                                context.ms_suppliers.DeleteOnSubmit(supplier);
                                context.SubmitChanges();
                            }
                        }
                        MessageBox.Show("Data Berhasil Dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                }catch (Exception ex){
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e){
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)){
                if (e.KeyChar != '\b'){
                    e.Handled = true;
                }
            }
        }

        private void tbTlp_KeyPress(object sender, KeyPressEventArgs e){
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)){
                if (e.KeyChar != '\b' && e.KeyChar != ' '){
                    e.Handled = true;
                }
            }
        }

        private void handleUpd_MouseEnter(object sender, EventArgs e){
            handleUpd.BackColor = Color.White;
            handleUpd.ForeColor = Color.DeepSkyBlue;
        }

        private void handleUpd_MouseLeave(object sender, EventArgs e){
            handleUpd.BackColor = Color.DeepSkyBlue;
            handleUpd.ForeColor = Color.White;
        }

        private void handleDlt_MouseEnter(object sender, EventArgs e){
            handleDlt.BackColor = Color.White;
            handleDlt.ForeColor = Color.Red;
        }

        private void handleDlt_MouseLeave(object sender, EventArgs e){
            handleDlt.BackColor = Color.Red;
            handleDlt.ForeColor = Color.White;
        }

        private void handleClr_Click(object sender, EventArgs e){
            clear();
        }
        private void clear(){
            tbID.Text = "";
            tbNama.Text = "";
            tbTlp.Text = "";
            tbAlamat.Text = "";
            handleUpd.Enabled = false;
            handleDlt.Enabled = false;
        }

        private void handleClr_MouseEnter(object sender, EventArgs e){
            handleClr.BackColor = Color.White;
            handleClr.ForeColor = Color.Lime;
        }

        private void handleClr_MouseLeave(object sender, EventArgs e){
            handleClr.BackColor = Color.Lime;
            handleClr.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e){
            
        }
    }
}
