namespace ContaBancaria_Forms
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
            this.lab_tittle = new System.Windows.Forms.Label();
            this.cbox_tipoConta = new System.Windows.Forms.ComboBox();
            this.but_acessar = new System.Windows.Forms.Button();
            this.mask_agencia = new System.Windows.Forms.MaskedTextBox();
            this.mask_saldo = new System.Windows.Forms.MaskedTextBox();
            this.tBox_conta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_tittle
            // 
            this.lab_tittle.AutoSize = true;
            this.lab_tittle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tittle.Location = new System.Drawing.Point(60, 29);
            this.lab_tittle.Name = "lab_tittle";
            this.lab_tittle.Size = new System.Drawing.Size(216, 32);
            this.lab_tittle.TabIndex = 1;
            this.lab_tittle.Text = "Conta Bancária";
            this.lab_tittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lab_tittle.Click += new System.EventHandler(this.lab_tittle_Click);
            // 
            // cbox_tipoConta
            // 
            this.cbox_tipoConta.FormattingEnabled = true;
            this.cbox_tipoConta.Items.AddRange(new object[] {
            "POUPANÇA",
            "CORRENTE"});
            this.cbox_tipoConta.Location = new System.Drawing.Point(66, 156);
            this.cbox_tipoConta.Name = "cbox_tipoConta";
            this.cbox_tipoConta.Size = new System.Drawing.Size(199, 28);
            this.cbox_tipoConta.TabIndex = 8;
            this.cbox_tipoConta.Text = "Tipo de Conta";
            // 
            // but_acessar
            // 
            this.but_acessar.BackColor = System.Drawing.Color.LimeGreen;
            this.but_acessar.Location = new System.Drawing.Point(185, 245);
            this.but_acessar.Name = "but_acessar";
            this.but_acessar.Size = new System.Drawing.Size(80, 38);
            this.but_acessar.TabIndex = 9;
            this.but_acessar.Text = "Acessar";
            this.but_acessar.UseVisualStyleBackColor = false;
            this.but_acessar.Click += new System.EventHandler(this.but_acessar_Click);
            // 
            // mask_agencia
            // 
            this.mask_agencia.Location = new System.Drawing.Point(66, 92);
            this.mask_agencia.Name = "mask_agencia";
            this.mask_agencia.Size = new System.Drawing.Size(199, 26);
            this.mask_agencia.TabIndex = 10;
            this.mask_agencia.Text = "Agência";
            this.mask_agencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mask_saldo
            // 
            this.mask_saldo.Location = new System.Drawing.Point(66, 190);
            this.mask_saldo.Name = "mask_saldo";
            this.mask_saldo.Size = new System.Drawing.Size(199, 26);
            this.mask_saldo.TabIndex = 12;
            this.mask_saldo.Text = "Saldo";
            this.mask_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBox_conta
            // 
            this.tBox_conta.Location = new System.Drawing.Point(66, 124);
            this.tBox_conta.Name = "tBox_conta";
            this.tBox_conta.Size = new System.Drawing.Size(199, 26);
            this.tBox_conta.TabIndex = 13;
            this.tBox_conta.Text = "Conta";
            this.tBox_conta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.tBox_conta);
            this.Controls.Add(this.mask_saldo);
            this.Controls.Add(this.mask_agencia);
            this.Controls.Add(this.but_acessar);
            this.Controls.Add(this.cbox_tipoConta);
            this.Controls.Add(this.lab_tittle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Bancária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_tittle;
        private System.Windows.Forms.ComboBox cbox_tipoConta;
        private System.Windows.Forms.Button but_acessar;
        private System.Windows.Forms.MaskedTextBox mask_agencia;
        private System.Windows.Forms.MaskedTextBox mask_saldo;
        private System.Windows.Forms.TextBox tBox_conta;
    }
}

