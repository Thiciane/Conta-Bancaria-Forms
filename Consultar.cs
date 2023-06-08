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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();

            (string agencia, string nConta, string operacao, string saldo) = ContaBancaria.Consultar();
            lab_ConsultarAgencia.Text = $"Agência: {agencia}";
            lab_consultarConta.Text = $"N° da Conta: {nConta}";
            lab_consultarOperacao.Text = $"Operação: {operacao}";
            lab_consultarSaldo.Text = $"Saldo: {saldo}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lab_consultarOperacao_Click(object sender, EventArgs e)
        {

        }

        private void lab_consultarSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
