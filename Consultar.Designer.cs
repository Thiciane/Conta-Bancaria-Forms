namespace ContaBancaria_Forms
{
    partial class Consultar
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
            this.lab_ConsultarAgencia = new System.Windows.Forms.Label();
            this.lab_consultarConta = new System.Windows.Forms.Label();
            this.lab_consultarOperacao = new System.Windows.Forms.Label();
            this.lab_consultarSaldo = new System.Windows.Forms.Label();
            this.lab_tittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_ConsultarAgencia
            // 
            this.lab_ConsultarAgencia.AutoSize = true;
            this.lab_ConsultarAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ConsultarAgencia.Location = new System.Drawing.Point(76, 101);
            this.lab_ConsultarAgencia.Name = "lab_ConsultarAgencia";
            this.lab_ConsultarAgencia.Size = new System.Drawing.Size(57, 20);
            this.lab_ConsultarAgencia.TabIndex = 0;
            this.lab_ConsultarAgencia.Text = "label1";
            this.lab_ConsultarAgencia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_consultarConta
            // 
            this.lab_consultarConta.AutoSize = true;
            this.lab_consultarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lab_consultarConta.Location = new System.Drawing.Point(76, 142);
            this.lab_consultarConta.Name = "lab_consultarConta";
            this.lab_consultarConta.Size = new System.Drawing.Size(57, 20);
            this.lab_consultarConta.TabIndex = 1;
            this.lab_consultarConta.Text = "label1";
            // 
            // lab_consultarOperacao
            // 
            this.lab_consultarOperacao.AutoSize = true;
            this.lab_consultarOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lab_consultarOperacao.Location = new System.Drawing.Point(76, 180);
            this.lab_consultarOperacao.Name = "lab_consultarOperacao";
            this.lab_consultarOperacao.Size = new System.Drawing.Size(57, 20);
            this.lab_consultarOperacao.TabIndex = 2;
            this.lab_consultarOperacao.Text = "label1";
            this.lab_consultarOperacao.Click += new System.EventHandler(this.lab_consultarOperacao_Click);
            // 
            // lab_consultarSaldo
            // 
            this.lab_consultarSaldo.AutoSize = true;
            this.lab_consultarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lab_consultarSaldo.Location = new System.Drawing.Point(76, 219);
            this.lab_consultarSaldo.Name = "lab_consultarSaldo";
            this.lab_consultarSaldo.Size = new System.Drawing.Size(57, 20);
            this.lab_consultarSaldo.TabIndex = 3;
            this.lab_consultarSaldo.Text = "label1";
            this.lab_consultarSaldo.Click += new System.EventHandler(this.lab_consultarSaldo_Click);
            // 
            // lab_tittle
            // 
            this.lab_tittle.AutoSize = true;
            this.lab_tittle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tittle.Location = new System.Drawing.Point(87, 29);
            this.lab_tittle.Name = "lab_tittle";
            this.lab_tittle.Size = new System.Drawing.Size(143, 32);
            this.lab_tittle.TabIndex = 4;
            this.lab_tittle.Text = "Consultar";
            this.lab_tittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.lab_tittle);
            this.Controls.Add(this.lab_consultarSaldo);
            this.Controls.Add(this.lab_consultarOperacao);
            this.Controls.Add(this.lab_consultarConta);
            this.Controls.Add(this.lab_ConsultarAgencia);
            this.Location = new System.Drawing.Point(60, 29);
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ConsultarAgencia;
        private System.Windows.Forms.Label lab_consultarConta;
        private System.Windows.Forms.Label lab_consultarOperacao;
        private System.Windows.Forms.Label lab_consultarSaldo;
        private System.Windows.Forms.Label lab_tittle;
    }
}