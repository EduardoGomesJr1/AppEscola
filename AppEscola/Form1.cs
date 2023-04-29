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
    public partial class FormPrincipal : Form
    {
        //variaveis escopo global
        float n1, n2, n3, n4, media;
              

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            txtNota4.Text = string.Empty;
            labelMedia.Text = string.Empty;
            labelStatus.Text = string.Empty;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dtDate.Text = DateTime.Today.ToString();
            labelName.Text = Program.usuario;
        }

        public void resultado()
        {
            n1 = float.Parse(txtNota1.Text);
            n2 = float.Parse(txtNota2.Text);
            n3 = float.Parse(txtNota3.Text);
            n4 = float.Parse(txtNota4.Text);

            media = (n1 + n2 + n3 + n4) / 4;

            labelMedia.Text = media.ToString();
        }

        public void mediaAluno()
        {
            if(media >= 7)
            {
                labelStatus.Text = "Aprovado(a)";
            } 
            else
            {
                labelStatus.Text = "Reprovado";
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            resultado();
            mediaAluno();
        }

        
    }
}
