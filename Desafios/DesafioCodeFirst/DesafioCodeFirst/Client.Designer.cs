namespace DesafioCodeFirst
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label7 = new Label();
            btnBack = new Button();
            btnAdd = new Button();
            tbNome = new TextBox();
            dgvClient = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbCpf = new TextBox();
            label3 = new Label();
            tbIdade = new TextBox();
            dtpDatNasc = new DateTimePicker();
            label4 = new Label();
            tbTel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClient).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(13, 31);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 40;
            label7.Text = "Nome:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCoral;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.Firebrick;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(13, 312);
            btnBack.Margin = new Padding(1, 3, 1, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 87);
            btnBack.TabIndex = 39;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += Back;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(127, 312);
            btnAdd.Margin = new Padding(1, 3, 1, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(364, 87);
            btnAdd.TabIndex = 38;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Add;
            // 
            // tbNome
            // 
            tbNome.BackColor = SystemColors.Window;
            tbNome.ForeColor = SystemColors.WindowText;
            tbNome.Location = new Point(64, 29);
            tbNome.Margin = new Padding(1, 3, 1, 3);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(430, 22);
            tbNome.TabIndex = 36;
            // 
            // dgvClient
            // 
            dgvClient.AllowUserToAddRows = false;
            dgvClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Sem dado";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClient.ColumnHeadersHeight = 20;
            dgvClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tw Cen MT", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Sem Valor";
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClient.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClient.Location = new Point(545, 12);
            dgvClient.Margin = new Padding(1, 3, 1, 3);
            dgvClient.Name = "dgvClient";
            dgvClient.ReadOnly = true;
            dgvClient.RowTemplate.Height = 25;
            dgvClient.Size = new Size(433, 385);
            dgvClient.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(13, 195);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 42;
            label1.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(13, 113);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 44;
            label2.Text = "CPF:";
            // 
            // tbCpf
            // 
            tbCpf.BackColor = SystemColors.Window;
            tbCpf.ForeColor = SystemColors.WindowText;
            tbCpf.Location = new Point(49, 110);
            tbCpf.Margin = new Padding(1, 3, 1, 3);
            tbCpf.Name = "tbCpf";
            tbCpf.PlaceholderText = "Apenas Números";
            tbCpf.Size = new Size(444, 22);
            tbCpf.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(13, 70);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 46;
            label3.Text = "Idade:";
            // 
            // tbIdade
            // 
            tbIdade.BackColor = SystemColors.Window;
            tbIdade.ForeColor = SystemColors.WindowText;
            tbIdade.Location = new Point(57, 67);
            tbIdade.Margin = new Padding(1, 3, 1, 3);
            tbIdade.Name = "tbIdade";
            tbIdade.Size = new Size(437, 22);
            tbIdade.TabIndex = 45;
            // 
            // dtpDatNasc
            // 
            dtpDatNasc.CalendarForeColor = Color.White;
            dtpDatNasc.CalendarMonthBackground = SystemColors.HotTrack;
            dtpDatNasc.Format = DateTimePickerFormat.Short;
            dtpDatNasc.Location = new Point(134, 189);
            dtpDatNasc.Margin = new Padding(1, 3, 1, 3);
            dtpDatNasc.Name = "dtpDatNasc";
            dtpDatNasc.Size = new Size(360, 22);
            dtpDatNasc.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(13, 153);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 49;
            label4.Text = "Telefone:";
            // 
            // tbTel
            // 
            tbTel.BackColor = SystemColors.Window;
            tbTel.ForeColor = SystemColors.WindowText;
            tbTel.Location = new Point(71, 150);
            tbTel.Margin = new Padding(1, 3, 1, 3);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(423, 22);
            tbTel.TabIndex = 48;
            // 
            // frmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(988, 408);
            Controls.Add(label4);
            Controls.Add(tbTel);
            Controls.Add(dtpDatNasc);
            Controls.Add(label3);
            Controls.Add(tbIdade);
            Controls.Add(label2);
            Controls.Add(tbCpf);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(tbNome);
            Controls.Add(dgvClient);
            Font = new Font("Tw Cen MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.WindowText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1, 3, 1, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)dgvClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button btnBack;
        private Button btnAdd;
        private TextBox tbNome;
        private DataGridView dgvClient;
        private Label label1;
        private Label label2;
        private TextBox tbCpf;
        private Label label3;
        private TextBox tbIdade;
        private DateTimePicker dtpDatNasc;
        private Label label4;
        private TextBox tbTel;
    }
}