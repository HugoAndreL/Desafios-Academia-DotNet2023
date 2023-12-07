namespace DesafioCodeFirst
{
    partial class frmProd
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProd));
            btnBack = new Button();
            btnAdd = new Button();
            label3 = new Label();
            tbForn = new TextBox();
            tbNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblForn = new Label();
            lblNome = new Label();
            dgvProd = new DataGridView();
            lblPreco = new Label();
            tbPreco = new TextBox();
            lblDesc = new Label();
            tbDesc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCoral;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(12, 311);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 86);
            btnBack.TabIndex = 21;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += Back;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(130, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(364, 86);
            btnAdd.TabIndex = 20;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Add;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-78, 142);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 16;
            label3.Text = "Função:";
            // 
            // tbForn
            // 
            tbForn.Location = new Point(88, 74);
            tbForn.Name = "tbForn";
            tbForn.PlaceholderText = "CÓDIGO do Fornecedor";
            tbForn.Size = new Size(405, 22);
            tbForn.TabIndex = 15;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(65, 28);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(428, 22);
            tbNome.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-78, 98);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "CNPJ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-78, 52);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome:";
            // 
            // lblForn
            // 
            lblForn.AutoSize = true;
            lblForn.ForeColor = Color.White;
            lblForn.Location = new Point(12, 77);
            lblForn.Name = "lblForn";
            lblForn.Size = new Size(70, 15);
            lblForn.TabIndex = 23;
            lblForn.Text = "Fornecedor:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(12, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(42, 15);
            lblNome.TabIndex = 22;
            lblNome.Text = "Nome:";
            // 
            // dgvProd
            // 
            dgvProd.AllowUserToAddRows = false;
            dgvProd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Sem dado";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProd.ColumnHeadersHeight = 30;
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tw Cen MT", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Sem Valor";
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProd.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProd.Location = new Point(545, 12);
            dgvProd.Margin = new Padding(1, 3, 1, 3);
            dgvProd.Name = "dgvProd";
            dgvProd.ReadOnly = true;
            dgvProd.RowTemplate.Height = 25;
            dgvProd.Size = new Size(433, 385);
            dgvProd.TabIndex = 36;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.ForeColor = Color.White;
            lblPreco.Location = new Point(13, 121);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 38;
            lblPreco.Text = "Preço:";
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(59, 118);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(435, 22);
            tbPreco.TabIndex = 37;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(13, 164);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(60, 15);
            lblDesc.TabIndex = 40;
            lblDesc.Text = "Descrição:";
            // 
            // tbDesc
            // 
            tbDesc.Location = new Point(80, 161);
            tbDesc.Multiline = true;
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(414, 127);
            tbDesc.TabIndex = 39;
            // 
            // frmProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(988, 409);
            Controls.Add(lblDesc);
            Controls.Add(tbDesc);
            Controls.Add(lblPreco);
            Controls.Add(tbPreco);
            Controls.Add(dgvProd);
            Controls.Add(lblForn);
            Controls.Add(lblNome);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(tbForn);
            Controls.Add(tbNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir Produto";
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnAdd;
        private Label label3;
        private TextBox tbForn;
        private TextBox tbNome;
        private Label label2;
        private Label label1;
        private Label lblForn;
        private Label lblNome;
        private DataGridView dgvProd;
        private Label lblPreco;
        private TextBox tbPreco;
        private Label lblDesc;
        private TextBox tbDesc;
    }
}