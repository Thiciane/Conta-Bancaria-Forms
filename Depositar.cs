using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria_Forms
{
    public partial class Depositar : Form
    {
        public Depositar()
        {
            InitializeComponent();
            
        }

        private void tBox_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_acessar_Click(object sender, EventArgs e)
        {
            string valor = tBox_valor.Text;
            string deposito = ContaBancaria.Depositar(valor);
            MessageBox.Show($"Deposito feito com sucesso!\nSaldo: {deposito}");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lab_tittle_Click(object sender, EventArgs e)
        {

        }
    }
}
