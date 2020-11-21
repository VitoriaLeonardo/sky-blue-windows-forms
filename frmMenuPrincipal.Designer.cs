namespace AgenciaDeTurismo
{
    partial class frmMenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDataHora = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenuCons = new System.Windows.Forms.Button();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.btnMenuPag = new System.Windows.Forms.Button();
            this.btnMenuAgenda = new System.Windows.Forms.Button();
            this.btnMenuCadastros = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfigCor = new System.Windows.Forms.Button();
            this.pnlCadastros = new System.Windows.Forms.Panel();
            this.btnCadastroFunc = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastroPacotes = new System.Windows.Forms.Button();
            this.pnlConsultas = new System.Windows.Forms.Panel();
            this.btnConsultasCadastros = new System.Windows.Forms.Button();
            this.btnConsultasReservas = new System.Windows.Forms.Button();
            this.btnConsultaPagamento = new System.Windows.Forms.Button();
            this.btnConsultVenda = new System.Windows.Forms.Button();
            this.pnlAgenda = new System.Windows.Forms.Panel();
            this.btnAgendaReservas = new System.Windows.Forms.Button();
            this.pnlPagamento = new System.Windows.Forms.Panel();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbDataHora.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlCadastros.SuspendLayout();
            this.pnlConsultas.SuspendLayout();
            this.pnlAgenda.SuspendLayout();
            this.pnlPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-15, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 35);
            this.panel1.TabIndex = 0;
            // 
            // gbDataHora
            // 
            this.gbDataHora.BackColor = System.Drawing.Color.Transparent;
            this.gbDataHora.Controls.Add(this.lblHora);
            this.gbDataHora.Controls.Add(this.lblData);
            this.gbDataHora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataHora.Location = new System.Drawing.Point(144, 177);
            this.gbDataHora.Name = "gbDataHora";
            this.gbDataHora.Size = new System.Drawing.Size(269, 131);
            this.gbDataHora.TabIndex = 19;
            this.gbDataHora.TabStop = false;
            this.gbDataHora.Text = "Data/Hora";
            this.gbDataHora.Enter += new System.EventHandler(this.GbDataHora_Enter);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 10F);
            this.lblHora.Location = new System.Drawing.Point(44, 73);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 16);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "HORA";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 10F);
            this.lblData.Location = new System.Drawing.Point(44, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 16);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "DATA";
            this.lblData.Click += new System.EventHandler(this.LblData_Click);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnMenuCons);
            this.panel5.Controls.Add(this.pnlSlide);
            this.panel5.Controls.Add(this.btnMenuPag);
            this.panel5.Controls.Add(this.btnMenuAgenda);
            this.panel5.Controls.Add(this.btnMenuCadastros);
            this.panel5.Controls.Add(this.btnSair);
            this.panel5.Controls.Add(this.btnConfigCor);
            this.panel5.Location = new System.Drawing.Point(2, -3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(798, 98);
            this.panel5.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Menu principal";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_minimizar_janela_35__1_;
            this.button2.Location = new System.Drawing.Point(722, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_fechar_janela_40;
            this.button1.Location = new System.Drawing.Point(754, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnMenuCons
            // 
            this.btnMenuCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnMenuCons.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuCons.FlatAppearance.BorderSize = 0;
            this.btnMenuCons.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuCons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuCons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCons.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnMenuCons.ForeColor = System.Drawing.Color.White;
            this.btnMenuCons.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_consulta_20;
            this.btnMenuCons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCons.Location = new System.Drawing.Point(426, 35);
            this.btnMenuCons.Name = "btnMenuCons";
            this.btnMenuCons.Size = new System.Drawing.Size(136, 63);
            this.btnMenuCons.TabIndex = 29;
            this.btnMenuCons.Text = "   Consultas";
            this.btnMenuCons.UseVisualStyleBackColor = false;
            this.btnMenuCons.Click += new System.EventHandler(this.BtnMenuCons_Click);
            this.btnMenuCons.MouseEnter += new System.EventHandler(this.BtnMenuCons_MouseEnter);
            this.btnMenuCons.MouseHover += new System.EventHandler(this.BtnMenuCons_MouseHover);
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.pnlSlide.Location = new System.Drawing.Point(0, 27);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(136, 10);
            this.pnlSlide.TabIndex = 25;
            this.pnlSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSlide_Paint);
            // 
            // btnMenuPag
            // 
            this.btnMenuPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnMenuPag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuPag.FlatAppearance.BorderSize = 0;
            this.btnMenuPag.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPag.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnMenuPag.ForeColor = System.Drawing.Color.White;
            this.btnMenuPag.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_pagamento_móvel_252;
            this.btnMenuPag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPag.Location = new System.Drawing.Point(284, 35);
            this.btnMenuPag.Name = "btnMenuPag";
            this.btnMenuPag.Size = new System.Drawing.Size(136, 63);
            this.btnMenuPag.TabIndex = 23;
            this.btnMenuPag.Text = "    Pagamento";
            this.btnMenuPag.UseVisualStyleBackColor = false;
            this.btnMenuPag.Click += new System.EventHandler(this.BtnMenuPag_Click);
            this.btnMenuPag.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnMenuPag_Paint);
            this.btnMenuPag.MouseEnter += new System.EventHandler(this.BtnMenuPag_MouseEnter);
            this.btnMenuPag.MouseHover += new System.EventHandler(this.BtnMenuPag_MouseHover);
            // 
            // btnMenuAgenda
            // 
            this.btnMenuAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnMenuAgenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuAgenda.FlatAppearance.BorderSize = 0;
            this.btnMenuAgenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAgenda.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnMenuAgenda.ForeColor = System.Drawing.Color.White;
            this.btnMenuAgenda.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_calendário_20;
            this.btnMenuAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAgenda.Location = new System.Drawing.Point(140, 35);
            this.btnMenuAgenda.Name = "btnMenuAgenda";
            this.btnMenuAgenda.Size = new System.Drawing.Size(136, 63);
            this.btnMenuAgenda.TabIndex = 22;
            this.btnMenuAgenda.Text = "    Agenda";
            this.btnMenuAgenda.UseVisualStyleBackColor = false;
            this.btnMenuAgenda.Click += new System.EventHandler(this.BtnMenuAgenda_Click);
            this.btnMenuAgenda.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnMenuAgenda_Paint);
            this.btnMenuAgenda.MouseEnter += new System.EventHandler(this.BtnMenuAgenda_MouseEnter);
            this.btnMenuAgenda.MouseHover += new System.EventHandler(this.BtnMenuAgenda_MouseHover);
            // 
            // btnMenuCadastros
            // 
            this.btnMenuCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnMenuCadastros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenuCadastros.FlatAppearance.BorderSize = 0;
            this.btnMenuCadastros.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenuCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnMenuCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCadastros.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnMenuCadastros.ForeColor = System.Drawing.Color.White;
            this.btnMenuCadastros.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_mais_2_matemática_25__1_1;
            this.btnMenuCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCadastros.Location = new System.Drawing.Point(0, 35);
            this.btnMenuCadastros.Name = "btnMenuCadastros";
            this.btnMenuCadastros.Size = new System.Drawing.Size(136, 63);
            this.btnMenuCadastros.TabIndex = 21;
            this.btnMenuCadastros.Text = "   Cadastros";
            this.btnMenuCadastros.UseVisualStyleBackColor = false;
            this.btnMenuCadastros.Click += new System.EventHandler(this.BtnMenuCadastros_Click);
            this.btnMenuCadastros.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnMenuCadastros_Paint);
            this.btnMenuCadastros.MouseEnter += new System.EventHandler(this.BtnMenuCadastros_MouseEnter);
            this.btnMenuCadastros.MouseHover += new System.EventHandler(this.BtnMenuCadastros_MouseHover);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_sair_20;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(714, 69);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 31);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "   Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfigCor
            // 
            this.btnConfigCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnConfigCor.FlatAppearance.BorderSize = 0;
            this.btnConfigCor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConfigCor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConfigCor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConfigCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigCor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnConfigCor.ForeColor = System.Drawing.Color.White;
            this.btnConfigCor.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_cor_de_preenchimento_20__1_;
            this.btnConfigCor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigCor.Location = new System.Drawing.Point(567, 35);
            this.btnConfigCor.Name = "btnConfigCor";
            this.btnConfigCor.Size = new System.Drawing.Size(137, 63);
            this.btnConfigCor.TabIndex = 16;
            this.btnConfigCor.Text = "Cor";
            this.btnConfigCor.UseVisualStyleBackColor = false;
            this.btnConfigCor.Click += new System.EventHandler(this.BtnConfigCor_Click);
            // 
            // pnlCadastros
            // 
            this.pnlCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnlCadastros.Controls.Add(this.btnCadastroFunc);
            this.pnlCadastros.Controls.Add(this.btnCadastroCliente);
            this.pnlCadastros.Controls.Add(this.btnCadastroPacotes);
            this.pnlCadastros.Location = new System.Drawing.Point(2, 94);
            this.pnlCadastros.Name = "pnlCadastros";
            this.pnlCadastros.Size = new System.Drawing.Size(136, 195);
            this.pnlCadastros.TabIndex = 25;
            this.pnlCadastros.Visible = false;
            this.pnlCadastros.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCadastros);
            this.pnlCadastros.MouseLeave += new System.EventHandler(this.PnlCadastros_MouseLeave);
            // 
            // btnCadastroFunc
            // 
            this.btnCadastroFunc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroFunc.FlatAppearance.BorderSize = 0;
            this.btnCadastroFunc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroFunc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastroFunc.ForeColor = System.Drawing.Color.White;
            this.btnCadastroFunc.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_funcionário_homem_20;
            this.btnCadastroFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFunc.Location = new System.Drawing.Point(0, 7);
            this.btnCadastroFunc.Name = "btnCadastroFunc";
            this.btnCadastroFunc.Size = new System.Drawing.Size(136, 59);
            this.btnCadastroFunc.TabIndex = 2;
            this.btnCadastroFunc.Text = "     Funcionário";
            this.btnCadastroFunc.UseVisualStyleBackColor = false;
            this.btnCadastroFunc.Click += new System.EventHandler(this.btnCadastroFunc_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCliente.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_gestão_de_cliente_24;
            this.btnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.Location = new System.Drawing.Point(0, 65);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(136, 59);
            this.btnCadastroCliente.TabIndex = 3;
            this.btnCadastroCliente.Text = "  Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastroPacotes
            // 
            this.btnCadastroPacotes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroPacotes.FlatAppearance.BorderSize = 0;
            this.btnCadastroPacotes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroPacotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroPacotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnCadastroPacotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroPacotes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastroPacotes.ForeColor = System.Drawing.Color.White;
            this.btnCadastroPacotes.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_não_deixe_cair_24;
            this.btnCadastroPacotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPacotes.Location = new System.Drawing.Point(0, 120);
            this.btnCadastroPacotes.Name = "btnCadastroPacotes";
            this.btnCadastroPacotes.Size = new System.Drawing.Size(136, 59);
            this.btnCadastroPacotes.TabIndex = 4;
            this.btnCadastroPacotes.Text = "  Pacotes";
            this.btnCadastroPacotes.UseVisualStyleBackColor = false;
            this.btnCadastroPacotes.Click += new System.EventHandler(this.btnCadastroPacotes_Click);
            // 
            // pnlConsultas
            // 
            this.pnlConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnlConsultas.Controls.Add(this.btnConsultasCadastros);
            this.pnlConsultas.Controls.Add(this.btnConsultasReservas);
            this.pnlConsultas.Controls.Add(this.btnConsultaPagamento);
            this.pnlConsultas.Controls.Add(this.btnConsultVenda);
            this.pnlConsultas.Location = new System.Drawing.Point(429, 94);
            this.pnlConsultas.Name = "pnlConsultas";
            this.pnlConsultas.Size = new System.Drawing.Size(139, 267);
            this.pnlConsultas.TabIndex = 26;
            this.pnlConsultas.Visible = false;
            this.pnlConsultas.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlConsultas_Paint);
            // 
            // btnConsultasCadastros
            // 
            this.btnConsultasCadastros.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultasCadastros.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConsultasCadastros.FlatAppearance.BorderSize = 0;
            this.btnConsultasCadastros.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultasCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultasCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultasCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasCadastros.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnConsultasCadastros.ForeColor = System.Drawing.Color.White;
            this.btnConsultasCadastros.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_mais_2_matemática_25__1_2;
            this.btnConsultasCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultasCadastros.Location = new System.Drawing.Point(-1, 0);
            this.btnConsultasCadastros.Name = "btnConsultasCadastros";
            this.btnConsultasCadastros.Size = new System.Drawing.Size(140, 59);
            this.btnConsultasCadastros.TabIndex = 6;
            this.btnConsultasCadastros.Text = "  Cadastros";
            this.btnConsultasCadastros.UseVisualStyleBackColor = false;
            this.btnConsultasCadastros.Click += new System.EventHandler(this.btnConsultasCadastros_Click);
            // 
            // btnConsultasReservas
            // 
            this.btnConsultasReservas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultasReservas.FlatAppearance.BorderSize = 0;
            this.btnConsultasReservas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultasReservas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultasReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultasReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasReservas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnConsultasReservas.ForeColor = System.Drawing.Color.White;
            this.btnConsultasReservas.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_hotel_chekc_fora_241;
            this.btnConsultasReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultasReservas.Location = new System.Drawing.Point(-1, 65);
            this.btnConsultasReservas.Name = "btnConsultasReservas";
            this.btnConsultasReservas.Size = new System.Drawing.Size(140, 59);
            this.btnConsultasReservas.TabIndex = 7;
            this.btnConsultasReservas.Text = "   Reserva";
            this.btnConsultasReservas.UseVisualStyleBackColor = false;
            this.btnConsultasReservas.Click += new System.EventHandler(this.btnConsultasReservas_Click);
            // 
            // btnConsultaPagamento
            // 
            this.btnConsultaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultaPagamento.FlatAppearance.BorderSize = 0;
            this.btnConsultaPagamento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultaPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultaPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPagamento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnConsultaPagamento.ForeColor = System.Drawing.Color.White;
            this.btnConsultaPagamento.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_pagamento_móvel_251;
            this.btnConsultaPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaPagamento.Location = new System.Drawing.Point(-1, 130);
            this.btnConsultaPagamento.Name = "btnConsultaPagamento";
            this.btnConsultaPagamento.Size = new System.Drawing.Size(140, 59);
            this.btnConsultaPagamento.TabIndex = 19;
            this.btnConsultaPagamento.Text = "   Pagamento";
            this.btnConsultaPagamento.UseVisualStyleBackColor = false;
            this.btnConsultaPagamento.Click += new System.EventHandler(this.BtnConsultaPagamento_Click);
            // 
            // btnConsultVenda
            // 
            this.btnConsultVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultVenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultVenda.FlatAppearance.BorderSize = 0;
            this.btnConsultVenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnConsultVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultVenda.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnConsultVenda.ForeColor = System.Drawing.Color.White;
            this.btnConsultVenda.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_venda_24;
            this.btnConsultVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultVenda.Location = new System.Drawing.Point(0, 195);
            this.btnConsultVenda.Name = "btnConsultVenda";
            this.btnConsultVenda.Size = new System.Drawing.Size(140, 59);
            this.btnConsultVenda.TabIndex = 17;
            this.btnConsultVenda.Text = "Venda";
            this.btnConsultVenda.UseVisualStyleBackColor = false;
            this.btnConsultVenda.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnlAgenda.Controls.Add(this.btnAgendaReservas);
            this.pnlAgenda.Location = new System.Drawing.Point(144, 94);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.Size = new System.Drawing.Size(134, 76);
            this.pnlAgenda.TabIndex = 26;
            this.pnlAgenda.Visible = false;
            this.pnlAgenda.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlAgenda_Paint);
            this.pnlAgenda.MouseLeave += new System.EventHandler(this.PnlAgenda_MouseLeave);
            // 
            // btnAgendaReservas
            // 
            this.btnAgendaReservas.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendaReservas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgendaReservas.FlatAppearance.BorderSize = 0;
            this.btnAgendaReservas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnAgendaReservas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnAgendaReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnAgendaReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendaReservas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAgendaReservas.ForeColor = System.Drawing.Color.White;
            this.btnAgendaReservas.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_hotel_chekc_fora_24;
            this.btnAgendaReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendaReservas.Location = new System.Drawing.Point(-2, 3);
            this.btnAgendaReservas.Name = "btnAgendaReservas";
            this.btnAgendaReservas.Size = new System.Drawing.Size(136, 59);
            this.btnAgendaReservas.TabIndex = 9;
            this.btnAgendaReservas.Text = "   Reservas";
            this.btnAgendaReservas.UseVisualStyleBackColor = false;
            this.btnAgendaReservas.Click += new System.EventHandler(this.BtnAgendaReservas_Click);
            // 
            // pnlPagamento
            // 
            this.pnlPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnlPagamento.Controls.Add(this.btnPagamento);
            this.pnlPagamento.Location = new System.Drawing.Point(284, 94);
            this.pnlPagamento.Name = "pnlPagamento";
            this.pnlPagamento.Size = new System.Drawing.Size(139, 76);
            this.pnlPagamento.TabIndex = 27;
            this.pnlPagamento.Visible = false;
            this.pnlPagamento.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPagamento_Paint);
            this.pnlPagamento.MouseLeave += new System.EventHandler(this.PnlPagamento_MouseLeave);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.Transparent;
            this.btnPagamento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPagamento.FlatAppearance.BorderSize = 0;
            this.btnPagamento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnPagamento.ForeColor = System.Drawing.Color.White;
            this.btnPagamento.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_pagamento_móvel_25;
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamento.Location = new System.Drawing.Point(0, 0);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(138, 59);
            this.btnPagamento.TabIndex = 18;
            this.btnPagamento.Text = "    Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AgenciaDeTurismo.Properties.Resources.logo_agencia__6_;
            this.pictureBox2.Location = new System.Drawing.Point(380, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AgenciaDeTurismo.Properties.Resources.logo_agencia___6_1;
            this.pictureBox1.Location = new System.Drawing.Point(300, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(599, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sobre nós:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Location = new System.Drawing.Point(591, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 160);
            this.panel2.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(599, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "A empresa Sky Blue, é";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Location = new System.Drawing.Point(603, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 2);
            this.panel3.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(599, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "uma empresa voltada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(599, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "à venda de pacotes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(599, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "turísticos nacionais,";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label7.Location = new System.Drawing.Point(599, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "que englobam diversos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label8.Location = new System.Drawing.Point(599, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "pontos paradisíacos e";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label9.Location = new System.Drawing.Point(599, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "realizam o sonho de uma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label10.Location = new System.Drawing.Point(599, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "viagem perfeita.";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(799, 491);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlConsultas);
            this.Controls.Add(this.pnlPagamento);
            this.Controls.Add(this.pnlAgenda);
            this.Controls.Add(this.gbDataHora);
            this.Controls.Add(this.pnlCadastros);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.gbDataHora.ResumeLayout(false);
            this.gbDataHora.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlCadastros.ResumeLayout(false);
            this.pnlConsultas.ResumeLayout(false);
            this.pnlAgenda.ResumeLayout(false);
            this.pnlPagamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfigCor;
        private System.Windows.Forms.Button btnAgendaReservas;
        private System.Windows.Forms.Button btnConsultasReservas;
        private System.Windows.Forms.Button btnConsultasCadastros;
        private System.Windows.Forms.Button btnCadastroPacotes;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroFunc;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbDataHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnConsultVenda;
        private System.Windows.Forms.Button btnConsultaPagamento;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMenuCadastros;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.Button btnMenuPag;
        private System.Windows.Forms.Button btnMenuAgenda;
        private System.Windows.Forms.Panel pnlCadastros;
        private System.Windows.Forms.Panel pnlConsultas;
        private System.Windows.Forms.Panel pnlPagamento;
        private System.Windows.Forms.Panel pnlAgenda;
        private System.Windows.Forms.Button btnMenuCons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}