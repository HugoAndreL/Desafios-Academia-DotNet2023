namespace DesafioDBFirst
{
    partial class Forn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forn));
            tbFuncao = new TextBox();
            button1 = new Button();
            tbCNPJ = new TextBox();
            label6 = new Label();
            btnAdd = new Button();
            tbNome = new TextBox();
            tbDatCriacao = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dgvForn = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvForn).BeginInit();
            SuspendLayout();
            // 
            // tbFuncao
            // 
            tbFuncao.Location = new Point(71, 180);
            tbFuncao.Margin = new Padding(4, 3, 4, 3);
            tbFuncao.Multiline = true;
            tbFuncao.Name = "tbFuncao";
            tbFuncao.Size = new Size(519, 127);
            tbFuncao.TabIndex = 28;
            // 
            // button1
            // 
            button1.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(18, 363);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 58);
            button1.TabIndex = 27;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Back;
            // 
            // tbCNPJ
            // 
            tbCNPJ.Location = new Point(62, 141);
            tbCNPJ.Margin = new Padding(4, 3, 4, 3);
            tbCNPJ.Name = "tbCNPJ";
            tbCNPJ.Size = new Size(528, 22);
            tbCNPJ.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 144);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 16);
            label6.TabIndex = 25;
            label6.Text = "CNPJ:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(125, 363);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(465, 58);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Cadastrar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(66, 101);
            tbNome.Margin = new Padding(4, 3, 4, 3);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(524, 22);
            tbNome.TabIndex = 23;
            // 
            // tbDatCriacao
            // 
            tbDatCriacao.Location = new Point(128, 324);
            tbDatCriacao.Margin = new Padding(4, 3, 4, 3);
            tbDatCriacao.Name = "tbDatCriacao";
            tbDatCriacao.Size = new Size(462, 22);
            tbDatCriacao.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 16);
            label5.TabIndex = 21;
            label5.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 327);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 16);
            label4.TabIndex = 20;
            label4.Text = "Data de Criação:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 183);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 19;
            label3.Text = "Função:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 47);
            label1.TabIndex = 18;
            label1.Text = "Fornecedor";
            // 
            // dgvForn
            // 
            dgvForn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvForn.Location = new Point(15, 441);
            dgvForn.Margin = new Padding(4, 3, 4, 3);
            dgvForn.Name = "dgvForn";
            dgvForn.RowTemplate.Height = 25;
            dgvForn.Size = new Size(575, 377);
            dgvForn.TabIndex = 17;
            // 
            // Forn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 829);
            Controls.Add(tbFuncao);
            Controls.Add(button1);
            Controls.Add(tbCNPJ);
            Controls.Add(label6);
            Controls.Add(btnAdd);
            Controls.Add(tbNome);
            Controls.Add(tbDatCriacao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvForn);
            Font = new Font("Tw Cen MT", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Forn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forn";
            ((System.ComponentModel.ISupportInitialize)dgvForn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFuncao;
        private Button button1;
        private TextBox tbCNPJ;
        private Label label6;
        private Button btnAdd;
        private TextBox tbNome;
        private TextBox tbDatCriacao;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dgvForn;
    }
}