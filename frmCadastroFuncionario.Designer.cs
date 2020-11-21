namespace AgenciaDeTurismo
{
    partial class frmCadastroFuncionario
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.mskTelefoneFunc = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltarFunc = new System.Windows.Forms.Button();
            this.mskCpfFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.lblCpfFunc = new System.Windows.Forms.Label();
            this.lblTelefoneFunc = new System.Windows.Forms.Label();
            this.lblEmailFunc = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cadastro Funcionário";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.btnCadastrarFunc);
            this.panel2.Controls.Add(this.mskTelefoneFunc);
            this.panel2.Controls.Add(this.btnVoltarFunc);
            this.panel2.Controls.Add(this.mskCpfFunc);
            this.panel2.Controls.Add(this.txtNomeFunc);
            this.panel2.Controls.Add(this.txtEmailFunc);
            this.panel2.Controls.Add(this.lblCpfFunc);
            this.panel2.Controls.Add(this.lblTelefoneFunc);
            this.panel2.Controls.Add(this.lblEmailFunc);
            this.panel2.Controls.Add(this.lblNomeFunc);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 284);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnCadastrarFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarFunc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastrarFunc.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFunc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCadastrarFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCadastrarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastrarFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCadastrarFunc.Location = new System.Drawing.Point(184, 215);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(97, 25);
            this.btnCadastrarFunc.TabIndex = 3;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.btnCadastrarFunc.UseVisualStyleBackColor = false;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // mskTelefoneFunc
            // 
            this.mskTelefoneFunc.Location = new System.Drawing.Point(181, 115);
            this.mskTelefoneFunc.Mask = "(00)00000-0000";
            this.mskTelefoneFunc.Name = "mskTelefoneFunc";
            this.mskTelefoneFunc.Size = new System.Drawing.Size(100, 20);
            this.mskTelefoneFunc.TabIndex = 11;
            // 
            // btnVoltarFunc
            // 
            this.btnVoltarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnVoltarFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarFunc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnVoltarFunc.FlatAppearance.BorderSize = 0;
            this.btnVoltarFunc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVoltarFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoltarFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarFunc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnVoltarFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnVoltarFunc.Location = new System.Drawing.Point(81, 215);
            this.btnVoltarFunc.Name = "btnVoltarFunc";
            this.btnVoltarFunc.Size = new System.Drawing.Size(97, 25);
            this.btnVoltarFunc.TabIndex = 2;
            this.btnVoltarFunc.Text = "Voltar ";
            this.btnVoltarFunc.UseVisualStyleBackColor = false;
            this.btnVoltarFunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskCpfFunc
            // 
            this.mskCpfFunc.Location = new System.Drawing.Point(181, 155);
            this.mskCpfFunc.Mask = "000.000.000-00";
            this.mskCpfFunc.Name = "mskCpfFunc";
            this.mskCpfFunc.Size = new System.Drawing.Size(100, 20);
            this.mskCpfFunc.TabIndex = 10;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(181, 37);
            this.txtNomeFunc.MaxLength = 50;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFunc.TabIndex = 7;
            this.txtNomeFunc.TextChanged += new System.EventHandler(this.tctNomeFunc_TextChanged);
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Location = new System.Drawing.Point(181, 73);
            this.txtEmailFunc.MaxLength = 150;
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(100, 20);
            this.txtEmailFunc.TabIndex = 6;
            // 
            // lblCpfFunc
            // 
            this.lblCpfFunc.AutoSize = true;
            this.lblCpfFunc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCpfFunc.ForeColor = System.Drawing.Color.White;
            this.lblCpfFunc.Location = new System.Drawing.Point(77, 150);
            this.lblCpfFunc.Name = "lblCpfFunc";
            this.lblCpfFunc.Size = new System.Drawing.Size(44, 21);
            this.lblCpfFunc.TabIndex = 4;
            this.lblCpfFunc.Text = "CPF:";
            // 
            // lblTelefoneFunc
            // 
            this.lblTelefoneFunc.AutoSize = true;
            this.lblTelefoneFunc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTelefoneFunc.ForeColor = System.Drawing.Color.White;
            this.lblTelefoneFunc.Location = new System.Drawing.Point(77, 112);
            this.lblTelefoneFunc.Name = "lblTelefoneFunc";
            this.lblTelefoneFunc.Size = new System.Drawing.Size(80, 21);
            this.lblTelefoneFunc.TabIndex = 3;
            this.lblTelefoneFunc.Text = "Telefone:";
            // 
            // lblEmailFunc
            // 
            this.lblEmailFunc.AutoSize = true;
            this.lblEmailFunc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblEmailFunc.ForeColor = System.Drawing.Color.White;
            this.lblEmailFunc.Location = new System.Drawing.Point(77, 70);
            this.lblEmailFunc.Name = "lblEmailFunc";
            this.lblEmailFunc.Size = new System.Drawing.Size(55, 21);
            this.lblEmailFunc.TabIndex = 2;
            this.lblEmailFunc.Text = "Email:";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNomeFunc.ForeColor = System.Drawing.Color.White;
            this.lblNomeFunc.Location = new System.Drawing.Point(77, 34);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(61, 21);
            this.lblNomeFunc.TabIndex = 1;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 36);
            this.panel3.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_fechar_janela_40;
            this.button1.Location = new System.Drawing.Point(311, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_minimizar_janela_35__1_;
            this.button2.Location = new System.Drawing.Point(279, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(349, 348);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro  Funcionario";
            this.Load += new System.EventHandler(this.frmCadastroFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVoltarFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTelefoneFunc;
        private System.Windows.Forms.MaskedTextBox mskCpfFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.Label lblCpfFunc;
        private System.Windows.Forms.Label lblTelefoneFunc;
        private System.Windows.Forms.Label lblEmailFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}