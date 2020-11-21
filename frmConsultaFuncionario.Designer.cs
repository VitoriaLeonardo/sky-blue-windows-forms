namespace AgenciaDeTurismo
{
    partial class frmConsultaFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConsFuncionario = new System.Windows.Forms.DataGridView();
            this.txtIdConsFunc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskCpfConsFunc = new System.Windows.Forms.MaskedTextBox();
            this.mskTelConsFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailConsFunc = new System.Windows.Forms.TextBox();
            this.txtNomeConsFunc = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltConsFunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsFuncionario)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsFuncionario
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsFuncionario.Location = new System.Drawing.Point(12, 106);
            this.dgvConsFuncionario.MultiSelect = false;
            this.dgvConsFuncionario.Name = "dgvConsFuncionario";
            this.dgvConsFuncionario.ReadOnly = true;
            this.dgvConsFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsFuncionario.Size = new System.Drawing.Size(544, 199);
            this.dgvConsFuncionario.TabIndex = 0;
            this.dgvConsFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgvConsFuncionario.SelectionChanged += new System.EventHandler(this.DgvConsFuncionario_SelectionChanged_1);
            // 
            // txtIdConsFunc
            // 
            this.txtIdConsFunc.Location = new System.Drawing.Point(654, 131);
            this.txtIdConsFunc.Name = "txtIdConsFunc";
            this.txtIdConsFunc.ReadOnly = true;
            this.txtIdConsFunc.Size = new System.Drawing.Size(100, 20);
            this.txtIdConsFunc.TabIndex = 29;
            this.txtIdConsFunc.TextChanged += new System.EventHandler(this.TxtIdConsFunc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(617, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(605, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(568, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(593, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(587, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome:";
            // 
            // mskCpfConsFunc
            // 
            this.mskCpfConsFunc.Location = new System.Drawing.Point(654, 266);
            this.mskCpfConsFunc.Mask = "000.000.000-00";
            this.mskCpfConsFunc.Name = "mskCpfConsFunc";
            this.mskCpfConsFunc.Size = new System.Drawing.Size(100, 20);
            this.mskCpfConsFunc.TabIndex = 23;
            // 
            // mskTelConsFunc
            // 
            this.mskTelConsFunc.Location = new System.Drawing.Point(654, 230);
            this.mskTelConsFunc.Mask = "(00)00000-0000";
            this.mskTelConsFunc.Name = "mskTelConsFunc";
            this.mskTelConsFunc.Size = new System.Drawing.Size(100, 20);
            this.mskTelConsFunc.TabIndex = 22;
            // 
            // txtEmailConsFunc
            // 
            this.txtEmailConsFunc.Location = new System.Drawing.Point(654, 198);
            this.txtEmailConsFunc.MaxLength = 150;
            this.txtEmailConsFunc.Name = "txtEmailConsFunc";
            this.txtEmailConsFunc.Size = new System.Drawing.Size(100, 20);
            this.txtEmailConsFunc.TabIndex = 20;
            // 
            // txtNomeConsFunc
            // 
            this.txtNomeConsFunc.Location = new System.Drawing.Point(654, 165);
            this.txtNomeConsFunc.MaxLength = 50;
            this.txtNomeConsFunc.Name = "txtNomeConsFunc";
            this.txtNomeConsFunc.Size = new System.Drawing.Size(100, 20);
            this.txtNomeConsFunc.TabIndex = 19;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAlterar.Location = new System.Drawing.Point(398, 357);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 25);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnVoltConsFunc
            // 
            this.btnVoltConsFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnVoltConsFunc.FlatAppearance.BorderSize = 0;
            this.btnVoltConsFunc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVoltConsFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoltConsFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltConsFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltConsFunc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnVoltConsFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnVoltConsFunc.Location = new System.Drawing.Point(295, 357);
            this.btnVoltConsFunc.Name = "btnVoltConsFunc";
            this.btnVoltConsFunc.Size = new System.Drawing.Size(97, 25);
            this.btnVoltConsFunc.TabIndex = 17;
            this.btnVoltConsFunc.Text = "Voltar ";
            this.btnVoltConsFunc.UseVisualStyleBackColor = false;
            this.btnVoltConsFunc.Click += new System.EventHandler(this.BtnVoltConsFunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Consulta funcionário";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 30);
            this.panel3.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AgenciaDeTurismo.Properties.Resources.icons8_fechar_janela_40;
            this.button1.Location = new System.Drawing.Point(721, 6);
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
            this.button2.Location = new System.Drawing.Point(689, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(766, 403);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvConsFuncionario);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltConsFunc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdConsFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCpfConsFunc);
            this.Controls.Add(this.mskTelConsFunc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmailConsFunc);
            this.Controls.Add(this.txtNomeConsFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaFuncionario";
            this.Load += new System.EventHandler(this.FrmConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsFuncionario)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsFuncionario;
        private System.Windows.Forms.Button btnVoltConsFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtIdConsFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskCpfConsFunc;
        private System.Windows.Forms.MaskedTextBox mskTelConsFunc;
        private System.Windows.Forms.TextBox txtEmailConsFunc;
        private System.Windows.Forms.TextBox txtNomeConsFunc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}