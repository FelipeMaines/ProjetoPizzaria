namespace ProjetoPizzaria.ModuloCep
{
    partial class TelaCepForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(28, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(266, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 23);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(266, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(28, 138);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(218, 23);
            comboBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(291, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(372, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 9;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 17);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 10;
            label2.Text = "CEP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 17);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 11;
            label3.Text = "Logradouro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 64);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 12;
            label4.Text = "País";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 64);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 13;
            label5.Text = "UF";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 120);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 14;
            label6.Text = "Cidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 120);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 15;
            label7.Text = "Bairro";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(146, 35);
            maskedTextBox1.Mask = "00 . 000 - 000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 16;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TelaCepForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 233);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TelaCepForm";
            Text = "TelaCepForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
    }
}