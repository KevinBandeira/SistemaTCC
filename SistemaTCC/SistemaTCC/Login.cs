using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SistemaTCC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String username = TbUsername.Text;
            String senha = TbSenha.Text;
            Menu menu = new Menu();
           if (username =="Arroz" && senha =="123")
            {
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario e ou senha inválidos");
            }
        }
    }
}
