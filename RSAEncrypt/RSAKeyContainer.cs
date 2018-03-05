using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAEncrypt
{
    public partial class RSAKeyContainer : Form
    {
        public RSAKeyContainer()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtKey.Text))
            {
                if (!String.IsNullOrEmpty(txtNameFile.Text))
                {
                    RsaProtect rsaProtect = new RsaProtect();
                    if (rsaProtect.createRsaKeyContainer(txtKey.Text, txtPath.Text, txtNameFile.Text))
                    {
                        MessageBox.Show("Se ha creado correctamente el contenedor de llaves.");
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe digitar un nombre de archivo.");
                    txtNameFile.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe digitar una clave.");
                txtKey.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
