namespace AgenciaDeTurismo
{
    partial class frmCadastroCliente
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNacioCliente = new System.Windows.Forms.Label();
            this.mskDataNascCli = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascCli = new System.Windows.Forms.Label();
            this.mskTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.mskCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.btnVoltarCli = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCadastrarCli = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.lblNacioCliente);
            this.panel2.Controls.Add(this.mskDataNascCli);
            this.panel2.Controls.Add(this.lblDataNascCli);
            this.panel2.Controls.Add(this.mskTelefoneCliente);
            this.panel2.Controls.Add(this.lblEmailCliente);
            this.panel2.Controls.Add(this.mskCpfCliente);
            this.panel2.Controls.Add(this.lblTelefoneCliente);
            this.panel2.Controls.Add(this.txtNacionalidade);
            this.panel2.Controls.Add(this.txtNomeCliente);
            this.panel2.Controls.Add(this.txtEmailCliente);
            this.panel2.Controls.Add(this.lblCpfCliente);
            this.panel2.Controls.Add(this.lblNomeCliente);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-6, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 283);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblNacioCliente
            // 
            this.lblNacioCliente.AutoSize = true;
            this.lblNacioCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacioCliente.ForeColor = System.Drawing.Color.White;
            this.lblNacioCliente.Location = new System.Drawing.Point(49, 186);
            this.lblNacioCliente.Name = "lblNacioCliente";
            this.lblNacioCliente.Size = new System.Drawing.Size(130, 21);
            this.lblNacioCliente.TabIndex = 17;
            this.lblNacioCliente.Text = "Nacionalidade:";
            // 
            // mskDataNascCli
            // 
            this.mskDataNascCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskDataNascCli.Location = new System.Drawing.Point(181, 73);
            this.mskDataNascCli.Mask = "00/00/0000";
            this.mskDataNascCli.Name = "mskDataNascCli";
            this.mskDataNascCli.Size = new System.Drawing.Size(100, 21);
            this.mskDataNascCli.TabIndex = 13;
            this.mskDataNascCli.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDataNascCli_MaskInputRejected);
            // 
            // lblDataNascCli
            // 
            this.lblDataNascCli.AutoSize = true;
            this.lblDataNascCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascCli.ForeColor = System.Drawing.Color.White;
            this.lblDataNascCli.Location = new System.Drawing.Point(48, 62);
            this.lblDataNascCli.Name = "lblDataNascCli";
            this.lblDataNascCli.Size = new System.Drawing.Size(106, 42);
            this.lblDataNascCli.TabIndex = 12;
            this.lblDataNascCli.Text = "Data de \r\nnascimento:";
            // 
            // mskTelefoneCliente
            // 
            this.mskTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskTelefoneCliente.Location = new System.Drawing.Point(181, 147);
            this.mskTelefoneCliente.Mask = "(00)00000-0000";
            this.mskTelefoneCliente.Name = "mskTelefoneCliente";
            this.mskTelefoneCliente.Size = new System.Drawing.Size(100, 21);
            this.mskTelefoneCliente.TabIndex = 11;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.ForeColor = System.Drawing.Color.White;
            this.lblEmailCliente.Location = new System.Drawing.Point(48, 110);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(55, 21);
            this.lblEmailCliente.TabIndex = 2;
            this.lblEmailCliente.Text = "Email:";
            // 
            // mskCpfCliente
            // 
            this.mskCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskCpfCliente.Location = new System.Drawing.Point(181, 224);
            this.mskCpfCliente.Mask = "000.000.000-00";
            this.mskCpfCliente.Name = "mskCpfCliente";
            this.mskCpfCliente.Size = new System.Drawing.Size(100, 21);
            this.mskCpfCliente.TabIndex = 10;
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.ForeColor = System.Drawing.Color.White;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(48, 146);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(80, 21);
            this.lblTelefoneCliente.TabIndex = 3;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNacionalidade.Location = new System.Drawing.Point(181, 185);
            this.txtNacionalidade.MaxLength = 20;
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(100, 21);
            this.txtNacionalidade.TabIndex = 7;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNomeCliente.Location = new System.Drawing.Point(181, 25);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 21);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmailCliente.Location = new System.Drawing.Point(181, 111);
            this.txtEmailCliente.MaxLength = 150;
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(100, 21);
            this.txtEmailCliente.TabIndex = 6;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCliente.ForeColor = System.Drawing.Color.White;
            this.lblCpfCliente.Location = new System.Drawing.Point(48, 223);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(44, 21);
            this.lblCpfCliente.TabIndex = 4;
            this.lblCpfCliente.Text = "CPF:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(49, 24);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(61, 21);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // btnVoltarCli
            // 
            this.btnVoltarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnVoltarCli.FlatAppearance.BorderSize = 0;
            this.btnVoltarCli.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVoltarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoltarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCli.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnVoltarCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnVoltarCli.Location = new System.Drawing.Point(72, 362);
            this.btnVoltarCli.Name = "btnVoltarCli";
            this.btnVoltarCli.Size = new System.Drawing.Size(97, 25);
            this.btnVoltarCli.TabIndex = 2;
            this.btnVoltarCli.Text = "Voltar ";
            this.btnVoltarCli.UseVisualStyleBackColor = false;
            this.btnVoltarCli.Click += new System.EventHandler(this.btnVoltarCli_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(86, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cadastro  Cliente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-6, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 30);
            this.panel3.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_fechar_janela_40;
            this.button1.Location = new System.Drawing.Point(312, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_minimizar_janela_35__1_;
            this.button2.Location = new System.Drawing.Point(280, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnCadastrarCli
            // 
            this.btnCadastrarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnCadastrarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastrarCli.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCli.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCadastrarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCadastrarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCli.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastrarCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCadastrarCli.Location = new System.Drawing.Point(178, 362);
            this.btnCadastrarCli.Name = "btnCadastrarCli";
            this.btnCadastrarCli.Size = new System.Drawing.Size(97, 25);
            this.btnCadastrarCli.TabIndex = 40;
            this.btnCadastrarCli.Text = "Cadastrar";
            this.btnCadastrarCli.UseVisualStyleBackColor = false;
            this.btnCadastrarCli.Click += new System.EventHandler(this.BtnCadastrarFunc_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(349, 410);
            this.Controls.Add(this.btnCadastrarCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVoltarCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mskDataNascCli;
        private System.Windows.Forms.Label lblDataNascCli;
        private System.Windows.Forms.MaskedTextBox mskTelefoneCliente;
        private System.Windows.Forms.Button btnVoltarCli;
        private System.Windows.Forms.MaskedTextBox mskCpfCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNacioCliente;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadastrarCli;
    }
}