namespace DesafioDBFirst
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
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 360);
            button1.Name = "button1";
            button1.Size = new Size(155, 71);
            button1.TabIndex = 2;
            button1.Text = "Fornecedores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NavigateForn;
            // 
            // button5
            // 
            button5.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(355, 360);
            button5.Name = "button5";
            button5.Size = new Size(75, 71);
            button5.TabIndex = 9;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Exit;
            // 
            // button4
            // 
            button4.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(620, 360);
            button4.Name = "button4";
            button4.Size = new Size(155, 71);
            button4.TabIndex = 8;
            button4.Text = "Notas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NavigateNote;
            // 
            // button3
            // 
            button3.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(446, 360);
            button3.Name = "button3";
            button3.Size = new Size(155, 71);
            button3.TabIndex = 7;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NavigateClient;
            // 
            // button2
            // 
            button2.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(185, 360);
            button2.Name = "button2";
            button2.Size = new Size(155, 71);
            button2.TabIndex = 6;
            button2.Text = "Produtos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NavigateProd;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT Condensed", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(727, 92);
            label1.TabIndex = 10;
            label1.Text = "O que gostaria de fazer?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(787, 443);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
    }
}
