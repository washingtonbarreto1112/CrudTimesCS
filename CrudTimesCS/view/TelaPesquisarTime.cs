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
    public partial class TelaPesquisarTime : Form
    {
        public TelaPesquisarTime()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {   
                    MessageBox.Show("Digite um código válido");
                return;
                }
                else
                { 
                    times.CodTimes = Convert.ToInt32(textBox1.Text);
                }


                ManipulaTimes manipula = new ManipulaTimes();
                manipula.pesquisarCodigoTimes();

                              
                    textBox4.Text = times.CodTimes.ToString();
                    textBox2.Text = times.FrasesTimes;
                    textBox3.Text = times.NomeTimes;
                    MemoryStream ms = new MemoryStream((byte[])times.LogoTimes);
                    pictureBoxLogo.Image = Image.FromStream(ms);


            }
            catch (Exception)
            {
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeletarTimes_Click(object sender, EventArgs e)
        {
            

            if(textBox1.Text == "")
            {
                MessageBox.Show("Digite um Número válido!");
            }

           var resposta = MessageBox.Show("Deseja excluir o time " + textBox1.Text + " ?", 
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (resposta == DialogResult.Yes)
            {
                times.CodTimes = Convert.ToInt32(textBox1.Text);

                ManipulaTimes manipulaTimes = new ManipulaTimes();
                manipulaTimes.deletarJogadores();
            }
          
                textBox4.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox1.Text = string.Empty;
            pictureBoxLogo.Image = null;
                
            

        }

        private void btnalterartime_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Digite um Código Válido", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBox4.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox1.Text = string.Empty;
                pictureBoxLogo.Image = null;
                return;

            }

            var resposta = MessageBox.Show("Deseja fazer as alterações no time de código " + textBox4.Text + " ?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                times.CodTimes = Convert.ToInt32(textBox4.Text);
                times.NomeTimes = textBox3.Text;
                times.FrasesTimes = textBox2.Text;

                MemoryStream memoriaLogo = new MemoryStream();
                pictureBoxLogo.Image.Save(memoriaLogo, pictureBoxLogo.Image.RawFormat);
                times.LogoTimes = memoriaLogo.ToArray();

                ManipulaTimes manipulaTimes = new ManipulaTimes();
                manipulaTimes.alterarTimes();


            }
        }

        private void btnalterarimagem_Click(object sender, EventArgs e)
        {
            openFileDialogLogo.Filter = "Escolha seu logo (*.jpeg; *.jpg; *.png; ) | *.jpeg; *.jpg; *.png;";
            if (openFileDialogLogo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialogLogo.FileName);
            }
        }
    }
}
