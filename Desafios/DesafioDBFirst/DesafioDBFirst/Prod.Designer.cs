namespace DesafioDBFirst
{
    partial class Prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prod));
            tbPreco = new TextBox();
            button1 = new Button();
            tbForn = new TextBox();
            label6 = new Label();
            btnAdd = new Button();
            tbNome = new TextBox();
            tbDesc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvProd = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            SuspendLayout();
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(61, 178);
            tbPreco.Margin = new Padding(4, 3, 4, 3);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(529, 22);
            tbPreco.TabIndex = 51;
            tbPreco.Click += Add;
            // 
            // button1
            // 
            button1.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(18, 359);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 58);
            button1.TabIndex = 50;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Back;
            // 
            // tbForn
            // 
            tbForn.Location = new Point(96, 137);
            tbForn.Margin = new Padding(4, 3, 4, 3);
            tbForn.Name = "tbForn";
            tbForn.PlaceholderText = "ID do Fonercedor";
            tbForn.Size = new Size(494, 22);
            tbForn.TabIndex = 49;
            tbForn.Click += Add;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 140);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 48;
            label6.Text = "Fornecedor:";
            label6.Click += Add;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(125, 359);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(465, 58);
            btnAdd.TabIndex = 47;
            btnAdd.Text = "Cadastrar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(66, 97);
            tbNome.Margin = new Padding(4, 3, 4, 3);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(524, 22);
            tbNome.TabIndex = 46;
            tbNome.Click += Add;
            // 
            // tbDesc
            // 
            tbDesc.Location = new Point(86, 216);
            tbDesc.Margin = new Padding(4, 3, 4, 3);
            tbDesc.Multiline = true;
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(504, 122);
            tbDesc.TabIndex = 45;
            tbDesc.Click += Add;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 100);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 16);
            label5.TabIndex = 44;
            label5.Text = "Nome:";
            label5.Click += Add;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 181);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 43;
            label4.Text = "Preco";
            label4.Click += Add;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 216);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 42;
            label3.Text = "Descrição:";
            label3.Click += Add;
            // 
            // dgvProd
            // 
            dgvProd.AllowUserToAddRows = false;
            dgvProd.AllowUserToDeleteRows = false;
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProd.Location = new Point(15, 437);
            dgvProd.Margin = new Padding(4, 3, 4, 3);
            dgvProd.Name = "dgvProd";
            dgvProd.ReadOnly = true;
            dgvProd.RowTemplate.Height = 25;
            dgvProd.Size = new Size(575, 381);
            dgvProd.TabIndex = 41;
            dgvProd.Click += Add;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(227, 10);
            label1.Name = "label1";
            label1.Size = new Size(144, 47);
            label1.TabIndex = 40;
            label1.Text = "Produto";
            label1.Click += Add;
            // 
            // Prod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 829);
            Controls.Add(tbPreco);
            Controls.Add(button1);
            Controls.Add(tbForn);
            Controls.Add(label6);
            Controls.Add(btnAdd);
            Controls.Add(tbNome);
            Controls.Add(tbDesc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvProd);
            Controls.Add(label1);
            Font = new Font("Tw Cen MT", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Prod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prod";
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPreco;
        private Button button1;
        private TextBox tbForn;
        private Label label6;
        private Button btnAdd;
        private TextBox tbNome;
        private TextBox tbDesc;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvProd;
        private Label label1;
    }
}