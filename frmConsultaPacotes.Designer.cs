namespace AgenciaDeTurismo
{
    partial class frmConsultaPacotes
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
            this.dgvConsPacotes = new System.Windows.Forms.DataGridView();
            this.txtTipoPacotes = new System.Windows.Forms.TextBox();
            this.txtOrigemPacotes = new System.Windows.Forms.TextBox();
            this.txtDestinoPacotes = new System.Windows.Forms.TextBox();
            this.txtDescPacotes = new System.Windows.Forms.TextBox();
            this.mskValorPacotes = new System.Windows.Forms.MaskedTextBox();
            this.txtIdPacotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterarPacotes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoltConsPac = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrQuPasConsPac = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsPacotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuPasConsPac)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsPacotes
            // 
            this.dgvConsPacotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvConsPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsPacotes.Location = new System.Drawing.Point(29, 106);
            this.dgvConsPacotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsPacotes.MultiSelect = false;
            this.dgvConsPacotes.Name = "dgvConsPacotes";
            this.dgvConsPacotes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsPacotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvConsPacotes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsPacotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsPacotes.Size = new System.Drawing.Size(434, 285);
            this.dgvConsPacotes.TabIndex = 0;
            this.dgvConsPacotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsPacotes_CellContentClick);
            this.dgvConsPacotes.SelectionChanged += new System.EventHandler(this.DgvConsPacotes_SelectionChanged);
            // 
            // txtTipoPacotes
            // 
            this.txtTipoPacotes.Location = new System.Drawing.Point(647, 137);
            this.txtTipoPacotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipoPacotes.Name = "txtTipoPacotes";
            this.txtTipoPacotes.Size = new System.Drawing.Size(100, 25);
            this.txtTipoPacotes.TabIndex = 1;
            this.txtTipoPacotes.TextChanged += new System.EventHandler(this.TxtTipoPacotes_TextChanged);
            // 
            // txtOrigemPacotes
            // 
            this.txtOrigemPacotes.Location = new System.Drawing.Point(647, 172);
            this.txtOrigemPacotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrigemPacotes.MaxLength = 40;
            this.txtOrigemPacotes.Name = "txtOrigemPacotes";
            this.txtOrigemPacotes.Size = new System.Drawing.Size(100, 25);
            this.txtOrigemPacotes.TabIndex = 2;
            this.txtOrigemPacotes.TextChanged += new System.EventHandler(this.TxtOrigemPacotes_TextChanged);
            // 
            // txtDestinoPacotes
            // 
            this.txtDestinoPacotes.Location = new System.Drawing.Point(647, 207);
            this.txtDestinoPacotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinoPacotes.MaxLength = 40;
            this.txtDestinoPacotes.Multiline = true;
            this.txtDestinoPacotes.Name = "txtDestinoPacotes";
            this.txtDestinoPacotes.Size = new System.Drawing.Size(100, 24);
            this.txtDestinoPacotes.TabIndex = 3;
            // 
            // txtDescPacotes
            // 
            this.txtDescPacotes.Location = new System.Drawing.Point(647, 273);
            this.txtDescPacotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescPacotes.MaxLength = 150;
            this.txtDescPacotes.Multiline = true;
            this.txtDescPacotes.Name = "txtDescPacotes";
            this.txtDescPacotes.Size = new System.Drawing.Size(100, 82);
            this.txtDescPacotes.TabIndex = 4;
            this.txtDescPacotes.TextChanged += new System.EventHandler(this.TxtDescPacotes_TextChanged);
            // 
            // mskValorPacotes
            // 
            this.mskValorPacotes.Location = new System.Drawing.Point(647, 365);
            this.mskValorPacotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskValorPacotes.Mask = "0.000,00";
            this.mskValorPacotes.Name = "mskValorPacotes";
            this.mskValorPacotes.Size = new System.Drawing.Size(100, 25);
            this.mskValorPacotes.TabIndex = 5;
            this.mskValorPacotes.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskValorPacotes_MaskInputRejected);
            // 
            // txtIdPacotes
            // 
            this.txtIdPacotes.Location = new System.Drawing.Point(647, 102);
            this.txtIdPacotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPacotes.Name = "txtIdPacotes";
            this.txtIdPacotes.ReadOnly = true;
            this.txtIdPacotes.Size = new System.Drawing.Size(100, 25);
            this.txtIdPacotes.TabIndex = 6;
            this.txtIdPacotes.TextChanged += new System.EventHandler(this.TxtIdPacotes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(606, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(505, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de pacote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(565, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Origem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(567, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(485, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descrição pacote:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(583, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor:";
            // 
            // btnAlterarPacotes
            // 
            this.btnAlterarPacotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnAlterarPacotes.FlatAppearance.BorderSize = 0;
            this.btnAlterarPacotes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAlterarPacotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlterarPacotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlterarPacotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarPacotes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarPacotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAlterarPacotes.Location = new System.Drawing.Point(392, 439);
            this.btnAlterarPacotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterarPacotes.Name = "btnAlterarPacotes";
            this.btnAlterarPacotes.Size = new System.Drawing.Size(97, 26);
            this.btnAlterarPacotes.TabIndex = 13;
            this.btnAlterarPacotes.Text = "Alterar";
            this.btnAlterarPacotes.UseVisualStyleBackColor = false;
            this.btnAlterarPacotes.Click += new System.EventHandler(this.BtnAlterarPacotes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Consulta de pacotes";
            // 
            // btnVoltConsPac
            // 
            this.btnVoltConsPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnVoltConsPac.FlatAppearance.BorderSize = 0;
            this.btnVoltConsPac.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVoltConsPac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoltConsPac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltConsPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltConsPac.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltConsPac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnVoltConsPac.Location = new System.Drawing.Point(286, 439);
            this.btnVoltConsPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltConsPac.Name = "btnVoltConsPac";
            this.btnVoltConsPac.Size = new System.Drawing.Size(97, 26);
            this.btnVoltConsPac.TabIndex = 18;
            this.btnVoltConsPac.Text = "Voltar ";
            this.btnVoltConsPac.UseVisualStyleBackColor = false;
            this.btnVoltConsPac.Click += new System.EventHandler(this.BtnVoltConsPac_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(503, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Qtd. passagens:";
            // 
            // nmrQuPasConsPac
            // 
            this.nmrQuPasConsPac.Location = new System.Drawing.Point(647, 239);
            this.nmrQuPasConsPac.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrQuPasConsPac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrQuPasConsPac.Name = "nmrQuPasConsPac";
            this.nmrQuPasConsPac.ReadOnly = true;
            this.nmrQuPasConsPac.Size = new System.Drawing.Size(100, 25);
            this.nmrQuPasConsPac.TabIndex = 20;
            this.nmrQuPasConsPac.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
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
            this.button1.Location = new System.Drawing.Point(741, 3);
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
            this.button2.Location = new System.Drawing.Point(709, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmConsultaPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(783, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnVoltConsPac);
            this.Controls.Add(this.dgvConsPacotes);
            this.Controls.Add(this.btnAlterarPacotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmrQuPasConsPac);
            this.Controls.Add(this.txtTipoPacotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDestinoPacotes);
            this.Controls.Add(this.txtDescPacotes);
            this.Controls.Add(this.txtOrigemPacotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskValorPacotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPacotes);
            this.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaPacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaPacotes";
            this.Load += new System.EventHandler(this.FrmConsultaPacotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsPacotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuPasConsPac)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsPacotes;
        private System.Windows.Forms.TextBox txtTipoPacotes;
        private System.Windows.Forms.TextBox txtOrigemPacotes;
        private System.Windows.Forms.TextBox txtDestinoPacotes;
        private System.Windows.Forms.TextBox txtDescPacotes;
        private System.Windows.Forms.MaskedTextBox mskValorPacotes;
        private System.Windows.Forms.TextBox txtIdPacotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterarPacotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltConsPac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrQuPasConsPac;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}