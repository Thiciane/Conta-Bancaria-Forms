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
    public partial class Opcoes : Form
    {
        public Opcoes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transferir transferir = new Transferir();
            this.Visible = false;
            transferir.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            this.Visible = false;
            consultar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Depositar depositar = new Depositar();
            this.Visible = false;
            depositar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sacar sacar = new Sacar();
            this.Visible = false;
            sacar.ShowDialog();
        }

        private void lab_tittle_Click(object sender, EventArgs e)
        {

        }

        private void Opcoes_Load(object sender, EventArgs e)
        {

        }
    }
}
