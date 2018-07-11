namespace WindowsFormsAppControleDeVendas
{
    partial class FormLancamentoDeHistorico
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
            this.radioButtonCNPJ = new System.Windows.Forms.RadioButton();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonLocalizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.radioButtonDATA = new System.Windows.Forms.RadioButton();
            this.radioButtonNOME = new System.Windows.Forms.RadioButton();
            this.groupBoxListaDepartamentos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxEdicao = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProdutos_Servicos = new System.Windows.Forms.ComboBox();
            this.comboBoxPessoas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOperacao = new System.Windows.Forms.ComboBox();
            this.buttonDataHora = new System.Windows.Forms.Button();
            this.maskedTextBoxDataHora = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxBotoes.SuspendLayout();
            this.groupBoxListaDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxEdicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.radioButtonNOME);
            this.groupBoxBotoes.Controls.Add(this.radioButtonDATA);
            this.groupBoxBotoes.Controls.Add(this.comboBoxLocalizar);
            this.groupBoxBotoes.Controls.Add(this.radioButtonCNPJ);
            this.groupBoxBotoes.Controls.Add(this.radioButtonCPF);
            this.groupBoxBotoes.Controls.Add(this.buttonNovo);
            this.groupBoxBotoes.Controls.Add(this.buttonLocalizar);
            this.groupBoxBotoes.Controls.Add(this.buttonSalvar);
            this.groupBoxBotoes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(847, 66);
            this.groupBoxBotoes.TabIndex = 2;
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
            // 
            // radioButtonCNPJ
            // 
            this.radioButtonCNPJ.AutoSize = true;
            this.radioButtonCNPJ.Location = new System.Drawing.Point(251, 39);
            this.radioButtonCNPJ.Name = "radioButtonCNPJ";
            this.radioButtonCNPJ.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCNPJ.TabIndex = 9;
            this.radioButtonCNPJ.Text = "CNPJ";
            this.radioButtonCNPJ.UseVisualStyleBackColor = true;
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.Checked = true;
            this.radioButtonCPF.Location = new System.Drawing.Point(251, 16);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(45, 17);
            this.radioButtonCPF.TabIndex = 8;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
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
            // 
            // radioButtonDATA
            // 
            this.radioButtonDATA.AutoSize = true;
            this.radioButtonDATA.Location = new System.Drawing.Point(316, 16);
            this.radioButtonDATA.Name = "radioButtonDATA";
            this.radioButtonDATA.Size = new System.Drawing.Size(54, 17);
            this.radioButtonDATA.TabIndex = 11;
            this.radioButtonDATA.Text = "DATA";
            this.radioButtonDATA.UseVisualStyleBackColor = true;
            // 
            // radioButtonNOME
            // 
            this.radioButtonNOME.AutoSize = true;
            this.radioButtonNOME.Location = new System.Drawing.Point(316, 39);
            this.radioButtonNOME.Name = "radioButtonNOME";
            this.radioButtonNOME.Size = new System.Drawing.Size(57, 17);
            this.radioButtonNOME.TabIndex = 12;
            this.radioButtonNOME.Text = "NOME";
            this.radioButtonNOME.UseVisualStyleBackColor = true;
            // 
            // groupBoxListaDepartamentos
            // 
            this.groupBoxListaDepartamentos.Controls.Add(this.dataGridView1);
            this.groupBoxListaDepartamentos.Location = new System.Drawing.Point(13, 84);
            this.groupBoxListaDepartamentos.Name = "groupBoxListaDepartamentos";
            this.groupBoxListaDepartamentos.Size = new System.Drawing.Size(847, 205);
            this.groupBoxListaDepartamentos.TabIndex = 3;
            this.groupBoxListaDepartamentos.TabStop = false;
            this.groupBoxListaDepartamentos.Text = "Históricos de Vendas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxEdicao
            // 
            this.groupBoxEdicao.Controls.Add(this.maskedTextBoxDataHora);
            this.groupBoxEdicao.Controls.Add(this.buttonDataHora);
            this.groupBoxEdicao.Controls.Add(this.comboBoxOperacao);
            this.groupBoxEdicao.Controls.Add(this.label6);
            this.groupBoxEdicao.Controls.Add(this.maskedTextBoxPreco);
            this.groupBoxEdicao.Controls.Add(this.label5);
            this.groupBoxEdicao.Controls.Add(this.maskedTextBoxQuantidade);
            this.groupBoxEdicao.Controls.Add(this.label4);
            this.groupBoxEdicao.Controls.Add(this.comboBoxPessoas);
            this.groupBoxEdicao.Controls.Add(this.comboBoxProdutos_Servicos);
            this.groupBoxEdicao.Controls.Add(this.label3);
            this.groupBoxEdicao.Controls.Add(this.label2);
            this.groupBoxEdicao.Controls.Add(this.label1);
            this.groupBoxEdicao.Location = new System.Drawing.Point(13, 295);
            this.groupBoxEdicao.Name = "groupBoxEdicao";
            this.groupBoxEdicao.Size = new System.Drawing.Size(847, 221);
            this.groupBoxEdicao.TabIndex = 4;
            this.groupBoxEdicao.TabStop = false;
            this.groupBoxEdicao.Text = "Edição ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pessoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data/Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item/Serviço";
            // 
            // comboBoxProdutos_Servicos
            // 
            this.comboBoxProdutos_Servicos.FormattingEnabled = true;
            this.comboBoxProdutos_Servicos.Location = new System.Drawing.Point(141, 96);
            this.comboBoxProdutos_Servicos.Name = "comboBoxProdutos_Servicos";
            this.comboBoxProdutos_Servicos.Size = new System.Drawing.Size(403, 21);
            this.comboBoxProdutos_Servicos.TabIndex = 5;
            this.comboBoxProdutos_Servicos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdutos_Servicos_SelectedIndexChanged);
            // 
            // comboBoxPessoas
            // 
            this.comboBoxPessoas.FormattingEnabled = true;
            this.comboBoxPessoas.Location = new System.Drawing.Point(141, 65);
            this.comboBoxPessoas.Name = "comboBoxPessoas";
            this.comboBoxPessoas.Size = new System.Drawing.Size(403, 21);
            this.comboBoxPessoas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade";
            // 
            // maskedTextBoxQuantidade
            // 
            this.maskedTextBoxQuantidade.Location = new System.Drawing.Point(141, 127);
            this.maskedTextBoxQuantidade.Mask = "0000000.00";
            this.maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            this.maskedTextBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxQuantidade.TabIndex = 8;
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(141, 161);
            this.maskedTextBoxPreco.Mask = "$ 999999,999";
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPreco.TabIndex = 10;
            this.maskedTextBoxPreco.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPreco_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo da Operação";
            // 
            // comboBoxOperacao
            // 
            this.comboBoxOperacao.FormattingEnabled = true;
            this.comboBoxOperacao.Location = new System.Drawing.Point(141, 190);
            this.comboBoxOperacao.Name = "comboBoxOperacao";
            this.comboBoxOperacao.Size = new System.Drawing.Size(403, 21);
            this.comboBoxOperacao.TabIndex = 12;
            // 
            // buttonDataHora
            // 
            this.buttonDataHora.Location = new System.Drawing.Point(271, 24);
            this.buttonDataHora.Name = "buttonDataHora";
            this.buttonDataHora.Size = new System.Drawing.Size(24, 23);
            this.buttonDataHora.TabIndex = 13;
            this.buttonDataHora.Text = "...";
            this.buttonDataHora.UseVisualStyleBackColor = true;
            this.buttonDataHora.Click += new System.EventHandler(this.buttonDataHora_Click);
            // 
            // maskedTextBoxDataHora
            // 
            this.maskedTextBoxDataHora.Location = new System.Drawing.Point(141, 24);
            this.maskedTextBoxDataHora.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataHora.Name = "maskedTextBoxDataHora";
            this.maskedTextBoxDataHora.Size = new System.Drawing.Size(124, 20);
            this.maskedTextBoxDataHora.TabIndex = 14;
            this.maskedTextBoxDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // FormLancamentoDeHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 547);
            this.Controls.Add(this.groupBoxEdicao);
            this.Controls.Add(this.groupBoxListaDepartamentos);
            this.Controls.Add(this.groupBoxBotoes);
            this.Name = "FormLancamentoDeHistorico";
            this.Text = "Lançamento de Historico de Vendas";
            this.groupBoxBotoes.ResumeLayout(false);
            this.groupBoxBotoes.PerformLayout();
            this.groupBoxListaDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxEdicao.ResumeLayout(false);
            this.groupBoxEdicao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.ComboBox comboBoxLocalizar;
        private System.Windows.Forms.RadioButton radioButtonCNPJ;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonLocalizar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.RadioButton radioButtonNOME;
        private System.Windows.Forms.RadioButton radioButtonDATA;
        private System.Windows.Forms.GroupBox groupBoxListaDepartamentos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxEdicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPessoas;
        private System.Windows.Forms.ComboBox comboBoxProdutos_Servicos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOperacao;
        private System.Windows.Forms.Button buttonDataHora;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataHora;
    }
}