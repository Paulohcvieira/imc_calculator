namespace UC11_imc_pp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPESO = new System.Windows.Forms.TextBox();
            this.textBoxALTURA = new System.Windows.Forms.TextBox();
            this.labelPESO = new System.Windows.Forms.Label();
            this.labelALTURA = new System.Windows.Forms.Label();
            this.buttonCALCULAR = new System.Windows.Forms.Button();
            this.labelRESULTADO = new System.Windows.Forms.Label();
            this.labelIMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPESO
            // 
            this.textBoxPESO.Location = new System.Drawing.Point(328, 126);
            this.textBoxPESO.Name = "textBoxPESO";
            this.textBoxPESO.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESO.TabIndex = 0;
            this.textBoxPESO.TextChanged += new System.EventHandler(this.textBoxPESO_TextChanged);
            // 
            // textBoxALTURA
            // 
            this.textBoxALTURA.Location = new System.Drawing.Point(328, 177);
            this.textBoxALTURA.Name = "textBoxALTURA";
            this.textBoxALTURA.Size = new System.Drawing.Size(100, 20);
            this.textBoxALTURA.TabIndex = 1;
            // 
            // labelPESO
            // 
            this.labelPESO.AutoSize = true;
            this.labelPESO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPESO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPESO.Location = new System.Drawing.Point(259, 120);
            this.labelPESO.Name = "labelPESO";
            this.labelPESO.Size = new System.Drawing.Size(63, 25);
            this.labelPESO.TabIndex = 2;
            this.labelPESO.Text = "Peso:";
            // 
            // labelALTURA
            // 
            this.labelALTURA.AutoSize = true;
            this.labelALTURA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelALTURA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelALTURA.Location = new System.Drawing.Point(253, 172);
            this.labelALTURA.Name = "labelALTURA";
            this.labelALTURA.Size = new System.Drawing.Size(69, 25);
            this.labelALTURA.TabIndex = 3;
            this.labelALTURA.Text = "Altura:";
            // 
            // buttonCALCULAR
            // 
            this.buttonCALCULAR.Location = new System.Drawing.Point(328, 291);
            this.buttonCALCULAR.Name = "buttonCALCULAR";
            this.buttonCALCULAR.Size = new System.Drawing.Size(100, 55);
            this.buttonCALCULAR.TabIndex = 4;
            this.buttonCALCULAR.Text = "Calcular";
            this.buttonCALCULAR.UseVisualStyleBackColor = true;
            this.buttonCALCULAR.Click += new System.EventHandler(this.buttonCALCULAR_Click);
            // 
            // labelRESULTADO
            // 
            this.labelRESULTADO.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelRESULTADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRESULTADO.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelRESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRESULTADO.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.labelRESULTADO.Location = new System.Drawing.Point(300, 219);
            this.labelRESULTADO.Name = "labelRESULTADO";
            this.labelRESULTADO.Size = new System.Drawing.Size(152, 38);
            this.labelRESULTADO.TabIndex = 5;
            this.labelRESULTADO.Text = "Resultado";
            this.labelRESULTADO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRESULTADO.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelIMC
            // 
            this.labelIMC.BackColor = System.Drawing.Color.SpringGreen;
            this.labelIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIMC.Location = new System.Drawing.Point(521, 218);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(267, 76);
            this.labelIMC.TabIndex = 7;
            this.labelIMC.Text = "Tipo de Peso";
            this.labelIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIMC.Click += new System.EventHandler(this.labelIMC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.labelRESULTADO);
            this.Controls.Add(this.buttonCALCULAR);
            this.Controls.Add(this.labelALTURA);
            this.Controls.Add(this.labelPESO);
            this.Controls.Add(this.textBoxALTURA);
            this.Controls.Add(this.textBoxPESO);
            this.Name = "Form1";
            this.Text = "IMC Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPESO;
        private System.Windows.Forms.TextBox textBoxALTURA;
        private System.Windows.Forms.Label labelPESO;
        private System.Windows.Forms.Label labelALTURA;
        private System.Windows.Forms.Button buttonCALCULAR;
        private System.Windows.Forms.Label labelRESULTADO;
        private System.Windows.Forms.Label labelIMC;
    }
}

