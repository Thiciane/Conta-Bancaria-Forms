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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }

        private void lab_tittle_Click(object sender, EventArgs e)
        {

        }

        private void but_acessar_Click(object sender, EventArgs e)
        {
            string agencia = mask_agencia.Text;
            string nConta = tBox_conta.Text;
            string operacao = cbox_tipoConta.Text;
            string saldo = mask_saldo.Text;
            ContaBancaria pessoa = new ContaBancaria(agencia, nConta, operacao, saldo);
            /*MessageBox.Show($"{agencia} {nConta} {operacao} {saldo}");*/
            

            Opcoes opcoes = new Opcoes();
            this.Visible = false;
            opcoes.ShowDialog();
        }
    }
}
