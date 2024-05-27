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
    public partial class CadastraClientes : Form
    {
        public CadastraClientes()
        {
            InitializeComponent();
        }

        private void CadastraFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            CadastraProdutos cadProd = new CadastraProdutos();
            cadProd.Show();
            this.Hide();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            CadastraFuncionario cadFunc = new CadastraFuncionario();
            cadFunc.Show();
            this.Hide();
        }
    }
}
