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
    public partial class CadastraFuncionario : Form
    {
        public CadastraFuncionario()
        {
            InitializeComponent();
        }

        private void CadastraFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            CadastraClientes cadCli = new CadastraClientes();
            cadCli.Show();
            this.Hide();
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            CadastraProdutos cadProd = new CadastraProdutos();
            cadProd.Show();
            this.Hide();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            ConsultaCompra consulComp = new ConsultaCompra();
            consulComp.Show();
            this.Hide();
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {

        }
    }
}
