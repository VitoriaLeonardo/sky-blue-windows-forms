namespace AgenciaDeTurismo
{
    partial class frmAgendaReserva
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtDataResFinal = new System.Windows.Forms.DateTimePicker();
            this.dtDataResInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbIdPacoteReserva = new System.Windows.Forms.ComboBox();
            this.reservaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tURISMODataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tURISMODataSet = new AgenciaDeTurismo.TURISMODataSet();
            this.pacotesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tURISMODataSet4 = new AgenciaDeTurismo.TURISMODataSet4();
            this.cmbIdClienteReserva = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tURISMODataSet1 = new AgenciaDeTurismo.TURISMODataSet1();
            this.btnVoltReserva = new System.Windows.Forms.Button();
            this.txtNomeTitReserva = new System.Windows.Forms.TextBox();
            this.pacotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tURISMODataSet2 = new AgenciaDeTurismo.TURISMODataSet2();
            this.tURISMODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new AgenciaDeTurismo.TURISMODataSetTableAdapters.ReservaTableAdapter();
            this.reservaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reservaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reservaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.reservaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new AgenciaDeTurismo.TURISMODataSet1TableAdapters.ClienteTableAdapter();
            this.pacotesTableAdapter = new AgenciaDeTurismo.TURISMODataSet2TableAdapters.PacotesTableAdapter();
            this.tURISMODataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pacotesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pacotesTableAdapter1 = new AgenciaDeTurismo.TURISMODataSet4TableAdapters.PacotesTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacotesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacotesBindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de ida:";
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnReservar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnReservar.Location = new System.Drawing.Point(155, 280);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(83, 26);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome titular:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(129, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reserva";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pacote:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.dtDataResFinal);
            this.panel2.Controls.Add(this.dtDataResInicio);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbIdPacoteReserva);
            this.panel2.Controls.Add(this.cmbIdClienteReserva);
            this.panel2.Controls.Add(this.btnVoltReserva);
            this.panel2.Controls.Add(this.txtNomeTitReserva);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnReservar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(28, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 351);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // dtDataResFinal
            // 
            this.dtDataResFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataResFinal.Location = new System.Drawing.Point(144, 186);
            this.dtDataResFinal.Name = "dtDataResFinal";
            this.dtDataResFinal.Size = new System.Drawing.Size(121, 20);
            this.dtDataResFinal.TabIndex = 18;
            this.dtDataResFinal.Value = new System.DateTime(2019, 11, 23, 11, 27, 22, 0);
            this.dtDataResFinal.ValueChanged += new System.EventHandler(this.DtDataResFinal_ValueChanged_1);
            // 
            // dtDataResInicio
            // 
            this.dtDataResInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataResInicio.Location = new System.Drawing.Point(144, 149);
            this.dtDataResInicio.Name = "dtDataResInicio";
            this.dtDataResInicio.Size = new System.Drawing.Size(121, 20);
            this.dtDataResInicio.TabIndex = 17;
            this.dtDataResInicio.ValueChanged += new System.EventHandler(this.DtDataResInicio_ValueChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(13, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data de volta:";
            // 
            // cmbIdPacoteReserva
            // 
            this.cmbIdPacoteReserva.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservaBindingSource3, "Cod_Pacote", true));
            this.cmbIdPacoteReserva.DataSource = this.pacotesBindingSource2;
            this.cmbIdPacoteReserva.DisplayMember = "Destino";
            this.cmbIdPacoteReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdPacoteReserva.FormattingEnabled = true;
            this.cmbIdPacoteReserva.Location = new System.Drawing.Point(144, 77);
            this.cmbIdPacoteReserva.Name = "cmbIdPacoteReserva";
            this.cmbIdPacoteReserva.Size = new System.Drawing.Size(121, 21);
            this.cmbIdPacoteReserva.TabIndex = 13;
            this.cmbIdPacoteReserva.ValueMember = "Cod_Pacote";
            // 
            // reservaBindingSource3
            // 
            this.reservaBindingSource3.DataMember = "Reserva";
            this.reservaBindingSource3.DataSource = this.tURISMODataSetBindingSource1;
            // 
            // tURISMODataSetBindingSource1
            // 
            this.tURISMODataSetBindingSource1.DataSource = this.tURISMODataSet;
            this.tURISMODataSetBindingSource1.Position = 0;
            // 
            // tURISMODataSet
            // 
            this.tURISMODataSet.DataSetName = "TURISMODataSet";
            this.tURISMODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacotesBindingSource2
            // 
            this.pacotesBindingSource2.DataMember = "Pacotes";
            this.pacotesBindingSource2.DataSource = this.tURISMODataSet4;
            // 
            // tURISMODataSet4
            // 
            this.tURISMODataSet4.DataSetName = "TURISMODataSet4";
            this.tURISMODataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIdClienteReserva
            // 
            this.cmbIdClienteReserva.DataSource = this.clienteBindingSource;
            this.cmbIdClienteReserva.DisplayMember = "CPF_Cliente";
            this.cmbIdClienteReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdClienteReserva.FormattingEnabled = true;
            this.cmbIdClienteReserva.Location = new System.Drawing.Point(144, 40);
            this.cmbIdClienteReserva.Name = "cmbIdClienteReserva";
            this.cmbIdClienteReserva.Size = new System.Drawing.Size(121, 21);
            this.cmbIdClienteReserva.TabIndex = 12;
            this.cmbIdClienteReserva.ValueMember = "Cod_Cliente";
            this.cmbIdClienteReserva.SelectedIndexChanged += new System.EventHandler(this.CmbIdClienteReserva_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.tURISMODataSet1;
            // 
            // tURISMODataSet1
            // 
            this.tURISMODataSet1.DataSetName = "TURISMODataSet1";
            this.tURISMODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVoltReserva
            // 
            this.btnVoltReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnVoltReserva.FlatAppearance.BorderSize = 0;
            this.btnVoltReserva.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVoltReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoltReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltReserva.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnVoltReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnVoltReserva.Location = new System.Drawing.Point(66, 280);
            this.btnVoltReserva.Name = "btnVoltReserva";
            this.btnVoltReserva.Size = new System.Drawing.Size(83, 26);
            this.btnVoltReserva.TabIndex = 13;
            this.btnVoltReserva.Text = "Voltar";
            this.btnVoltReserva.UseVisualStyleBackColor = false;
            this.btnVoltReserva.Click += new System.EventHandler(this.BtnVoltReserva_Click);
            // 
            // txtNomeTitReserva
            // 
            this.txtNomeTitReserva.Location = new System.Drawing.Point(144, 114);
            this.txtNomeTitReserva.MaxLength = 50;
            this.txtNomeTitReserva.Name = "txtNomeTitReserva";
            this.txtNomeTitReserva.Size = new System.Drawing.Size(121, 20);
            this.txtNomeTitReserva.TabIndex = 10;
            this.txtNomeTitReserva.TextChanged += new System.EventHandler(this.TxtNomeTitReserva_TextChanged);
            // 
            // pacotesBindingSource
            // 
            this.pacotesBindingSource.DataMember = "Pacotes";
            this.pacotesBindingSource.DataSource = this.tURISMODataSet2;
            // 
            // tURISMODataSet2
            // 
            this.tURISMODataSet2.DataSetName = "TURISMODataSet2";
            this.tURISMODataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tURISMODataSetBindingSource
            // 
            this.tURISMODataSetBindingSource.DataSource = this.tURISMODataSet;
            this.tURISMODataSetBindingSource.Position = 0;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.tURISMODataSet;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // reservaBindingSource1
            // 
            this.reservaBindingSource1.DataMember = "Reserva";
            this.reservaBindingSource1.DataSource = this.tURISMODataSetBindingSource;
            // 
            // reservaBindingSource2
            // 
            this.reservaBindingSource2.DataMember = "Reserva";
            this.reservaBindingSource2.DataSource = this.tURISMODataSetBindingSource;
            // 
            // reservaBindingSource4
            // 
            this.reservaBindingSource4.DataMember = "Reserva";
            this.reservaBindingSource4.DataSource = this.tURISMODataSetBindingSource;
            // 
            // reservaBindingSource5
            // 
            this.reservaBindingSource5.DataMember = "Reserva";
            this.reservaBindingSource5.DataSource = this.tURISMODataSetBindingSource;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // pacotesTableAdapter
            // 
            this.pacotesTableAdapter.ClearBeforeFill = true;
            // 
            // tURISMODataSetBindingSource2
            // 
            this.tURISMODataSetBindingSource2.DataSource = this.tURISMODataSet;
            this.tURISMODataSetBindingSource2.Position = 0;
            // 
            // pacotesBindingSource1
            // 
            this.pacotesBindingSource1.DataMember = "Pacotes";
            this.pacotesBindingSource1.DataSource = this.tURISMODataSet2;
            // 
            // pacotesTableAdapter1
            // 
            this.pacotesTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 30);
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
            // frmAgendaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(349, 410);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.FrmAgendaReserva_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacotesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURISMODataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacotesBindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbIdPacoteReserva;
        private System.Windows.Forms.ComboBox cmbIdClienteReserva;
        private System.Windows.Forms.Button btnVoltReserva;
        private System.Windows.Forms.TextBox txtNomeTitReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource tURISMODataSetBindingSource;
        private TURISMODataSet tURISMODataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private TURISMODataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.BindingSource reservaBindingSource1;
        private System.Windows.Forms.BindingSource tURISMODataSetBindingSource1;
        private System.Windows.Forms.BindingSource reservaBindingSource3;
        private System.Windows.Forms.BindingSource reservaBindingSource4;
        private System.Windows.Forms.BindingSource reservaBindingSource2;
        private System.Windows.Forms.BindingSource reservaBindingSource5;
        private TURISMODataSet1 tURISMODataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private TURISMODataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private TURISMODataSet2 tURISMODataSet2;
        private System.Windows.Forms.BindingSource pacotesBindingSource;
        private TURISMODataSet2TableAdapters.PacotesTableAdapter pacotesTableAdapter;
        private System.Windows.Forms.DateTimePicker dtDataResFinal;
        private System.Windows.Forms.DateTimePicker dtDataResInicio;
        private System.Windows.Forms.BindingSource pacotesBindingSource1;
        private System.Windows.Forms.BindingSource tURISMODataSetBindingSource2;
        private TURISMODataSet4 tURISMODataSet4;
        private System.Windows.Forms.BindingSource pacotesBindingSource2;
        private TURISMODataSet4TableAdapters.PacotesTableAdapter pacotesTableAdapter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}