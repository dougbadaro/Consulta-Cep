using ConsultaCep.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {

                e.Handled = true;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            AddressServices addressServices = new AddressServices();

            Address address = await addressServices.Integracao(txtCep.Text);

            if (!address.Verification)
            {
                txtRua.Text = address.Logradouro;
                txtBairro.Text = address.Bairro;
                txtCidade.Text = address.Localidade;
                txtUf.Text = address.Uf;
            }
        }
    }
}
