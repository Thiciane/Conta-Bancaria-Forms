namespace ContaBancaria_Forms
{
    partial class Depositar
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
            this.lab_tittle = new System.Windows.Forms.Label();
            this.tBox_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_acessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_tittle
            // 
            this.lab_tittle.AutoSize = true;
            this.lab_tittle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tittle.Location = new System.Drawing.Point(90, 29);
            this.lab_tittle.Name = "lab_tittle";
            this.lab_tittle.Size = new System.Drawing.Size(141, 32);
            this.lab_tittle.TabIndex = 2;
            this.lab_tittle.Text = "Depositar";
            this.lab_tittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lab_tittle.Click += new System.EventHandler(this.lab_tittle_Click);
            // 
            // tBox_valor
            // 
            this.tBox_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_valor.Location = new System.Drawing.Point(79, 130);
            this.tBox_valor.Name = "tBox_valor";
            this.tBox_valor.Size = new System.Drawing.Size(164, 26);
            this.tBox_valor.TabIndex = 3;
            this.tBox_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_valor.TextChanged += new System.EventHandler(this.tBox_valor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor que deseja depositar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // but_acessar
            // 
            this.but_acessar.BackColor = System.Drawing.Color.LimeGreen;
            this.but_acessar.Location = new System.Drawing.Point(185, 245);
            this.but_acessar.Name = "but_acessar";
            this.but_acessar.Size = new System.Drawing.Size(80, 38);
            this.but_acessar.TabIndex = 10;
            this.but_acessar.Text = "Acessar";
            this.but_acessar.UseVisualStyleBackColor = false;
            this.but_acessar.Click += new System.EventHandler(this.but_acessar_Click);
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.but_acessar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_valor);
            this.Controls.Add(this.lab_tittle);
            this.Name = "Depositar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_tittle;
        private System.Windows.Forms.TextBox tBox_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_acessar;
    }
}