using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudTimesCS.model;
using CrudTimesCS.controller;

namespace CrudTimesCS.view
{
    public partial class TelaCadastrarJogadores : Form
    {
        public TelaCadastrarJogadores()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnJogadores_Click(object sender, EventArgs e)
        {
            if (tbxnomejogadores.Text == "" || tbxemailjogadores.Text == "")
            {
                MessageBox.Show("Digite todas as informações", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            jogadores.NomeJogadores = tbxnomejogadores.Text;
            jogadores.EmailJogadores = tbxemailjogadores.Text;
            jogadores.FoneJogadores = tbxfonejogadores.Text;

            ManipulaJogadores manipulaJogadores = new ManipulaJogadores();
            manipulaJogadores.cadastroJogadores();


        }
        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }
        public void abrirCadastro()
        {
            this.ShowDialog();
        }

        public void fecharCadastro()
        {
            this.Close();
        }
    }
}
