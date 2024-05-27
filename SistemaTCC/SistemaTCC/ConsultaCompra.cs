using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTCC
{
    public partial class ConsultaCompra : Form
    {
        public ConsultaCompra()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            CadastraClientes cadCli = new CadastraClientes();
            cadCli.Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            CadastraProdutos cadProd = new CadastraProdutos();
            cadProd.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            CadastraFuncionario cadFunc = new CadastraFuncionario();
            cadFunc.Show();
            this.Hide();
        }
    }
}
