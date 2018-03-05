using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms;

namespace RSAEncrypt
{
    class RsaProtect
    {
        public RSACryptoServiceProvider RSAService { get; set; }

        public string encryptData(string text)
        {
            string encryptedData = "";

            

            return encryptedData;
        }

        public bool createRsaKeyContainer(string key, string path, string fileName)
        {
            try
            {
                Main main = new Main();
                Process process = new Process();
                string aspnetOutput = "";

                string[] args = {
                    "-pc \"" + key + "\" -exp",
                    "-pa \"NetFrameworkConfigurationKey\" \"NT AUTHORITY\\NETWORK SERVICE\"",
                    "-pa \"" + key + "\" \"NT AUTHORITY\\NETWORK SERVICE\"",
                    "-px \"" + key + "\" \"" + path + "\\" + fileName + ".xml\" -pri"

                };
                ProcessStartInfo[] processStartInfo = new ProcessStartInfo[args.Length];

                for (int i = 0; i < args.Length; i++)
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return true;
        }
    }
}
