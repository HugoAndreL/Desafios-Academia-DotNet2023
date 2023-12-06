namespace DesafioCodeFirst
{
    partial class frmForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForn));
            lblNome = new Label();
            tbNome = new TextBox();
            btnAdd = new Button();
            btnBack = new Button();
            dgvForn = new DataGridView();
            tbCnpj = new TextBox();
            lblCnpj = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvForn).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(16, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(42, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(65, 28);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(428, 22);
            tbNome.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(130, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(364, 86);
            btnAdd.TabIndex = 9;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Add;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCoral;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(12, 311);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 86);
            btnBack.TabIndex = 10;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += Back;
            // 
            // dgvForn
            // 
            dgvForn.AllowUserToAddRows = false;
            dgvForn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Sem dado";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvForn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvForn.ColumnHeadersHeight = 20;
            dgvForn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Sem Valor";
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvForn.DefaultCellStyle = dataGridViewCellStyle2;
            dgvForn.Location = new Point(545, 12);
            dgvForn.Margin = new Padding(1, 3, 1, 3);
            dgvForn.Name = "dgvForn";
            dgvForn.ReadOnly = true;
            dgvForn.RowTemplate.Height = 25;
            dgvForn.Size = new Size(433, 385);
            dgvForn.TabIndex = 36;
            // 
            // tbCnpj
            // 
            tbCnpj.Location = new Point(59, 71);
            tbCnpj.Name = "tbCnpj";
            tbCnpj.Size = new Size(434, 22);
            tbCnpj.TabIndex = 38;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.ForeColor = SystemColors.ControlLightLight;
            lblCnpj.Location = new Point(16, 74);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(39, 15);
            lblCnpj.TabIndex = 37;
            lblCnpj.Text = "CNPJ:";
            // 
            // frmForn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(988, 409);
            Controls.Add(tbCnpj);
            Controls.Add(lblCnpj);
            Controls.Add(dgvForn);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(tbNome);
            Controls.Add(lblNome);
            Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmForn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Fornecedor";
            ((System.ComponentModel.ISupportInitialize)dgvForn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private TextBox tbNome;
        private Button btnAdd;
        private Button btnBack;
        private DataGridView dgvForn;
        private TextBox tbCnpj;
        private Label lblCnpj;
    }
}