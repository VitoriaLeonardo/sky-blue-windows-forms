namespace AgenciaDeTurismo
{
    partial class frmCadastroPacotes
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
            this.nmrQuPasCadPac = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigemPacotes = new System.Windows.Forms.TextBox();
            this.lblValorPacotes = new System.Windows.Forms.Label();
            this.lblDestinoPacotes = new System.Windows.Forms.Label();
            this.mskValorPacotes = new System.Windows.Forms.MaskedTextBox();
            this.lblDescPacotes = new System.Windows.Forms.Label();
            this.txtTipoPacotes = new System.Windows.Forms.TextBox();
            this.txtDescricaoPacotes = new System.Windows.Forms.TextBox();
            this.txtDestinoPacotes = new System.Windows.Forms.TextBox();
            this.lblTipoPacotes = new System.Windows.Forms.Label();
            this.btnCadastrarPacotes = new System.Windows.Forms.Button();
            this.btnVoltarPacotes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuPasCadPac)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.nmrQuPasCadPac);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtOrigemPacotes);
            this.panel2.Controls.Add(this.lblValorPacotes);
            this.panel2.Controls.Add(this.lblDestinoPacotes);
            this.panel2.Controls.Add(this.mskValorPacotes);
            this.panel2.Controls.Add(this.lblDescPacotes);
            this.panel2.Controls.Add(this.txtTipoPacotes);
            this.panel2.Controls.Add(this.txtDescricaoPacotes);
            this.panel2.Controls.Add(this.txtDestinoPacotes);
            this.panel2.Controls.Add(this.lblTipoPacotes);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 290);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // nmrQuPasCadPac
            // 
            this.nmrQuPasCadPac.Location = new System.Drawing.Point(203, 135);
            this.nmrQuPasCadPac.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrQuPasCadPac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrQuPasCadPac.Name = "nmrQuPasCadPac";
            this.nmrQuPasCadPac.ReadOnly = true;
            this.nmrQuPasCadPac.Size = new System.Drawing.Size(100, 20);
            this.nmrQuPasCadPac.TabIndex = 6;
            this.nmrQuPasCadPac.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrQuPasCadPac.ValueChanged += new System.EventHandler(this.NmrQuPasCadPac_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quant. passagens:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Origem";
            // 
            // txtOrigemPacotes
            // 
            this.txtOrigemPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigemPacotes.Location = new System.Drawing.Point(203, 60);
            this.txtOrigemPacotes.MaxLength = 40;
            this.txtOrigemPacotes.Name = "txtOrigemPacotes";
            this.txtOrigemPacotes.Size = new System.Drawing.Size(100, 20);
            this.txtOrigemPacotes.TabIndex = 19;
            // 
            // lblValorPacotes
            // 
            this.lblValorPacotes.AutoSize = true;
            this.lblValorPacotes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPacotes.ForeColor = System.Drawing.Color.White;
            this.lblValorPacotes.Location = new System.Drawing.Point(41, 254);
            this.lblValorPacotes.Name = "lblValorPacotes";
            this.lblValorPacotes.Size = new System.Drawing.Size(54, 21);
            this.lblValorPacotes.TabIndex = 17;
            this.lblValorPacotes.Text = "Valor:";
            this.lblValorPacotes.Click += new System.EventHandler(this.lblNacioCliente_Click);
            // 
            // lblDestinoPacotes
            // 
            this.lblDestinoPacotes.AutoSize = true;
            this.lblDestinoPacotes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoPacotes.ForeColor = System.Drawing.Color.White;
            this.lblDestinoPacotes.Location = new System.Drawing.Point(41, 91);
            this.lblDestinoPacotes.Name = "lblDestinoPacotes";
            this.lblDestinoPacotes.Size = new System.Drawing.Size(72, 21);
            this.lblDestinoPacotes.TabIndex = 2;
            this.lblDestinoPacotes.Text = "Destino:";
            // 
            // mskValorPacotes
            // 
            this.mskValorPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValorPacotes.Location = new System.Drawing.Point(203, 254);
            this.mskValorPacotes.Mask = "0.000,00";
            this.mskValorPacotes.Name = "mskValorPacotes";
            this.mskValorPacotes.Size = new System.Drawing.Size(100, 20);
            this.mskValorPacotes.TabIndex = 10;
            this.mskValorPacotes.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCpfCliente_MaskInputRejected);
            // 
            // lblDescPacotes
            // 
            this.lblDescPacotes.AutoSize = true;
            this.lblDescPacotes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescPacotes.ForeColor = System.Drawing.Color.White;
            this.lblDescPacotes.Location = new System.Drawing.Point(41, 176);
            this.lblDescPacotes.Name = "lblDescPacotes";
            this.lblDescPacotes.Size = new System.Drawing.Size(91, 21);
            this.lblDescPacotes.TabIndex = 3;
            this.lblDescPacotes.Text = "Descrição:";
            // 
            // txtTipoPacotes
            // 
            this.txtTipoPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPacotes.Location = new System.Drawing.Point(203, 19);
            this.txtTipoPacotes.MaxLength = 40;
            this.txtTipoPacotes.Name = "txtTipoPacotes";
            this.txtTipoPacotes.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPacotes.TabIndex = 7;
            // 
            // txtDescricaoPacotes
            // 
            this.txtDescricaoPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoPacotes.Location = new System.Drawing.Point(203, 177);
            this.txtDescricaoPacotes.MaxLength = 150;
            this.txtDescricaoPacotes.Multiline = true;
            this.txtDescricaoPacotes.Name = "txtDescricaoPacotes";
            this.txtDescricaoPacotes.Size = new System.Drawing.Size(100, 71);
            this.txtDescricaoPacotes.TabIndex = 6;
            // 
            // txtDestinoPacotes
            // 
            this.txtDestinoPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinoPacotes.Location = new System.Drawing.Point(203, 94);
            this.txtDestinoPacotes.MaxLength = 40;
            this.txtDestinoPacotes.Name = "txtDestinoPacotes";
            this.txtDestinoPacotes.Size = new System.Drawing.Size(100, 20);
            this.txtDestinoPacotes.TabIndex = 6;
            // 
            // lblTipoPacotes
            // 
            this.lblTipoPacotes.AutoSize = true;
            this.lblTipoPacotes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPacotes.ForeColor = System.Drawing.Color.White;
            this.lblTipoPacotes.Location = new System.Drawing.Point(41, 18);
            this.lblTipoPacotes.Name = "lblTipoPacotes";
            this.lblTipoPacotes.Size = new System.Drawing.Size(46, 21);
            this.lblTipoPacotes.TabIndex = 1;
            this.lblTipoPacotes.Text = "Tipo:";
            // 
            // btnCadastrarPacotes
            // 
            this.btnCadastrarPacotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnCadastrarPacotes.FlatAppearance.BorderSize = 0;
            this.btnCadastrarPacotes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCadastrarPacotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarPacotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCadastrarPacotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarPacotes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastrarPacotes.Location = new System.Drawing.Point(178, 373);
            this.btnCadastrarPacotes.Name = "btnCadastrarPacotes";
            this.btnCadastrarPacotes.Size = new System.Drawing.Size(97, 25);
            this.btnCadastrarPacotes.TabIndex = 3;
            this.btnCadastrarPacotes.Text = "Cadastrar";
            this.btnCadastrarPacotes.UseVisualStyleBackColor = false;
            this.btnCadastrarPacotes.Click += new System.EventHandler(this.btnCadastrarPacotes_Click);
            // 
            // btnVoltarPacotes
            // 
            this.btnVoltarPacotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnVoltarPacotes.FlatAppearance.BorderSize = 0;
            this.btnVoltarPacotes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVoltarPacotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoltarPacotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltarPacotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarPacotes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnVoltarPacotes.Location = new System.Drawing.Point(72, 373);
            this.btnVoltarPacotes.Name = "btnVoltarPacotes";
            this.btnVoltarPacotes.Size = new System.Drawing.Size(97, 25);
            this.btnVoltarPacotes.TabIndex = 2;
            this.btnVoltarPacotes.Text = "Voltar ";
            this.btnVoltarPacotes.UseVisualStyleBackColor = false;
            this.btnVoltarPacotes.Click += new System.EventHandler(this.btnVoltarPacotes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cadastro Pacotes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 30);
            this.panel3.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_fechar_janela_40;
            this.button1.Location = new System.Drawing.Point(303, 3);
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
            this.button2.Location = new System.Drawing.Point(271, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmCadastroPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(349, 410);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCadastrarPacotes);
            this.Controls.Add(this.btnVoltarPacotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroPacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro Pacotes ";
            this.Load += new System.EventHandler(this.FrmCadastroPacotes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuPasCadPac)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblValorPacotes;
        private System.Windows.Forms.Button btnCadastrarPacotes;
        private System.Windows.Forms.Button btnVoltarPacotes;
        private System.Windows.Forms.Label lblDestinoPacotes;
        private System.Windows.Forms.Label lblDescPacotes;
        private System.Windows.Forms.TextBox txtTipoPacotes;
        private System.Windows.Forms.TextBox txtDestinoPacotes;
        private System.Windows.Forms.Label lblTipoPacotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskValorPacotes;
        private System.Windows.Forms.TextBox txtDescricaoPacotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigemPacotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrQuPasCadPac;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}