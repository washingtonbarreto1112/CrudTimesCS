
namespace CrudTimesCS.view
{
    partial class TelaCadastrarJogadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarJogadores));
            this.lblcadastrojogadores = new System.Windows.Forms.Label();
            this.lblnomejogadores = new System.Windows.Forms.Label();
            this.lblemailjogadores = new System.Windows.Forms.Label();
            this.lblfonejogadores = new System.Windows.Forms.Label();
            this.tbxnomejogadores = new System.Windows.Forms.TextBox();
            this.tbxemailjogadores = new System.Windows.Forms.TextBox();
            this.tbxfonejogadores = new System.Windows.Forms.TextBox();
            this.btnJogadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcadastrojogadores
            // 
            this.lblcadastrojogadores.AutoSize = true;
            this.lblcadastrojogadores.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblcadastrojogadores.ForeColor = System.Drawing.Color.Purple;
            this.lblcadastrojogadores.Location = new System.Drawing.Point(272, 51);
            this.lblcadastrojogadores.Name = "lblcadastrojogadores";
            this.lblcadastrojogadores.Size = new System.Drawing.Size(268, 25);
            this.lblcadastrojogadores.TabIndex = 0;
            this.lblcadastrojogadores.Text = "Cadastro de Jogadores";
            // 
            // lblnomejogadores
            // 
            this.lblnomejogadores.AutoSize = true;
            this.lblnomejogadores.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnomejogadores.ForeColor = System.Drawing.Color.Purple;
            this.lblnomejogadores.Location = new System.Drawing.Point(173, 113);
            this.lblnomejogadores.Name = "lblnomejogadores";
            this.lblnomejogadores.Size = new System.Drawing.Size(56, 17);
            this.lblnomejogadores.TabIndex = 1;
            this.lblnomejogadores.Text = "Nome:";
            // 
            // lblemailjogadores
            // 
            this.lblemailjogadores.AutoSize = true;
            this.lblemailjogadores.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemailjogadores.ForeColor = System.Drawing.Color.Purple;
            this.lblemailjogadores.Location = new System.Drawing.Point(172, 200);
            this.lblemailjogadores.Name = "lblemailjogadores";
            this.lblemailjogadores.Size = new System.Drawing.Size(60, 17);
            this.lblemailjogadores.TabIndex = 2;
            this.lblemailjogadores.Text = "E-mail:";
            // 
            // lblfonejogadores
            // 
            this.lblfonejogadores.AutoSize = true;
            this.lblfonejogadores.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfonejogadores.ForeColor = System.Drawing.Color.Purple;
            this.lblfonejogadores.Location = new System.Drawing.Point(172, 294);
            this.lblfonejogadores.Name = "lblfonejogadores";
            this.lblfonejogadores.Size = new System.Drawing.Size(50, 17);
            this.lblfonejogadores.TabIndex = 3;
            this.lblfonejogadores.Text = "Fone:";
            // 
            // tbxnomejogadores
            // 
            this.tbxnomejogadores.Location = new System.Drawing.Point(173, 144);
            this.tbxnomejogadores.Name = "tbxnomejogadores";
            this.tbxnomejogadores.Size = new System.Drawing.Size(499, 23);
            this.tbxnomejogadores.TabIndex = 4;
            // 
            // tbxemailjogadores
            // 
            this.tbxemailjogadores.Location = new System.Drawing.Point(172, 239);
            this.tbxemailjogadores.Name = "tbxemailjogadores";
            this.tbxemailjogadores.Size = new System.Drawing.Size(500, 23);
            this.tbxemailjogadores.TabIndex = 5;
            this.tbxemailjogadores.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxfonejogadores
            // 
            this.tbxfonejogadores.Location = new System.Drawing.Point(172, 325);
            this.tbxfonejogadores.Name = "tbxfonejogadores";
            this.tbxfonejogadores.Size = new System.Drawing.Size(251, 23);
            this.tbxfonejogadores.TabIndex = 6;
            // 
            // btnJogadores
            // 
            this.btnJogadores.BackColor = System.Drawing.Color.Pink;
            this.btnJogadores.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJogadores.ForeColor = System.Drawing.Color.Purple;
            this.btnJogadores.Location = new System.Drawing.Point(543, 311);
            this.btnJogadores.Name = "btnJogadores";
            this.btnJogadores.Size = new System.Drawing.Size(129, 37);
            this.btnJogadores.TabIndex = 7;
            this.btnJogadores.Text = "Cadastrar";
            this.btnJogadores.UseVisualStyleBackColor = false;
            // 
            // TelaCadastrarJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJogadores);
            this.Controls.Add(this.tbxfonejogadores);
            this.Controls.Add(this.tbxemailjogadores);
            this.Controls.Add(this.tbxnomejogadores);
            this.Controls.Add(this.lblfonejogadores);
            this.Controls.Add(this.lblemailjogadores);
            this.Controls.Add(this.lblnomejogadores);
            this.Controls.Add(this.lblcadastrojogadores);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarJogadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarJogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcadastrojogadores;
        private System.Windows.Forms.Label lblnomejogadores;
        private System.Windows.Forms.Label lblemailjogadores;
        private System.Windows.Forms.Label lblfonejogadores;
        private System.Windows.Forms.TextBox tbxnomejogadores;
        private System.Windows.Forms.TextBox tbxemailjogadores;
        private System.Windows.Forms.TextBox tbxfonejogadores;
        private System.Windows.Forms.Button btnJogadores;
    }
}