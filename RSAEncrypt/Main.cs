using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAEncrypt
{
    public partial class Main : Form
    {

        public string pathAspnet = "C:/Windows/Microsoft.NET/Framework/v4.0.30319";
        public string aspnetExe = "aspnet_regiis.exe";
        public string fullPathAspnet = "";

        public Main()
        {
            InitializeComponent();

            fullPathAspnet = pathAspnet + "/" + aspnetExe;
            aspnetPathValidator();
        }

        private void btnWebConfig_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathWebConfig.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                string args = "-pef \"connectionStrings\" \"" + txtPathWebConfig.Text + "\"" + " -prov \"" + txtProvider.Text + "\"";

                Process process = new Process();
                ProcessStartInfo processStartInfo = new ProcessStartInfo();

                if (!String.IsNullOrEmpty(txtProvider.Text))
                {
                    if (!String.IsNullOrEmpty(txtPathWebConfig.Text))
                    {
                        processStartInfo.FileName = fullPathAspnet;
                        processStartInfo.Arguments = args;
                        process.StartInfo = processStartInfo;
                        processStartInfo.UseShellExecute = false;
                        processStartInfo.RedirectStandardOutput = true;
                        processStartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);
                        process.Start();
                        string aspnetOutput = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();
                        MessageBox.Show(aspnetOutput);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar la ruta en donde se encuentre el web.config.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe digitar un provider.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        private void aspnetPathValidator()
        {
            if (!Directory.Exists(pathAspnet))
                MessageBox.Show("No existe o no tiene instalado .Net Framework, favor verificar. \n");
        }

        private void crearRSAKeyContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSAKeyContainer rSAKeyContainer = new RSAKeyContainer();
            rSAKeyContainer.Visible = true;
        }

        private void btnDesenriptar_Click(object sender, EventArgs e)
        {
            try
            {
                string args = "-pdf \"connectionStrings\" \"" + txtPathWebConfig.Text + "\"";

                Process process = new Process();
                ProcessStartInfo processStartInfo = new ProcessStartInfo();

                if (!String.IsNullOrEmpty(txtProvider.Text))
                {
                    processStartInfo.FileName = fullPathAspnet;
                    processStartInfo.Arguments = args;
                    processStartInfo.RedirectStandardOutput = true;
                    processStartInfo.UseShellExecute = false;
                    process.StartInfo = processStartInfo;
                    process.Start();
                    string aspnetOutput = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    MessageBox.Show(aspnetOutput);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void importarRSAKeyContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportRSAKeyContainer importRSAKeyContainer = new ImportRSAKeyContainer();
            importRSAKeyContainer.Visible = true;
        }

        private void eliminarRSAKeyContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRSAKeyContainer deleteRSAKeyContainer = new DeleteRSAKeyContainer();
            deleteRSAKeyContainer.Visible = true;
        }
    }
}
