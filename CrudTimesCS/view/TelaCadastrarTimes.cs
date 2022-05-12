﻿using System;
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
            times.NomeTimes = textBox1.Text;
            times.FrasesTimes = textBox2.Text;
            times.LogoTimes = "c:/";

            ManipulaTimes manipulaTimes = new ManipulaTimes();
            manipulaTimes.cadastroTimes();

        }
        public void abrirCadastro()
        {
            this.ShowDialog();
        }

        public void fecharCadastro()
        {
            this.ShowDialog();  
        }
    }
}
