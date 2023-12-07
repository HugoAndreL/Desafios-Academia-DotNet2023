namespace DesafioCodeFirst
{
    partial class frmNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNota));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblClient = new Label();
            lblProd = new Label();
            btnBack = new Button();
            btnAdd = new Button();
            tbProd = new TextBox();
            tbClient = new TextBox();
            dgvNotas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.ForeColor = Color.White;
            lblClient.Location = new Point(12, 77);
            lblClient.Margin = new Padding(4, 0, 4, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(47, 15);
            lblClient.TabIndex = 34;
            lblClient.Text = "Cliente:";
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.ForeColor = Color.White;
            lblProd.Location = new Point(12, 31);
            lblProd.Margin = new Padding(4, 0, 4, 0);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(51, 15);
            lblProd.TabIndex = 33;
            lblProd.Text = "Produto:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCoral;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 311);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 86);
            btnBack.TabIndex = 32;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += Back;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(129, 311);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(364, 86);
            btnAdd.TabIndex = 31;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Add;
            // 
            // tbProd
            // 
            tbProd.Location = new Point(71, 28);
            tbProd.Margin = new Padding(4, 3, 4, 3);
            tbProd.Name = "tbProd";
            tbProd.PlaceholderText = "CÓDIGO do Produto:";
            tbProd.Size = new Size(422, 22);
            tbProd.TabIndex = 27;
            // 
            // tbClient
            // 
            tbClient.Location = new Point(65, 74);
            tbClient.Margin = new Padding(4, 3, 4, 3);
            tbClient.Name = "tbClient";
            tbClient.PlaceholderText = "ID do Cliente";
            tbClient.Size = new Size(428, 22);
            tbClient.TabIndex = 28;
            // 
            // dgvNotas
            // 
            dgvNotas.AllowUserToAddRows = false;
            dgvNotas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Sem dado";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNotas.ColumnHeadersHeight = 30;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Sem Valor";
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNotas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNotas.Location = new Point(545, 12);
            dgvNotas.Margin = new Padding(1, 3, 1, 3);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.ReadOnly = true;
            dgvNotas.RowTemplate.Height = 25;
            dgvNotas.Size = new Size(433, 385);
            dgvNotas.TabIndex = 37;
            // 
            // frmNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(988, 409);
            Controls.Add(dgvNotas);
            Controls.Add(lblClient);
            Controls.Add(lblProd);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(tbClient);
            Controls.Add(tbProd);
            Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerar Nota";
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblClient;
        private Label lblProd;
        private Button btnBack;
        private Button btnAdd;
        private TextBox tbProd;
        private TextBox tbClient;
        private DataGridView dgvNotas;
    }
}