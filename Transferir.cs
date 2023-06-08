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
    public partial class Transferir : Form
    {
        public Transferir()
        {
            InitializeComponent();
        }

        private void but_acessar_Click(object sender, EventArgs e)
        {
            string valor = tBox_valor.Text;
            string banco = cBox_banco.Text;
            string transferencia = ContaBancaria.Transferir(valor);
            MessageBox.Show($"Transferência feito com sucesso para {banco}!\nSaldo: {transferencia}");
        }
    }
}
