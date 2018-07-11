namespace WindowsFormsAppControleDeVendas
{
    partial class FormCadastrodeDepartamentos
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
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.comboBoxLocalizar = new System.Windows.Forms.ComboBox();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonLocalizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBoxListaDepartamentos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxEdicao = new System.Windows.Forms.GroupBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxBotoes.SuspendLayout();
            this.groupBoxListaDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxEdicao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.comboBoxLocalizar);
            this.groupBoxBotoes.Controls.Add(this.radioButtonDescricao);
            this.groupBoxBotoes.Controls.Add(this.radioButtonID);
            this.groupBoxBotoes.Controls.Add(this.buttonNovo);
            this.groupBoxBotoes.Controls.Add(this.buttonLocalizar);
            this.groupBoxBotoes.Controls.Add(this.buttonSalvar);
            this.groupBoxBotoes.Location = new System.Drawing.Point(15, 12);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(847, 66);
            this.groupBoxBotoes.TabIndex = 1;
            this.groupBoxBotoes.TabStop = false;
            this.groupBoxBotoes.Text = "Botões de Ação ";
            // 
            // comboBoxLocalizar
            // 
            this.comboBoxLocalizar.FormattingEnabled = true;
            this.comboBoxLocalizar.Location = new System.Drawing.Point(445, 16);
            this.comboBoxLocalizar.Name = "comboBoxLocalizar";
            this.comboBoxLocalizar.Size = new System.Drawing.Size(382, 21);
            this.comboBoxLocalizar.TabIndex = 10;
            this.comboBoxLocalizar.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocalizar_SelectedIndexChanged);
            // 
            // radioButtonDescricao
            // 
            this.radioButtonDescricao.AutoSize = true;
            this.radioButtonDescricao.Location = new System.Drawing.Point(251, 39);
            this.radioButtonDescricao.Name = "radioButtonDescricao";
            this.radioButtonDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDescricao.TabIndex = 9;
            this.radioButtonDescricao.Text = "Descrição";
            this.radioButtonDescricao.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Checked = true;
            this.radioButtonID.Location = new System.Drawing.Point(251, 16);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(36, 17);
            this.radioButtonID.TabIndex = 8;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonNovo.Location = new System.Drawing.Point(170, 19);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovo.TabIndex = 7;
            this.buttonNovo.Text = "&Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonLocalizar
            // 
            this.buttonLocalizar.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonLocalizar.Location = new System.Drawing.Point(92, 18);
            this.buttonLocalizar.Name = "buttonLocalizar";
            this.buttonLocalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonLocalizar.TabIndex = 1;
            this.buttonLocalizar.Text = "&Localizar";
            this.buttonLocalizar.UseVisualStyleBackColor = false;
            this.buttonLocalizar.Click += new System.EventHandler(this.buttonLocalizar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSalvar.Location = new System.Drawing.Point(16, 19);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // groupBoxListaDepartamentos
            // 
            this.groupBoxListaDepartamentos.Controls.Add(this.dataGridView1);
            this.groupBoxListaDepartamentos.Location = new System.Drawing.Point(15, 84);
            this.groupBoxListaDepartamentos.Name = "groupBoxListaDepartamentos";
            this.groupBoxListaDepartamentos.Size = new System.Drawing.Size(847, 205);
            this.groupBoxListaDepartamentos.TabIndex = 2;
            this.groupBoxListaDepartamentos.TabStop = false;
            this.groupBoxListaDepartamentos.Text = "Lista de Departamentos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBoxEdicao
            // 
            this.groupBoxEdicao.Controls.Add(this.textBoxDescricao);
            this.groupBoxEdicao.Controls.Add(this.textBoxID);
            this.groupBoxEdicao.Controls.Add(this.label2);
            this.groupBoxEdicao.Controls.Add(this.label1);
            this.groupBoxEdicao.Location = new System.Drawing.Point(15, 296);
            this.groupBoxEdicao.Name = "groupBoxEdicao";
            this.groupBoxEdicao.Size = new System.Drawing.Size(847, 148);
            this.groupBoxEdicao.TabIndex = 3;
            this.groupBoxEdicao.TabStop = false;
            this.groupBoxEdicao.Text = "Edição ";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(92, 75);
            this.textBoxDescricao.MaxLength = 70;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(735, 20);
            this.textBoxDescricao.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(92, 32);
            this.textBoxID.MaxLength = 14;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(153, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botões de Ação ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(445, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(382, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocalizar_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(170, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Novo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(92, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Localizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonLocalizar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Location = new System.Drawing.Point(16, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "&Salvar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(15, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Departamentos";
            // 
            // FormCadastrodeDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 456);
            this.Controls.Add(this.groupBoxEdicao);
            this.Controls.Add(this.groupBoxListaDepartamentos);
            this.Controls.Add(this.groupBoxBotoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormCadastrodeDepartamentos";
            this.Text = "Cadastro de Departamentos";
            this.groupBoxBotoes.ResumeLayout(false);
            this.groupBoxBotoes.PerformLayout();
            this.groupBoxListaDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxEdicao.ResumeLayout(false);
            this.groupBoxEdicao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonLocalizar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.GroupBox groupBoxListaDepartamentos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxEdicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.ComboBox comboBoxLocalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}