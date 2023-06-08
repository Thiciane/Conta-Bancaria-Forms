namespace ContaBancaria_Forms
{
    partial class Transferir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_acessar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_valor = new System.Windows.Forms.TextBox();
            this.lab_tittle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_banco = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // but_acessar
            // 
            this.but_acessar.BackColor = System.Drawing.Color.LimeGreen;
            this.but_acessar.Location = new System.Drawing.Point(184, 242);
            this.but_acessar.Name = "but_acessar";
            this.but_acessar.Size = new System.Drawing.Size(80, 38);
            this.but_acessar.TabIndex = 14;
            this.but_acessar.Text = "Acessar";
            this.but_acessar.UseVisualStyleBackColor = false;
            this.but_acessar.Click += new System.EventHandler(this.but_acessar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Valor que deseja transferir\r\n:";
            // 
            // tBox_valor
            // 
            this.tBox_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_valor.Location = new System.Drawing.Point(80, 132);
            this.tBox_valor.Name = "tBox_valor";
            this.tBox_valor.Size = new System.Drawing.Size(164, 26);
            this.tBox_valor.TabIndex = 12;
            this.tBox_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_tittle
            // 
            this.lab_tittle.AutoSize = true;
            this.lab_tittle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tittle.Location = new System.Drawing.Point(89, 26);
            this.lab_tittle.Name = "lab_tittle";
            this.lab_tittle.Size = new System.Drawing.Size(143, 32);
            this.lab_tittle.TabIndex = 11;
            this.lab_tittle.Text = "Transferir";
            this.lab_tittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(77, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selecione o Banco:";
            // 
            // cBox_banco
            // 
            this.cBox_banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.cBox_banco.FormattingEnabled = true;
            this.cBox_banco.Items.AddRange(new object[] {
            "001 BANCO DO BRASIL S.A",
            "237 BRADESCO",
            "104 CAIXA ECONÔMICA FEDERAL",
            "341 ITAÚ UNIBANCO",
            "033 SANTANDER",
            "069 BANCO CREFISA S.A"});
            this.cBox_banco.Location = new System.Drawing.Point(61, 201);
            this.cBox_banco.Name = "cBox_banco";
            this.cBox_banco.Size = new System.Drawing.Size(203, 26);
            this.cBox_banco.TabIndex = 17;
            // 
            // Transferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.cBox_banco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_acessar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_valor);
            this.Controls.Add(this.lab_tittle);
            this.Name = "Transferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_acessar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_valor;
        private System.Windows.Forms.Label lab_tittle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBox_banco;
    }
}