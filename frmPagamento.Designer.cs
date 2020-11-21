namespace AgenciaDeTurismo
{
    partial class frmPagamento
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.tURISMODataSet = new AgenciaDeTurismo.TURISMODataSet();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new AgenciaDeTurismo.TURISMODataSetTableAdapters.ReservaTableAdapter();
            this.btnVoltarPagamento = new System.Windows.Forms.Button();
            this.btnFinalizarPag = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mskValorTotPag = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipoPag = new System.Windows.Forms.ComboBox();
            this.lblTipoPag = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeTitPag = new System.Windows.Forms.TextBox();
            this.pnlCartPag = new System.Windows.Forms.Panel();
            this.mskNumCartPag = new System.Windows.Forms.MaskedTextBox();
            this.lblDataValPag = new System.Windows.Forms.Label();
            this.mskDataValPag = new System.Windows.Forms.MaskedTextBox();
            this.lblCodSegPag = new System.Windows.Forms.Label();
            this.lblNumCartPag = new System.Windows.Forms.Label();
            this.mskCodSegPag = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeTitPag = new System.Windows.Forms.Label();
            this.cmbIdReserva = new System.Windows.Forms.ComboBox();
            this.reservaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tURISMODataSet3 = new AgenciaDeTurismo.TURISMODataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.tURISMODataSet1 = new AgenciaDeTurismo.TURISMODataSet();
            this.funcionarioTableAdapter = new AgenciaDeTurismo.TURISMODataSet3TableAdapters.FuncionarioTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.pnlCartPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(133, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pagamento";
            // 
            // tURISMODataSet
            // 
            this.tURISMODataSet.DataSetName = "TURISMODataSet";
            this.tURISMODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = this.tURISMODataSet;
            this.reservaBindingSource.Position = 0;
            this.reservaBindingSource.CurrentChanged += new System.EventHandler(this.ReservaBindingSource_CurrentChanged);
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // btnVoltarPagamento
            // 
            this.btnVoltarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnVoltarPagamento.FlatAppearance.BorderSize = 0;
            this.btnVoltarPagamento.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVoltarPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoltarPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarPagamento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnVoltarPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnVoltarPagamento.Location = new System.Drawing.Point(73, 332);
            this.btnVoltarPagamento.Name = "btnVoltarPagamento";
            this.btnVoltarPagamento.Size = new System.Drawing.Size(97, 23);
            this.btnVoltarPagamento.TabIndex = 14;
            this.btnVoltarPagamento.Text = "Voltar";
            this.btnVoltarPagamento.UseVisualStyleBackColor = false;
            this.btnVoltarPagamento.Click += new System.EventHandler(this.BtnVoltarPagamento_Click);
            // 
            // btnFinalizarPag
            // 
            this.btnFinalizarPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnFinalizarPag.FlatAppearance.BorderSize = 0;
            this.btnFinalizarPag.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFinalizarPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFinalizarPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFinalizarPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPag.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFinalizarPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnFinalizarPag.Location = new System.Drawing.Point(176, 332);
            this.btnFinalizarPag.Name = "btnFinalizarPag";
            this.btnFinalizarPag.Size = new System.Drawing.Size(94, 23);
            this.btnFinalizarPag.TabIndex = 13;
            this.btnFinalizarPag.Text = "Finalizar";
            this.btnFinalizarPag.UseVisualStyleBackColor = false;
            this.btnFinalizarPag.Click += new System.EventHandler(this.BtnFinalizarPag_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID reserva:";
            // 
            // mskValorTotPag
            // 
            this.mskValorTotPag.Location = new System.Drawing.Point(211, 128);
            this.mskValorTotPag.Mask = "0.000,00";
            this.mskValorTotPag.Name = "mskValorTotPag";
            this.mskValorTotPag.Size = new System.Drawing.Size(100, 20);
            this.mskValorTotPag.TabIndex = 11;
            this.mskValorTotPag.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskValorTotPag_MaskInputRejected);
            // 
            // cmbTipoPag
            // 
            this.cmbTipoPag.FormattingEnabled = true;
            this.cmbTipoPag.Items.AddRange(new object[] {
            "Cartão",
            "Boleto"});
            this.cmbTipoPag.Location = new System.Drawing.Point(211, 92);
            this.cmbTipoPag.Name = "cmbTipoPag";
            this.cmbTipoPag.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoPag.TabIndex = 22;
            this.cmbTipoPag.SelectedIndexChanged += new System.EventHandler(this.CmbTipoPag_SelectedIndexChanged);
            // 
            // lblTipoPag
            // 
            this.lblTipoPag.AutoSize = true;
            this.lblTipoPag.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTipoPag.ForeColor = System.Drawing.Color.White;
            this.lblTipoPag.Location = new System.Drawing.Point(20, 95);
            this.lblTipoPag.Name = "lblTipoPag";
            this.lblTipoPag.Size = new System.Drawing.Size(171, 21);
            this.lblTipoPag.TabIndex = 23;
            this.lblTipoPag.Text = "Tipo de pagamento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(20, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Valor total:";
            // 
            // txtNomeTitPag
            // 
            this.txtNomeTitPag.Location = new System.Drawing.Point(211, 164);
            this.txtNomeTitPag.MaxLength = 20;
            this.txtNomeTitPag.Name = "txtNomeTitPag";
            this.txtNomeTitPag.Size = new System.Drawing.Size(100, 20);
            this.txtNomeTitPag.TabIndex = 0;
            this.txtNomeTitPag.TextChanged += new System.EventHandler(this.TxtNomeTitPag_TextChanged);
            // 
            // pnlCartPag
            // 
            this.pnlCartPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnlCartPag.Controls.Add(this.mskNumCartPag);
            this.pnlCartPag.Controls.Add(this.lblDataValPag);
            this.pnlCartPag.Controls.Add(this.mskDataValPag);
            this.pnlCartPag.Controls.Add(this.lblCodSegPag);
            this.pnlCartPag.Controls.Add(this.lblNumCartPag);
            this.pnlCartPag.Controls.Add(this.mskCodSegPag);
            this.pnlCartPag.ForeColor = System.Drawing.Color.White;
            this.pnlCartPag.Location = new System.Drawing.Point(0, 190);
            this.pnlCartPag.Name = "pnlCartPag";
            this.pnlCartPag.Size = new System.Drawing.Size(356, 136);
            this.pnlCartPag.TabIndex = 36;
            this.pnlCartPag.Visible = false;
            // 
            // mskNumCartPag
            // 
            this.mskNumCartPag.Location = new System.Drawing.Point(211, 11);
            this.mskNumCartPag.Mask = "0000 0000 0000 0000";
            this.mskNumCartPag.Name = "mskNumCartPag";
            this.mskNumCartPag.Size = new System.Drawing.Size(100, 20);
            this.mskNumCartPag.TabIndex = 17;
            // 
            // lblDataValPag
            // 
            this.lblDataValPag.AutoSize = true;
            this.lblDataValPag.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataValPag.Location = new System.Drawing.Point(20, 50);
            this.lblDataValPag.Name = "lblDataValPag";
            this.lblDataValPag.Size = new System.Drawing.Size(154, 21);
            this.lblDataValPag.TabIndex = 10;
            this.lblDataValPag.Text = "Data de validade:";
            // 
            // mskDataValPag
            // 
            this.mskDataValPag.Location = new System.Drawing.Point(211, 50);
            this.mskDataValPag.Mask = "00/00/0000";
            this.mskDataValPag.Name = "mskDataValPag";
            this.mskDataValPag.Size = new System.Drawing.Size(100, 20);
            this.mskDataValPag.TabIndex = 3;
            // 
            // lblCodSegPag
            // 
            this.lblCodSegPag.AutoSize = true;
            this.lblCodSegPag.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCodSegPag.Location = new System.Drawing.Point(20, 84);
            this.lblCodSegPag.Name = "lblCodSegPag";
            this.lblCodSegPag.Size = new System.Drawing.Size(185, 21);
            this.lblCodSegPag.TabIndex = 9;
            this.lblCodSegPag.Text = "Código de segurança:";
            this.lblCodSegPag.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lblNumCartPag
            // 
            this.lblNumCartPag.AutoSize = true;
            this.lblNumCartPag.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNumCartPag.Location = new System.Drawing.Point(20, 11);
            this.lblNumCartPag.Name = "lblNumCartPag";
            this.lblNumCartPag.Size = new System.Drawing.Size(159, 21);
            this.lblNumCartPag.TabIndex = 6;
            this.lblNumCartPag.Text = "Número do cartão:";
            this.lblNumCartPag.Click += new System.EventHandler(this.Label2_Click);
            // 
            // mskCodSegPag
            // 
            this.mskCodSegPag.Location = new System.Drawing.Point(210, 84);
            this.mskCodSegPag.Mask = "000";
            this.mskCodSegPag.Name = "mskCodSegPag";
            this.mskCodSegPag.Size = new System.Drawing.Size(100, 20);
            this.mskCodSegPag.TabIndex = 4;
            // 
            // lblNomeTitPag
            // 
            this.lblNomeTitPag.AutoSize = true;
            this.lblNomeTitPag.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNomeTitPag.ForeColor = System.Drawing.Color.White;
            this.lblNomeTitPag.Location = new System.Drawing.Point(20, 164);
            this.lblNomeTitPag.Name = "lblNomeTitPag";
            this.lblNomeTitPag.Size = new System.Drawing.Size(136, 21);
            this.lblNomeTitPag.TabIndex = 5;
            this.lblNomeTitPag.Text = "Nome do titular:";
            // 
            // cmbIdReserva
            // 
            this.cmbIdReserva.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tURISMODataSet, "Reserva.Cod_Reserva", true));
            this.cmbIdReserva.DataSource = this.reservaBindingSource1;
            this.cmbIdReserva.DisplayMember = "Cod_Reserva";
            this.cmbIdReserva.FormattingEnabled = true;
            this.cmbIdReserva.Location = new System.Drawing.Point(210, 55);
            this.cmbIdReserva.Name = "cmbIdReserva";
            this.cmbIdReserva.Size = new System.Drawing.Size(100, 21);
            this.cmbIdReserva.TabIndex = 37;
            this.cmbIdReserva.ValueMember = "Cod_Reserva";
            this.cmbIdReserva.SelectedIndexChanged += new System.EventHandler(this.CmbIdReserva_SelectedIndexChanged);
            // 
            // reservaBindingSource1
            // 
            this.reservaBindingSource1.DataMember = "Reserva";
            this.reservaBindingSource1.DataSource = this.reservaBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tURISMODataSet, "Reserva.Cod_Reserva", true));
            this.comboBox1.DataSource = this.funcionarioBindingSource;
            this.comboBox1.DisplayMember = "Nome_Funcionario";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.ValueMember = "Cod_Funcionario";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.tURISMODataSet3;
            // 
            // tURISMODataSet3
            // 
            this.tURISMODataSet3.DataSetName = "TURISMODataSet3";
            this.tURISMODataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Funcionario:";
            // 
            // tURISMODataSet1
            // 
            this.tURISMODataSet1.DataSetName = "TURISMODataSet";
            this.tURISMODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 30);
            this.panel1.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_fechar_janela_40;
            this.button1.Location = new System.Drawing.Point(304, 3);
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
            this.button2.Location = new System.Drawing.Point(272, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.cmbIdReserva);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblNomeTitPag);
            this.panel3.Controls.Add(this.pnlCartPag);
            this.panel3.Controls.Add(this.txtNomeTitPag);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblTipoPag);
            this.panel3.Controls.Add(this.cmbTipoPag);
            this.panel3.Controls.Add(this.mskValorTotPag);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnFinalizarPag);
            this.panel3.Controls.Add(this.btnVoltarPagamento);
            this.panel3.Location = new System.Drawing.Point(2, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 410);
            this.panel3.TabIndex = 35;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(349, 430);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagamento";
            this.Load += new System.EventHandler(this.FrmPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.pnlCartPag.ResumeLayout(false);
            this.pnlCartPag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private TURISMODataSet tURISMODataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private TURISMODataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.Button btnVoltarPagamento;
        private System.Windows.Forms.Button btnFinalizarPag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskValorTotPag;
        private System.Windows.Forms.ComboBox cmbTipoPag;
        private System.Windows.Forms.Label lblTipoPag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomeTitPag;
        private System.Windows.Forms.Panel pnlCartPag;
        private System.Windows.Forms.MaskedTextBox mskNumCartPag;
        private System.Windows.Forms.Label lblDataValPag;
        private System.Windows.Forms.MaskedTextBox mskDataValPag;
        private System.Windows.Forms.Label lblCodSegPag;
        private System.Windows.Forms.Label lblNumCartPag;
        private System.Windows.Forms.MaskedTextBox mskCodSegPag;
        private System.Windows.Forms.Label lblNomeTitPag;
        private System.Windows.Forms.ComboBox cmbIdReserva;
        private System.Windows.Forms.BindingSource reservaBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private TURISMODataSet tURISMODataSet1;
        private TURISMODataSet3 tURISMODataSet3;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private TURISMODataSet3TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
    }
}