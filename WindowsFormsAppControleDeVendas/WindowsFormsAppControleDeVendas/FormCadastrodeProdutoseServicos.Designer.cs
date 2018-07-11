namespace WindowsFormsAppControleDeVendas
{
    partial class FormCadastrodeProdutoseServicos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProdutoseServicos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxLocalizar = new System.Windows.Forms.ComboBox();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonEAN13 = new System.Windows.Forms.RadioButton();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonLocalizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPRECO_VENDA = new System.Windows.Forms.MaskedTextBox();
            this.buttonFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDEPARTAMENTO = new System.Windows.Forms.ComboBox();
            this.textBoxUNIDADE = new System.Windows.Forms.TextBox();
            this.textBoxNOME_PRODUTO_SERVICO = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoseServicos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewProdutoseServicos);
            this.groupBox2.Location = new System.Drawing.Point(11, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 202);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Produtos e Serviços ";
            // 
            // dataGridViewProdutoseServicos
            // 
            this.dataGridViewProdutoseServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutoseServicos.Location = new System.Drawing.Point(16, 19);
            this.dataGridViewProdutoseServicos.Name = "dataGridViewProdutoseServicos";
            this.dataGridViewProdutoseServicos.Size = new System.Drawing.Size(811, 168);
            this.dataGridViewProdutoseServicos.TabIndex = 0;
            this.dataGridViewProdutoseServicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutoseServicos_CellClick);
            this.dataGridViewProdutoseServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutoseServicos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxLocalizar);
            this.groupBox1.Controls.Add(this.radioButtonDescricao);
            this.groupBox1.Controls.Add(this.radioButtonEAN13);
            this.groupBox1.Controls.Add(this.buttonNovo);
            this.groupBox1.Controls.Add(this.buttonLocalizar);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botões de Ação ";
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
            // radioButtonEAN13
            // 
            this.radioButtonEAN13.AutoSize = true;
            this.radioButtonEAN13.Checked = true;
            this.radioButtonEAN13.Location = new System.Drawing.Point(251, 16);
            this.radioButtonEAN13.Name = "radioButtonEAN13";
            this.radioButtonEAN13.Size = new System.Drawing.Size(36, 17);
            this.radioButtonEAN13.TabIndex = 8;
            this.radioButtonEAN13.TabStop = true;
            this.radioButtonEAN13.Text = "ID";
            this.radioButtonEAN13.UseVisualStyleBackColor = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBoxPRECO_VENDA);
            this.groupBox3.Controls.Add(this.buttonFoto);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.comboBoxDEPARTAMENTO);
            this.groupBox3.Controls.Add(this.textBoxUNIDADE);
            this.groupBox3.Controls.Add(this.textBoxNOME_PRODUTO_SERVICO);
            this.groupBox3.Controls.Add(this.textBoxID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(931, 215);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do produto ou serviço ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // maskedTextBoxPRECO_VENDA
            // 
            this.maskedTextBoxPRECO_VENDA.Location = new System.Drawing.Point(153, 88);
            this.maskedTextBoxPRECO_VENDA.Mask = "$ 9999999999,99";
            this.maskedTextBoxPRECO_VENDA.Name = "maskedTextBoxPRECO_VENDA";
            this.maskedTextBoxPRECO_VENDA.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPRECO_VENDA.TabIndex = 12;
            // 
            // buttonFoto
            // 
            this.buttonFoto.Location = new System.Drawing.Point(729, 183);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(156, 23);
            this.buttonFoto.TabIndex = 11;
            this.buttonFoto.Text = "Foto do Produto ou Serviço";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(677, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 160);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDEPARTAMENTO
            // 
            this.comboBoxDEPARTAMENTO.FormattingEnabled = true;
            this.comboBoxDEPARTAMENTO.Location = new System.Drawing.Point(153, 113);
            this.comboBoxDEPARTAMENTO.MaxLength = 70;
            this.comboBoxDEPARTAMENTO.Name = "comboBoxDEPARTAMENTO";
            this.comboBoxDEPARTAMENTO.Size = new System.Drawing.Size(517, 21);
            this.comboBoxDEPARTAMENTO.TabIndex = 9;
            // 
            // textBoxUNIDADE
            // 
            this.textBoxUNIDADE.Location = new System.Drawing.Point(153, 62);
            this.textBoxUNIDADE.MaxLength = 10;
            this.textBoxUNIDADE.Name = "textBoxUNIDADE";
            this.textBoxUNIDADE.Size = new System.Drawing.Size(129, 20);
            this.textBoxUNIDADE.TabIndex = 7;
            // 
            // textBoxNOME_PRODUTO_SERVICO
            // 
            this.textBoxNOME_PRODUTO_SERVICO.Location = new System.Drawing.Point(153, 38);
            this.textBoxNOME_PRODUTO_SERVICO.MaxLength = 70;
            this.textBoxNOME_PRODUTO_SERVICO.Name = "textBoxNOME_PRODUTO_SERVICO";
            this.textBoxNOME_PRODUTO_SERVICO.Size = new System.Drawing.Size(518, 20);
            this.textBoxNOME_PRODUTO_SERVICO.TabIndex = 6;
            this.textBoxNOME_PRODUTO_SERVICO.TextChanged += new System.EventHandler(this.textBoxNOME_PRODUTO_SERVICO_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(153, 13);
            this.textBoxID.MaxLength = 13;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do produto ou serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormCadastrodeProdutoseServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastrodeProdutoseServicos";
            this.Text = "Cadastro de Produtos e Serviços";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoseServicos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewProdutoseServicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxLocalizar;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.RadioButton radioButtonEAN13;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonLocalizar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUNIDADE;
        private System.Windows.Forms.TextBox textBoxNOME_PRODUTO_SERVICO;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBoxDEPARTAMENTO;
        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPRECO_VENDA;
    }
}