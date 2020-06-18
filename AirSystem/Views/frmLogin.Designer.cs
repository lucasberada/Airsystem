using System;

namespace AirSystem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbxIdioma = new System.Windows.Forms.ComboBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.tbxSenha = new AirSystem.MarkedWaterTextBox();
            this.tbxUsuario = new AirSystem.MarkedWaterTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Location = new System.Drawing.Point(328, 114);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(328, 147);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 19);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(372, 188);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(56, 19);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Text = "Idioma";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(393, 237);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbxIdioma
            // 
            this.cbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdioma.FormattingEnabled = true;
            this.cbxIdioma.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.cbxIdioma.Location = new System.Drawing.Point(448, 186);
            this.cbxIdioma.Name = "cbxIdioma";
            this.cbxIdioma.Size = new System.Drawing.Size(158, 21);
            this.cbxIdioma.TabIndex = 9;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblLogo.Location = new System.Drawing.Point(150, 132);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(146, 34);
            this.lblLogo.TabIndex = 11;
            this.lblLogo.Text = "AirSystem";
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Location = new System.Drawing.Point(591, 280);
            this.lblRelogio.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblRelogio.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(33, 13);
            this.lblRelogio.TabIndex = 15;
            this.lblRelogio.Text = "Timer";
            this.lblRelogio.Click += new System.EventHandler(this.lblRelogio_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.ForeColor = System.Drawing.Color.Gray;
            this.tbxSenha.Location = new System.Drawing.Point(393, 146);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(158, 20);
            this.tbxSenha.TabIndex = 14;
            this.tbxSenha.Text = "Digite sua senha";
            this.tbxSenha.WaterMarkText = "Digite sua senha";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.ForeColor = System.Drawing.Color.Gray;
            this.tbxUsuario.Location = new System.Drawing.Point(393, 113);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(158, 20);
            this.tbxUsuario.TabIndex = 13;
            this.tbxUsuario.Text = "Digite seu usuario";
            this.tbxUsuario.WaterMarkText = "Digite seu usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "professora sei que esta muito inconpleto , mas foi oq eu conswegui fazer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRelogio);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.cbxIdioma);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Form1";
            this.Text = "Login - AtirSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbxIdioma;
        private System.Windows.Forms.Label lblLogo;
        private MarkedWaterTextBox tbxUsuario;
        private MarkedWaterTextBox tbxSenha;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Label label1;
    }
}

