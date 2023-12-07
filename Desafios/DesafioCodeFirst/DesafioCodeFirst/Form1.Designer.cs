namespace DesafioCodeFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNavProd = new Button();
            btnNavForn = new Button();
            btnExit = new Button();
            btnNavClient = new Button();
            btnNavNotes = new Button();
            lblChoice = new Label();
            SuspendLayout();
            // 
            // btnNavProd
            // 
            btnNavProd.BackColor = SystemColors.ActiveCaption;
            btnNavProd.BackgroundImageLayout = ImageLayout.None;
            btnNavProd.Cursor = Cursors.Hand;
            btnNavProd.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavProd.ForeColor = SystemColors.Info;
            btnNavProd.Location = new Point(12, 351);
            btnNavProd.Name = "btnNavProd";
            btnNavProd.Size = new Size(223, 87);
            btnNavProd.TabIndex = 0;
            btnNavProd.Text = "Inserir Produto";
            btnNavProd.UseVisualStyleBackColor = false;
            btnNavProd.Click += NavProd;
            // 
            // btnNavForn
            // 
            btnNavForn.BackColor = SystemColors.ActiveCaption;
            btnNavForn.Cursor = Cursors.Hand;
            btnNavForn.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavForn.ForeColor = SystemColors.Info;
            btnNavForn.Location = new Point(254, 351);
            btnNavForn.Name = "btnNavForn";
            btnNavForn.Size = new Size(223, 87);
            btnNavForn.TabIndex = 1;
            btnNavForn.Text = "Cadastrar Fornecedores";
            btnNavForn.UseVisualStyleBackColor = false;
            btnNavForn.Click += NavForn;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.Info;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(12, 457);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(953, 105);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += Back;
            // 
            // btnNavClient
            // 
            btnNavClient.BackColor = SystemColors.ActiveCaption;
            btnNavClient.Cursor = Cursors.Hand;
            btnNavClient.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavClient.ForeColor = SystemColors.Info;
            btnNavClient.Location = new Point(498, 351);
            btnNavClient.Name = "btnNavClient";
            btnNavClient.Size = new Size(223, 87);
            btnNavClient.TabIndex = 3;
            btnNavClient.Text = "Cadastrar Cliente";
            btnNavClient.UseVisualStyleBackColor = false;
            btnNavClient.Click += NavCliente;
            // 
            // btnNavNotes
            // 
            btnNavNotes.BackColor = SystemColors.ActiveCaption;
            btnNavNotes.Cursor = Cursors.Hand;
            btnNavNotes.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavNotes.ForeColor = SystemColors.Info;
            btnNavNotes.Location = new Point(742, 351);
            btnNavNotes.Name = "btnNavNotes";
            btnNavNotes.Size = new Size(223, 87);
            btnNavNotes.TabIndex = 4;
            btnNavNotes.Text = "Gerar Nota";
            btnNavNotes.UseVisualStyleBackColor = false;
            btnNavNotes.Click += NavNote;
            // 
            // lblChoice
            // 
            lblChoice.AutoSize = true;
            lblChoice.BackColor = Color.Transparent;
            lblChoice.Font = new Font("Tw Cen MT Condensed Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblChoice.ForeColor = Color.LightCoral;
            lblChoice.Location = new Point(18, 9);
            lblChoice.Name = "lblChoice";
            lblChoice.Size = new Size(947, 114);
            lblChoice.TabIndex = 5;
            lblChoice.Text = "O que gostaria de fazer?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(980, 574);
            Controls.Add(lblChoice);
            Controls.Add(btnNavNotes);
            Controls.Add(btnNavClient);
            Controls.Add(btnExit);
            Controls.Add(btnNavForn);
            Controls.Add(btnNavProd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNavProd;
        private Button btnNavForn;
        private Button btnExit;
        private Button btnNavClient;
        private Button btnNavNotes;
        private Label lblChoice;
    }
}
