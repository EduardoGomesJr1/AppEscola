using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                MessageBox.Show("Digite o nome de usuário");
                return;
            }
            if(txtSenha.Text != "123")
            {
                MessageBox.Show("Digite a senha correta!");
                return;
            }

            Program.usuario = txtUsuario.Text;


            FormPrincipal formMain = new FormPrincipal();
            formMain.ShowDialog();

            this.Hide();
            this.Close();
        }
    }
}
