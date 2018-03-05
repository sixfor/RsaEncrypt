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
    public partial class ImportRSAKeyContainer : Form
    {
        public ImportRSAKeyContainer()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.xml)|*.xml";
            openFileDialog.ShowDialog();
            Stream stream = openFileDialog.OpenFile();
            if (stream != null)
            {
                txtPathFile.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPathFile.Text))
            {
                if (!String.IsNullOrEmpty(txtKey.Text))
                {
                    List<string> args = new List<string>() {
                        "-pi \"" + txtKey.Text + "\" \"" + txtPathFile.Text +"\"",
                        "-pa \"NetFrameworkConfigurationKey\" \"NT AUTHORITY\\NETWORK SERVICE\"",
                        "-pa \"" + txtKey.Text + "\" \"NT AUTHORITY\\NETWORK SERVICE\""
                    };

                    if (!String.IsNullOrEmpty(txtAppPool.Text))
                        args.Add("-pa \"" + txtKey.Text + "\" \"IIS APPPOOL\\" + txtAppPool.Text + "\"");

                    Main main = new Main();
                    Process process = new Process();
                    ProcessStartInfo[] processStartInfo = new ProcessStartInfo[args.Count];
                    string aspnetOutput = "";

                    for (int i = 0; i < args.Count; i++)
                    {
                        processStartInfo[i] = new ProcessStartInfo();
                        processStartInfo[i].FileName = main.fullPathAspnet;
                        processStartInfo[i].Arguments = args[i];
                        processStartInfo[i].UseShellExecute = false;
                        processStartInfo[i].RedirectStandardOutput = true;
                        processStartInfo[i].StandardOutputEncoding = Encoding.GetEncoding(850);
                    }

                    for (int i = 0; i < processStartInfo.Length; i++)
                    {
                        process.StartInfo = processStartInfo[i];
                        process.Start();
                        aspnetOutput = process.StandardOutput.ReadToEnd();
                        MessageBox.Show("COMANDO: aspnet_regiis.exe " + processStartInfo[i].Arguments.ToString() + "\n\n" + aspnetOutput);
                    }
                }
                else
                {
                    MessageBox.Show("Debe digitar una llave.");
                    txtKey.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una ruta.");
                txtPathFile.Focus();
            }
        }
    }
}
