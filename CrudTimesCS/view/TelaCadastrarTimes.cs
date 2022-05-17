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
    public partial class TelaCadastrarTimes : Form
    {
        public TelaCadastrarTimes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Digite todas as informações", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            times.NomeTimes = textBox1.Text;
            times.FrasesTimes = textBox2.Text;
            MemoryStream memoriaLogo = new MemoryStream();
            pictureBoxLogo.Image.Save(memoriaLogo, pictureBoxLogo.Image.RawFormat);
            times.LogoTimes = memoriaLogo.ToArray();

            ManipulaTimes manipulaTimes = new ManipulaTimes();
            manipulaTimes.cadastroTimes();

        }
        public void abrirCadastro()
        {
            this.ShowDialog();
        }

        public void fecharCadastro()
        {
            this.Close();  
        }

        public void limparTela()
        {
            foreach(Control ctl in this.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void TelaCadastrarTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                fecharCadastro();
            }
            
        }

        private void btnbuscarlogo_Click(object sender, EventArgs e)
        {
            openFileDialogLogo.Filter = "Escolha seu logo (*.jpeg; *.jpg; *.png; ) | *.jpeg; *.jpg; *.png;";
            if (openFileDialogLogo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialogLogo.FileName);
            }
        }
    }
}
