namespace RSAEncrypt
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRSAKeyContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbAppSettings = new System.Windows.Forms.CheckBox();
            this.chbConnectionStrings = new System.Windows.Forms.CheckBox();
            this.btnDesenriptar = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWebConfig = new System.Windows.Forms.Button();
            this.txtPathWebConfig = new System.Windows.Forms.TextBox();
            this.importarRSAKeyContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRSAKeyContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearClaveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearClaveToolStripMenuItem
            // 
            this.crearClaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRSAKeyContainerToolStripMenuItem,
            this.importarRSAKeyContainerToolStripMenuItem,
            this.eliminarRSAKeyContainerToolStripMenuItem});
            this.crearClaveToolStripMenuItem.Name = "crearClaveToolStripMenuItem";
            this.crearClaveToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.crearClaveToolStripMenuItem.Text = "Archivo";
            // 
            // crearRSAKeyContainerToolStripMenuItem
            // 
            this.crearRSAKeyContainerToolStripMenuItem.Name = "crearRSAKeyContainerToolStripMenuItem";
            this.crearRSAKeyContainerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.crearRSAKeyContainerToolStripMenuItem.Text = "Crear RSAKeyContainer";
            this.crearRSAKeyContainerToolStripMenuItem.Click += new System.EventHandler(this.crearRSAKeyContainerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProvider);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDesenriptar);
            this.panel1.Controls.Add(this.btnEncriptar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnWebConfig);
            this.panel1.Controls.Add(this.txtPathWebConfig);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 198);
            this.panel1.TabIndex = 1;
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(77, 50);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(147, 20);
            this.txtProvider.TabIndex = 10;
            this.txtProvider.Text = "AdpProvider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Provider:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbAppSettings);
            this.groupBox1.Controls.Add(this.chbConnectionStrings);
            this.groupBox1.Location = new System.Drawing.Point(24, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secciones";
            // 
            // chbAppSettings
            // 
            this.chbAppSettings.AutoSize = true;
            this.chbAppSettings.Location = new System.Drawing.Point(6, 53);
            this.chbAppSettings.Name = "chbAppSettings";
            this.chbAppSettings.Size = new System.Drawing.Size(83, 17);
            this.chbAppSettings.TabIndex = 7;
            this.chbAppSettings.Text = "AppSettings";
            this.chbAppSettings.UseVisualStyleBackColor = true;
            // 
            // chbConnectionStrings
            // 
            this.chbConnectionStrings.AutoSize = true;
            this.chbConnectionStrings.Checked = true;
            this.chbConnectionStrings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbConnectionStrings.Location = new System.Drawing.Point(6, 29);
            this.chbConnectionStrings.Name = "chbConnectionStrings";
            this.chbConnectionStrings.Size = new System.Drawing.Size(112, 17);
            this.chbConnectionStrings.TabIndex = 6;
            this.chbConnectionStrings.Text = "ConnectionStrings";
            this.chbConnectionStrings.UseVisualStyleBackColor = true;
            // 
            // btnDesenriptar
            // 
            this.btnDesenriptar.Location = new System.Drawing.Point(438, 131);
            this.btnDesenriptar.Name = "btnDesenriptar";
            this.btnDesenriptar.Size = new System.Drawing.Size(75, 23);
            this.btnDesenriptar.TabIndex = 5;
            this.btnDesenriptar.Text = "Desencriptar";
            this.btnDesenriptar.UseVisualStyleBackColor = true;
            this.btnDesenriptar.Click += new System.EventHandler(this.btnDesenriptar_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(520, 131);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 4;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta:";
            // 
            // btnWebConfig
            // 
            this.btnWebConfig.Location = new System.Drawing.Point(520, 16);
            this.btnWebConfig.Name = "btnWebConfig";
            this.btnWebConfig.Size = new System.Drawing.Size(75, 23);
            this.btnWebConfig.TabIndex = 2;
            this.btnWebConfig.Text = "Web Config";
            this.btnWebConfig.UseVisualStyleBackColor = true;
            this.btnWebConfig.Click += new System.EventHandler(this.btnWebConfig_Click);
            // 
            // txtPathWebConfig
            // 
            this.txtPathWebConfig.Location = new System.Drawing.Point(77, 18);
            this.txtPathWebConfig.Name = "txtPathWebConfig";
            this.txtPathWebConfig.Size = new System.Drawing.Size(436, 20);
            this.txtPathWebConfig.TabIndex = 1;
            // 
            // importarRSAKeyContainerToolStripMenuItem
            // 
            this.importarRSAKeyContainerToolStripMenuItem.Name = "importarRSAKeyContainerToolStripMenuItem";
            this.importarRSAKeyContainerToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.importarRSAKeyContainerToolStripMenuItem.Text = "Importar RSAKeyContainer";
            this.importarRSAKeyContainerToolStripMenuItem.Click += new System.EventHandler(this.importarRSAKeyContainerToolStripMenuItem_Click);
            // 
            // eliminarRSAKeyContainerToolStripMenuItem
            // 
            this.eliminarRSAKeyContainerToolStripMenuItem.Name = "eliminarRSAKeyContainerToolStripMenuItem";
            this.eliminarRSAKeyContainerToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.eliminarRSAKeyContainerToolStripMenuItem.Text = "Eliminar RSAKeyContainer";
            this.eliminarRSAKeyContainerToolStripMenuItem.Click += new System.EventHandler(this.eliminarRSAKeyContainerToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 238);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearClaveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWebConfig;
        private System.Windows.Forms.TextBox txtPathWebConfig;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesenriptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbAppSettings;
        private System.Windows.Forms.CheckBox chbConnectionStrings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.ToolStripMenuItem crearRSAKeyContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarRSAKeyContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRSAKeyContainerToolStripMenuItem;
    }
}

