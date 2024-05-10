using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_20232_P7_1_90{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void hdlSave_Click(object sender, EventArgs e){
            if (tbID.Text== ""||tbNama.Text==""||tbTlp.Text==""||tbAlamat.Text==""){
                MessageBox.Show("Semua inputan harus terisi","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else{
                try{
                    Boolean status = false;
                    using (LINQ_0320230090DataContext context = new LINQ_0320230090DataContext()){
                        List<ms_supplier> suppliers = context.ms_suppliers.ToList();
                        foreach (ms_supplier item in suppliers){
                            if (tbID.Text.Equals(item.id_supplier)){
                                status = true;
                                MessageBox.Show("Supplier dengan id " + tbID.Text + " sudah ada","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                        }
                        if (!status){
                            ms_supplier supp = new ms_supplier();
                            supp.id_supplier = tbID.Text;
                            supp.nama_supplier = tbNama.Text;
                            supp.telp = tbTlp.Text;
                            supp.alamat = tbAlamat.Text;

                            context.ms_suppliers.InsertOnSubmit(supp);
                            context.SubmitChanges();
                            MessageBox.Show("Data Berhasil Ditambah","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            clear();
                        }
                    }
                }catch (Exception ex){
                    MessageBox.Show("Error:" + ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void clear(){
            tbID.Text = "";
            tbNama.Text = "";
            tbTlp.Text = "";
            tbAlamat.Text = "";
        }
        private void hdlClear_Click(object sender, EventArgs e){
            clear();
        }

        private void tbTlp_KeyPress(object sender, KeyPressEventArgs e){
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar)){
                if (e.KeyChar!='\b'&&e.KeyChar!=' '){
                    e.Handled = true;
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

        private void hdlSave_MouseEnter(object sender, EventArgs e){
            hdlSave.BackColor = Color.White;
            hdlSave.ForeColor = Color.LimeGreen;
        }

        private void hdlSave_MouseLeave(object sender, EventArgs e){
            hdlSave.BackColor = Color.LimeGreen;
            hdlSave.ForeColor = Color.White;
        }

        private void hdlClear_MouseEnter(object sender, EventArgs e){
            hdlClear.BackColor = Color.White;
            hdlClear.ForeColor= Color.DeepSkyBlue;
        }

        private void hdlClear_MouseLeave(object sender, EventArgs e){
            hdlClear.BackColor = Color.DeepSkyBlue;
            hdlClear.ForeColor = Color.White;
        }
    }
}
