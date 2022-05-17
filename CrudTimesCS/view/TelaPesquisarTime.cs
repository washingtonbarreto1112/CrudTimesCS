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
                times.CodTimes = Convert.ToInt32(textBox1.Text);

                ManipulaTimes manipula = new ManipulaTimes();
                manipula.pesquisarCodigoTimes();

                if(times.CodTimes == Convert.ToInt32(textBox1.Text))
                {
                    textBox4.Text = times.CodTimes.ToString();
                    textBox2.Text = times.FrasesTimes;
                    textBox3.Text = times.NomeTimes;
                    pictureBoxLogo.Image = Image.FromFile(times.LogoTimes.ToString());
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
