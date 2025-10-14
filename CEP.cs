using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosaicoSolutions.ViaCep;

namespace CepApp
{
    public partial class frmCEP : Form
    {
        public frmCEP()
        {
            InitializeComponent();
            DesabilitarCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }
        private void DesabilitarCampos()
        {
            mskCep.Enabled = false;
            txtLongradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            cbbEstado.Enabled = false;
            cbbUF.Enabled = false;
            txtBairro.Enabled = false;
            mskNome.Enabled = false;
            mskRG.Enabled = false;
            mskCPF.Enabled = false;

        }
        private void HabilitarCampos()
        {
            mskCep.Enabled = true;
            txtLongradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            cbbUF.Enabled = true;
            txtBairro.Enabled = true;
            mskNome.Enabled = true;
            mskRG.Enabled = true;
            mskCPF.Enabled = true;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.ResetText();
            txtCidade.ResetText();
            txtComplemento.ResetText ();
            txtNumero.ResetText();
            txtLongradouro.ResetText ();
            cbbEstado.ResetText();
            cbbUF.ResetText();
            mskCep.ResetText();
            mskNome.ResetText();
            mskRG.ResetText ();
            mskCPF.ResetText();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            var endereco = viaCEPService.ObterEndereco(cep);

            txtLongradouro.Text = endereco.Logradouro;
            txtCidade.Text = endereco.Localidade;
            cbbEstado.Text = endereco.UF;
            cbbUF.Text = endereco.UF;
            txtComplemento.Text = endereco.Complemento;
            txtBairro.Text = endereco.Bairro;
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarCEP(mskCep.Text);
                txtNumero.Focus();
            }
        }
    }
}
