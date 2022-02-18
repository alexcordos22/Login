using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        string numeFisier;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog obPoza = new OpenFileDialog()
            {
               // Filter = "JPEG|*.jpg",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (obPoza.ShowDialog() == DialogResult.OK)
                {
                    numeFisier = obPoza.FileName;
                    picPoza.Image = Image.FromFile(numeFisier);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nume = textBox1.Text;
            var adresa = textBox2.Text;
            var gender = radioButtonM.Checked ? radioButtonM.Text : (radioButtonF.Checked ? radioButtonF.Text : "Unknow");
            var language = checkBox1.Checked ? checkBox1.Text : (checkBox2.Checked ? checkBox2.Text : "Unknow");
            var oras = listBox1.GetItemText(listBox1.SelectedItem);
            MessageBox.Show(this.label1.Text + " " + this.textBox1.Text +"\n" + 
                this.label2.Text + " " + this.textBox2.Text + "\n" + 
                "Gen: "+ gender +"\n" +
                "Limbaj: " + language +"\n"+
                "Oras: " +  oras  + "\n"
                ) ;
                
        }
    }
}
