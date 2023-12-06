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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblClient = new Label();
            lblProd = new Label();
            btnBack = new Button();
            btnAdd = new Button();
            btnAddPdf = new Button();
            dgvNota = new DataGridView();
            tbProd = new TextBox();
            tbClient = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNota).BeginInit();
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
            btnBack.Location = new Point(12, 202);
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
            btnAdd.Location = new Point(130, 202);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(364, 86);
            btnAdd.TabIndex = 31;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Add;
            // 
            // btnAddPdf
            // 
            btnAddPdf.BackColor = SystemColors.Info;
            btnAddPdf.Cursor = Cursors.Hand;
            btnAddPdf.Image = Properties.Resources.pdf;
            btnAddPdf.Location = new Point(10, 311);
            btnAddPdf.Margin = new Padding(4, 3, 4, 3);
            btnAddPdf.Name = "btnAddPdf";
            btnAddPdf.Size = new Size(482, 86);
            btnAddPdf.TabIndex = 35;
            btnAddPdf.UseVisualStyleBackColor = false;
            // 
            // dgvNota
            // 
            dgvNota.AllowUserToAddRows = false;
            dgvNota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "Sem dado";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvNota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvNota.ColumnHeadersHeight = 20;
            dgvNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = "Sem Valor";
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvNota.DefaultCellStyle = dataGridViewCellStyle4;
            dgvNota.Location = new Point(545, 12);
            dgvNota.Margin = new Padding(1, 3, 1, 3);
            dgvNota.Name = "dgvNota";
            dgvNota.ReadOnly = true;
            dgvNota.RowTemplate.Height = 25;
            dgvNota.Size = new Size(433, 385);
            dgvNota.TabIndex = 36;
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
            // frmNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(988, 409);
            Controls.Add(dgvNota);
            Controls.Add(btnAddPdf);
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
            ((System.ComponentModel.ISupportInitialize)dgvNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblClient;
        private Label lblProd;
        private Button btnBack;
        private Button btnAdd;
        private Button btnAddPdf;
        private DataGridView dgvNota;
        private TextBox tbProd;
        private TextBox tbClient;
    }
}