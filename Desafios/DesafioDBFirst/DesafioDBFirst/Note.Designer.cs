namespace DesafioDBFirst
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            button1 = new Button();
            tbClient = new TextBox();
            label6 = new Label();
            btnAdd = new Button();
            tbProd = new TextBox();
            label4 = new Label();
            label1 = new Label();
            dgvNote = new DataGridView();
            tbMetPagamento = new TextBox();
            label2 = new Label();
            tbDatCompra = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNote).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(16, 246);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 53);
            button1.TabIndex = 47;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Back;
            // 
            // tbClient
            // 
            tbClient.Location = new Point(66, 82);
            tbClient.Margin = new Padding(4, 3, 4, 3);
            tbClient.Name = "tbClient";
            tbClient.PlaceholderText = "ID do Cliente";
            tbClient.Size = new Size(524, 22);
            tbClient.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 85);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 16);
            label6.TabIndex = 45;
            label6.Text = "Cliente:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(123, 246);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(465, 53);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Inserir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add;
            // 
            // tbProd
            // 
            tbProd.Location = new Point(77, 125);
            tbProd.Margin = new Padding(4, 3, 4, 3);
            tbProd.Name = "tbProd";
            tbProd.PlaceholderText = "CÓDIGO do Produto";
            tbProd.Size = new Size(513, 22);
            tbProd.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 16);
            label4.TabIndex = 40;
            label4.Text = "Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 47);
            label1.TabIndex = 39;
            label1.Text = "Notas";
            // 
            // dgvNote
            // 
            dgvNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNote.Location = new Point(13, 320);
            dgvNote.Margin = new Padding(4, 3, 4, 3);
            dgvNote.Name = "dgvNote";
            dgvNote.RowTemplate.Height = 25;
            dgvNote.Size = new Size(575, 377);
            dgvNote.TabIndex = 38;
            // 
            // tbMetPagamento
            // 
            tbMetPagamento.Location = new Point(181, 165);
            tbMetPagamento.Margin = new Padding(4, 3, 4, 3);
            tbMetPagamento.Name = "tbMetPagamento";
            tbMetPagamento.Size = new Size(409, 22);
            tbMetPagamento.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 16);
            label2.TabIndex = 48;
            label2.Text = "Método de Pagamamento:";
            // 
            // tbDatCompra
            // 
            tbDatCompra.Location = new Point(130, 207);
            tbDatCompra.Margin = new Padding(4, 3, 4, 3);
            tbDatCompra.Name = "tbDatCompra";
            tbDatCompra.PlaceholderText = "Hoje";
            tbDatCompra.Size = new Size(460, 22);
            tbDatCompra.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 210);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 16);
            label3.TabIndex = 50;
            label3.Text = "Data da Compra:";
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 714);
            Controls.Add(tbDatCompra);
            Controls.Add(label3);
            Controls.Add(tbMetPagamento);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(tbClient);
            Controls.Add(label6);
            Controls.Add(btnAdd);
            Controls.Add(tbProd);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dgvNote);
            Font = new Font("Tw Cen MT", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Note";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)dgvNote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbClient;
        private Label label6;
        private Button btnAdd;
        private TextBox tbProd;
        private Label label4;
        private Label label1;
        private DataGridView dgvNote;
        private TextBox tbMetPagamento;
        private Label label2;
        private TextBox tbDatCompra;
        private Label label3;
    }
}