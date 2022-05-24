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
using System.IO;

namespace CrudTimesCS.view
{
    public partial class TelaPesquisarJogadores : Form
    {
        public TelaPesquisarJogadores()
        {
            InitializeComponent();
        }

        private void btnbuscarjogador_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxcodigojogador.Text == "")
                {
                    MessageBox.Show("Digite um Código Válido");
                    return;
                }
                else
                {
                    jogadores.CodJogadores = Convert.ToInt32(tbxcodigojogador.Text);
                }

                ManipulaJogadores manipula = new ManipulaJogadores();
                manipula.pesquisarCodigoJogadores();

                tbxcodigojogador.Text = jogadores.CodJogadores.ToString();
                tbxnomejogador.Text = jogadores.NomeJogadores;
                tbxemailjogador.Text = jogadores.EmailJogadores;
                tbxfonejogador.Text = jogadores.FoneJogadores;

            }
            catch (Exception)
            {

                
            }
        }

        private void btnDeletarJogador_Click(object sender, EventArgs e)
        {


            if (tbxcodigojogador.Text == "")
            {
                MessageBox.Show("Digite um código válido!");
            }

            var resposta = MessageBox.Show("Deseja excluir o jogador " + tbxcodigojogador.Text + " ?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (resposta == DialogResult.Yes)
            {
                jogadores.CodJogadores = Convert.ToInt32(tbxcodigojogador.Text);

                ManipulaJogadores manipulaJogadores = new ManipulaJogadores();
                manipulaJogadores.deletarJogadores();
            }

            tbxnomejogador.Text = string.Empty;
            tbxemailjogador.Text = string.Empty;
            tbxfonejogador.Text = string.Empty;
                  
        }

        private void btnSalvarAltJogador_Click(object sender, EventArgs e)
        {
            if (tbxnomejogador.Text == "")
            {
                MessageBox.Show("Digite um Código Válido", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tbxnomejogador.Text = string.Empty;
                tbxemailjogador.Text = string.Empty;
                tbxfonejogador.Text = string.Empty;
                return;

            }

            var resposta = MessageBox.Show("Deseja salvar as alterações nos dados do jogador de código " + tbxcodigojogador.Text + " ?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                jogadores.NomeJogadores = tbxnomejogador.Text;
                jogadores.EmailJogadores = tbxemailjogador.Text;
                jogadores.FoneJogadores = tbxfonejogador.Text;

                ManipulaJogadores manipulaJogadores = new ManipulaJogadores();
                manipulaJogadores.alterarJogadores();

            }
        }
    }
}
