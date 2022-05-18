
namespace CrudTimesCS.view
{
    partial class TelaPesquisarJogadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarJogadores));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbldigitejogador = new System.Windows.Forms.Label();
            this.tbxcodigojogador = new System.Windows.Forms.TextBox();
            this.btnbuscarjogador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxemailjogador = new System.Windows.Forms.TextBox();
            this.tbxnomejogador = new System.Windows.Forms.TextBox();
            this.lblemailjogador = new System.Windows.Forms.Label();
            this.lblnomejogador = new System.Windows.Forms.Label();
            this.tbxfonejogador = new System.Windows.Forms.TextBox();
            this.lblfonejogador = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnbuscarjogador);
            this.tabPage1.Controls.Add(this.tbxcodigojogador);
            this.tabPage1.Controls.Add(this.lbldigitejogador);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa por Nome";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbldigitejogador
            // 
            this.lbldigitejogador.AutoSize = true;
            this.lbldigitejogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldigitejogador.Location = new System.Drawing.Point(37, 52);
            this.lbldigitejogador.Name = "lbldigitejogador";
            this.lbldigitejogador.Size = new System.Drawing.Size(225, 21);
            this.lbldigitejogador.TabIndex = 0;
            this.lbldigitejogador.Text = "Digite o Código do Jogador:";
            // 
            // tbxcodigojogador
            // 
            this.tbxcodigojogador.Location = new System.Drawing.Point(268, 54);
            this.tbxcodigojogador.Name = "tbxcodigojogador";
            this.tbxcodigojogador.Size = new System.Drawing.Size(166, 23);
            this.tbxcodigojogador.TabIndex = 1;
            // 
            // btnbuscarjogador
            // 
            this.btnbuscarjogador.Location = new System.Drawing.Point(477, 49);
            this.btnbuscarjogador.Name = "btnbuscarjogador";
            this.btnbuscarjogador.Size = new System.Drawing.Size(118, 31);
            this.btnbuscarjogador.TabIndex = 2;
            this.btnbuscarjogador.Text = "Buscar";
            this.btnbuscarjogador.UseVisualStyleBackColor = true;
            this.btnbuscarjogador.Click += new System.EventHandler(this.btnbuscarjogador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxfonejogador);
            this.groupBox1.Controls.Add(this.lblfonejogador);
            this.groupBox1.Controls.Add(this.tbxemailjogador);
            this.groupBox1.Controls.Add(this.tbxnomejogador);
            this.groupBox1.Controls.Add(this.lblemailjogador);
            this.groupBox1.Controls.Add(this.lblnomejogador);
            this.groupBox1.Location = new System.Drawing.Point(37, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // tbxemailjogador
            // 
            this.tbxemailjogador.Location = new System.Drawing.Point(17, 118);
            this.tbxemailjogador.Name = "tbxemailjogador";
            this.tbxemailjogador.Size = new System.Drawing.Size(465, 23);
            this.tbxemailjogador.TabIndex = 12;
            // 
            // tbxnomejogador
            // 
            this.tbxnomejogador.Location = new System.Drawing.Point(17, 57);
            this.tbxnomejogador.Name = "tbxnomejogador";
            this.tbxnomejogador.Size = new System.Drawing.Size(465, 23);
            this.tbxnomejogador.TabIndex = 11;
            // 
            // lblemailjogador
            // 
            this.lblemailjogador.AutoSize = true;
            this.lblemailjogador.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemailjogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblemailjogador.Location = new System.Drawing.Point(17, 100);
            this.lblemailjogador.Name = "lblemailjogador";
            this.lblemailjogador.Size = new System.Drawing.Size(48, 16);
            this.lblemailjogador.TabIndex = 10;
            this.lblemailjogador.Text = "E-mail";
            // 
            // lblnomejogador
            // 
            this.lblnomejogador.AutoSize = true;
            this.lblnomejogador.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnomejogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblnomejogador.Location = new System.Drawing.Point(17, 39);
            this.lblnomejogador.Name = "lblnomejogador";
            this.lblnomejogador.Size = new System.Drawing.Size(46, 16);
            this.lblnomejogador.TabIndex = 9;
            this.lblnomejogador.Text = "Nome:";
            // 
            // tbxfonejogador
            // 
            this.tbxfonejogador.Location = new System.Drawing.Point(17, 184);
            this.tbxfonejogador.Name = "tbxfonejogador";
            this.tbxfonejogador.Size = new System.Drawing.Size(292, 23);
            this.tbxfonejogador.TabIndex = 14;
            // 
            // lblfonejogador
            // 
            this.lblfonejogador.AutoSize = true;
            this.lblfonejogador.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfonejogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblfonejogador.Location = new System.Drawing.Point(17, 166);
            this.lblfonejogador.Name = "lblfonejogador";
            this.lblfonejogador.Size = new System.Drawing.Size(43, 16);
            this.lblfonejogador.TabIndex = 13;
            this.lblfonejogador.Text = "Fone:";
            // 
            // TelaPesquisarJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaPesquisarJogadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Jogos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnbuscarjogador;
        private System.Windows.Forms.TextBox tbxcodigojogador;
        private System.Windows.Forms.Label lbldigitejogador;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxemailjogador;
        private System.Windows.Forms.TextBox tbxnomejogador;
        private System.Windows.Forms.Label lblemailjogador;
        private System.Windows.Forms.Label lblnomejogador;
        private System.Windows.Forms.TextBox tbxfonejogador;
        private System.Windows.Forms.Label lblfonejogador;
    }
}