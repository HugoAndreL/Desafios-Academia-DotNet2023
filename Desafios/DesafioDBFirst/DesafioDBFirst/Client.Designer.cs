namespace DesafioDBFirst
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            button1 = new Button();
            tbCPF = new TextBox();
            label6 = new Label();
            btnAdd = new Button();
            tbNome = new TextBox();
            tbDatNasc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dgvForn = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvForn).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(18, 223);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 58);
            button1.TabIndex = 37;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Back;
            // 
            // tbCPF
            // 
            tbCPF.Location = new Point(54, 141);
            tbCPF.Margin = new Padding(4, 3, 4, 3);
            tbCPF.Name = "tbCPF";
            tbCPF.PlaceholderText = "Apenas números";
            tbCPF.Size = new Size(536, 22);
            tbCPF.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 144);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 16);
            label6.TabIndex = 35;
            label6.Text = "CPF:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(125, 223);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(465, 58);
            btnAdd.TabIndex = 34;
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
            tbNome.TabIndex = 33;
            // 
            // tbDatNasc
            // 
            tbDatNasc.Location = new Point(147, 184);
            tbDatNasc.Margin = new Padding(4, 3, 4, 3);
            tbDatNasc.Name = "tbDatNasc";
            tbDatNasc.Size = new Size(443, 22);
            tbDatNasc.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 16);
            label5.TabIndex = 31;
            label5.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 187);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 16);
            label4.TabIndex = 30;
            label4.Text = "Data de Nascimento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 47);
            label1.TabIndex = 29;
            label1.Text = "Cliente";
            // 
            // dgvForn
            // 
            dgvForn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvForn.Location = new Point(15, 301);
            dgvForn.Margin = new Padding(4, 3, 4, 3);
            dgvForn.Name = "dgvForn";
            dgvForn.RowTemplate.Height = 25;
            dgvForn.Size = new Size(575, 382);
            dgvForn.TabIndex = 28;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 695);
            Controls.Add(button1);
            Controls.Add(tbCPF);
            Controls.Add(label6);
            Controls.Add(btnAdd);
            Controls.Add(tbNome);
            Controls.Add(tbDatNasc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dgvForn);
            Font = new Font("Tw Cen MT", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)dgvForn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbCPF;
        private Label label6;
        private Button btnAdd;
        private TextBox tbNome;
        private TextBox tbDatNasc;
        private Label label5;
        private Label label4;
        private Label label1;
        private DataGridView dgvForn;
    }
}