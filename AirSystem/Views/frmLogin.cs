using AirSystem.Views;
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

namespace AirSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }






        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxIdioma.Text))
            {
                frmCadastroUsuario frmCadastro = new frmCadastroUsuario();
                frmCadastro.Show();

            }
            else
            {
                MessageBox.Show(this, "Escolha um Idioma / Choose a language", "Confirmação", MessageBoxButtons.OK);
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você realmente quer sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void lblRelogio_Click(object sender, EventArgs e)
        {

            lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss:ff");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
