namespace AirSystem.Views
{
    partial class frmCadastroUsuario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxNendereco = new AirSystem.MarkedWaterTextBox();
            this.tbxSenha = new AirSystem.MarkedWaterTextBox();
            this.tbxConfirmarSenha = new AirSystem.MarkedWaterTextBox();
            this.tbxUsuario = new AirSystem.MarkedWaterTextBox();
            this.tbxEndereco = new AirSystem.MarkedWaterTextBox();
            this.tbxSobrenome = new AirSystem.MarkedWaterTextBox();
            this.tbxNome = new AirSystem.MarkedWaterTextBox();
            this.markedWaterTextBox1 = new AirSystem.MarkedWaterTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(41, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(41, 71);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 19);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(41, 138);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(88, 19);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(42, 249);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 19);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(41, 194);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 19);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(42, 302);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(114, 19);
            this.lblConfirmarSenha.TabIndex = 5;
            this.lblConfirmarSenha.Text = "Confirma Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(503, 211);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(156, 43);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "";
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(145, 138);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(145, 21);
            this.dtpNascimento.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxNendereco);
            this.panel1.Controls.Add(this.tbxSenha);
            this.panel1.Controls.Add(this.tbxConfirmarSenha);
            this.panel1.Controls.Add(this.tbxUsuario);
            this.panel1.Controls.Add(this.lblNascimento);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.dtpNascimento);
            this.panel1.Controls.Add(this.lblConfirmarSenha);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 26;
            // 
            // tbxNendereco
            // 
            this.tbxNendereco.ForeColor = System.Drawing.Color.Gray;
            this.tbxNendereco.Location = new System.Drawing.Point(156, 94);
            this.tbxNendereco.Name = "tbxNendereco";
            this.tbxNendereco.Size = new System.Drawing.Size(91, 20);
            this.tbxNendereco.TabIndex = 22;
            this.tbxNendereco.Text = "N°";
            this.tbxNendereco.WaterMarkText = "N°";
            // 
            // tbxSenha
            // 
            this.tbxSenha.ForeColor = System.Drawing.Color.Gray;
            this.tbxSenha.Location = new System.Drawing.Point(118, 248);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(145, 20);
            this.tbxSenha.TabIndex = 24;
            this.tbxSenha.Text = "Insira sua senha";
            this.tbxSenha.WaterMarkText = "Insira sua senha";
            // 
            // tbxConfirmarSenha
            // 
            this.tbxConfirmarSenha.ForeColor = System.Drawing.Color.Gray;
            this.tbxConfirmarSenha.Location = new System.Drawing.Point(193, 301);
            this.tbxConfirmarSenha.Name = "tbxConfirmarSenha";
            this.tbxConfirmarSenha.Size = new System.Drawing.Size(145, 20);
            this.tbxConfirmarSenha.TabIndex = 25;
            this.tbxConfirmarSenha.Text = "Confirme sua senha";
            this.tbxConfirmarSenha.WaterMarkText = "Confirme sua senha";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.ForeColor = System.Drawing.Color.Gray;
            this.tbxUsuario.Location = new System.Drawing.Point(130, 194);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(145, 20);
            this.tbxUsuario.TabIndex = 23;
            this.tbxUsuario.Text = "Insira seu usuario";
            this.tbxUsuario.WaterMarkText = "Insira seu usuario";
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.ForeColor = System.Drawing.Color.Gray;
            this.tbxEndereco.Location = new System.Drawing.Point(156, 68);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(230, 20);
            this.tbxEndereco.TabIndex = 21;
            this.tbxEndereco.Text = "Digite seu endereço";
            this.tbxEndereco.WaterMarkText = "Digite seu endereço";
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.ForeColor = System.Drawing.Color.Gray;
            this.tbxSobrenome.Location = new System.Drawing.Point(307, 30);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(145, 20);
            this.tbxSobrenome.TabIndex = 20;
            this.tbxSobrenome.Text = "Digite seu sobrenome";
            this.tbxSobrenome.WaterMarkText = "Digite seu sobrenome";
            // 
            // tbxNome
            // 
            this.tbxNome.ForeColor = System.Drawing.Color.Gray;
            this.tbxNome.Location = new System.Drawing.Point(156, 30);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(145, 20);
            this.tbxNome.TabIndex = 19;
            this.tbxNome.Text = "Digite seu nome";
            this.tbxNome.WaterMarkText = "Digite seu nome";
            // 
            // markedWaterTextBox1
            // 
            this.markedWaterTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.markedWaterTextBox1.Location = new System.Drawing.Point(169, 218);
            this.markedWaterTextBox1.Name = "markedWaterTextBox1";
            this.markedWaterTextBox1.Size = new System.Drawing.Size(145, 20);
            this.markedWaterTextBox1.TabIndex = 23;
            this.markedWaterTextBox1.WaterMarkText = null;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCadastroUsuario";
            this.Text = "Cadastro Usuário - AirSystem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private MarkedWaterTextBox tbxNome;
        private MarkedWaterTextBox tbxSobrenome;
        private MarkedWaterTextBox tbxEndereco;
        private MarkedWaterTextBox tbxNendereco;
        private MarkedWaterTextBox tbxUsuario;
        private MarkedWaterTextBox markedWaterTextBox1;
        private MarkedWaterTextBox tbxSenha;
        private MarkedWaterTextBox tbxConfirmarSenha;
        private System.Windows.Forms.Panel panel1;
    }
}