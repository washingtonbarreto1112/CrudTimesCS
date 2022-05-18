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
    }
}
