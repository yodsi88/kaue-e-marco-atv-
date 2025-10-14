using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CepApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            DesabilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario = txtUsuario.Text;
            senha = Convert.ToInt32(txtSenha.Text);

            if (usuario == "admin" & senha == 123)
            {
                frmCEP abrir = new frmCEP();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Usuário ou senha Incorretos!");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void DesabilitarCampos()
        {
           txtUsuario.Enabled= false;
            txtSenha.Enabled= false;

        }
        private void HabilitarCampos()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }
    }
}
