namespace TrabalhoFinal2._0
{
    partial class Form2
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
            System.Windows.Forms.Label nome_do_FilmeLabel;
            System.Windows.Forms.Label horárioLabel;
            System.Windows.Forms.Label salaLabel;
            System.Windows.Forms.Label preço_do_IngressoLabel;
            System.Windows.Forms.Label cadeirasLabel;
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabela_de_FilmesDataSet = new TrabalhoFinal2._0.Tabela_de_FilmesDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new TrabalhoFinal2._0.Tabela_de_FilmesDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new TrabalhoFinal2._0.Tabela_de_FilmesDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreNósToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nome_do_FilmeTextBox = new System.Windows.Forms.TextBox();
            this.horárioTextBox = new System.Windows.Forms.TextBox();
            this.salaTextBox = new System.Windows.Forms.TextBox();
            this.preço_do_IngressoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadeirasTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            nome_do_FilmeLabel = new System.Windows.Forms.Label();
            horárioLabel = new System.Windows.Forms.Label();
            salaLabel = new System.Windows.Forms.Label();
            preço_do_IngressoLabel = new System.Windows.Forms.Label();
            cadeirasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_de_FilmesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_do_FilmeLabel
            // 
            nome_do_FilmeLabel.AutoSize = true;
            nome_do_FilmeLabel.Enabled = false;
            nome_do_FilmeLabel.Location = new System.Drawing.Point(460, 244);
            nome_do_FilmeLabel.Name = "nome_do_FilmeLabel";
            nome_do_FilmeLabel.Size = new System.Drawing.Size(80, 13);
            nome_do_FilmeLabel.TabIndex = 22;
            nome_do_FilmeLabel.Text = "Nome do Filme:";
            nome_do_FilmeLabel.Click += new System.EventHandler(this.nome_do_FilmeLabel_Click);
            // 
            // horárioLabel
            // 
            horárioLabel.AutoSize = true;
            horárioLabel.Enabled = false;
            horárioLabel.Location = new System.Drawing.Point(460, 270);
            horárioLabel.Name = "horárioLabel";
            horárioLabel.Size = new System.Drawing.Size(44, 13);
            horárioLabel.TabIndex = 24;
            horárioLabel.Text = "Horário:";
            horárioLabel.Click += new System.EventHandler(this.horárioLabel_Click);
            // 
            // salaLabel
            // 
            salaLabel.AutoSize = true;
            salaLabel.Enabled = false;
            salaLabel.Location = new System.Drawing.Point(460, 296);
            salaLabel.Name = "salaLabel";
            salaLabel.Size = new System.Drawing.Size(31, 13);
            salaLabel.TabIndex = 26;
            salaLabel.Text = "Sala:";
            salaLabel.Click += new System.EventHandler(this.salaLabel_Click);
            // 
            // preço_do_IngressoLabel
            // 
            preço_do_IngressoLabel.AutoSize = true;
            preço_do_IngressoLabel.Enabled = false;
            preço_do_IngressoLabel.Location = new System.Drawing.Point(460, 322);
            preço_do_IngressoLabel.Name = "preço_do_IngressoLabel";
            preço_do_IngressoLabel.Size = new System.Drawing.Size(96, 13);
            preço_do_IngressoLabel.TabIndex = 28;
            preço_do_IngressoLabel.Text = "Preço do Ingresso:";
            preço_do_IngressoLabel.Click += new System.EventHandler(this.preço_do_IngressoLabel_Click);
            // 
            // cadeirasLabel
            // 
            cadeirasLabel.AutoSize = true;
            cadeirasLabel.Enabled = false;
            cadeirasLabel.Location = new System.Drawing.Point(460, 346);
            cadeirasLabel.Name = "cadeirasLabel";
            cadeirasLabel.Size = new System.Drawing.Size(51, 13);
            cadeirasLabel.TabIndex = 37;
            cadeirasLabel.Text = "Cadeiras:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Código de Segurança:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Número do Cartão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome do Titular do Cartão:";
            // 
            // tabela_de_FilmesDataSet
            // 
            this.tabela_de_FilmesDataSet.DataSetName = "Tabela_de_FilmesDataSet";
            this.tabela_de_FilmesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.tabela_de_FilmesDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = TrabalhoFinal2._0.Tabela_de_FilmesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.sobreNósToolStripMenuItem,
            this.sACToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.entrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // sobreNósToolStripMenuItem
            // 
            this.sobreNósToolStripMenuItem.Name = "sobreNósToolStripMenuItem";
            this.sobreNósToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.sobreNósToolStripMenuItem.Text = "Sobre Nós";
            // 
            // sACToolStripMenuItem
            // 
            this.sACToolStripMenuItem.Name = "sACToolStripMenuItem";
            this.sACToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.sACToolStripMenuItem.Text = "SAC";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.entrarToolStripMenuItem.Text = "Perfil";
            // 
            // nome_do_FilmeTextBox
            // 
            this.nome_do_FilmeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nome do Filme", true));
            this.nome_do_FilmeTextBox.Enabled = false;
            this.nome_do_FilmeTextBox.Location = new System.Drawing.Point(562, 241);
            this.nome_do_FilmeTextBox.Name = "nome_do_FilmeTextBox";
            this.nome_do_FilmeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_do_FilmeTextBox.TabIndex = 23;
            this.nome_do_FilmeTextBox.TextChanged += new System.EventHandler(this.nome_do_FilmeTextBox_TextChanged);
            // 
            // horárioTextBox
            // 
            this.horárioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Horário", true));
            this.horárioTextBox.Enabled = false;
            this.horárioTextBox.Location = new System.Drawing.Point(562, 267);
            this.horárioTextBox.Name = "horárioTextBox";
            this.horárioTextBox.Size = new System.Drawing.Size(100, 20);
            this.horárioTextBox.TabIndex = 25;
            this.horárioTextBox.TextChanged += new System.EventHandler(this.horárioTextBox_TextChanged);
            // 
            // salaTextBox
            // 
            this.salaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Sala", true));
            this.salaTextBox.Enabled = false;
            this.salaTextBox.Location = new System.Drawing.Point(562, 293);
            this.salaTextBox.Name = "salaTextBox";
            this.salaTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaTextBox.TabIndex = 27;
            this.salaTextBox.TextChanged += new System.EventHandler(this.salaTextBox_TextChanged);
            // 
            // preço_do_IngressoTextBox
            // 
            this.preço_do_IngressoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Preço do Ingresso", true));
            this.preço_do_IngressoTextBox.Enabled = false;
            this.preço_do_IngressoTextBox.Location = new System.Drawing.Point(562, 319);
            this.preço_do_IngressoTextBox.Name = "preço_do_IngressoTextBox";
            this.preço_do_IngressoTextBox.Size = new System.Drawing.Size(100, 20);
            this.preço_do_IngressoTextBox.TabIndex = 29;
            this.preço_do_IngressoTextBox.TextChanged += new System.EventHandler(this.preço_do_IngressoTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Finalizar Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(600, 115);
            this.maskedTextBox1.Mask = "###.###.###-##";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBox1.TabIndex = 32;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(600, 138);
            this.maskedTextBox2.Mask = "#### #### #### ####";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBox2.TabIndex = 33;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(600, 161);
            this.maskedTextBox3.Mask = "###";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox3.TabIndex = 34;
            this.maskedTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(600, 187);
            this.maskedTextBox4.Mask = "##/##/####";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(62, 20);
            this.maskedTextBox4.TabIndex = 35;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(31, 63);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.Size = new System.Drawing.Size(414, 220);
            this.tableDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome do Filme";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Filme";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Horário";
            this.dataGridViewTextBoxColumn2.HeaderText = "Horário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cadeiras";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cadeiras";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sala";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sala";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Preço do Ingresso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço do Ingresso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // cadeirasTextBox
            // 
            this.cadeirasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Cadeiras", true));
            this.cadeirasTextBox.Enabled = false;
            this.cadeirasTextBox.Location = new System.Drawing.Point(562, 343);
            this.cadeirasTextBox.Name = "cadeirasTextBox";
            this.cadeirasTextBox.Size = new System.Drawing.Size(100, 20);
            this.cadeirasTextBox.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Cadeiras selecionadas: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(600, 213);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 40;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "(MÁX 4)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 454);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(cadeirasLabel);
            this.Controls.Add(this.cadeirasTextBox);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nome_do_FilmeLabel);
            this.Controls.Add(this.nome_do_FilmeTextBox);
            this.Controls.Add(horárioLabel);
            this.Controls.Add(this.horárioTextBox);
            this.Controls.Add(salaLabel);
            this.Controls.Add(this.salaTextBox);
            this.Controls.Add(preço_do_IngressoLabel);
            this.Controls.Add(this.preço_do_IngressoTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Sistema do Usuário";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_de_FilmesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Tabela_de_FilmesDataSet tabela_de_FilmesDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Tabela_de_FilmesDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Tabela_de_FilmesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreNósToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.TextBox nome_do_FilmeTextBox;
        private System.Windows.Forms.TextBox horárioTextBox;
        private System.Windows.Forms.TextBox salaTextBox;
        private System.Windows.Forms.TextBox preço_do_IngressoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox cadeirasTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
    }
}