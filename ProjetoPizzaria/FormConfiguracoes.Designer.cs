namespace ProjetoPizzaria
{
    partial class FormConfiguracoes
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
            tabControl1 = new TabControl();
            tabPageIdiomaRegiao = new TabPage();
            lbRegiao = new Label();
            comboBoxIdioma = new ComboBox();
            tabPage2 = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPageIdiomaRegiao.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageIdiomaRegiao);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(432, 182);
            tabControl1.TabIndex = 0;
            // 
            // tabPageIdiomaRegiao
            // 
            tabPageIdiomaRegiao.Controls.Add(lbRegiao);
            tabPageIdiomaRegiao.Controls.Add(comboBoxIdioma);
            tabPageIdiomaRegiao.Location = new Point(4, 24);
            tabPageIdiomaRegiao.Name = "tabPageIdiomaRegiao";
            tabPageIdiomaRegiao.Padding = new Padding(3);
            tabPageIdiomaRegiao.Size = new Size(424, 154);
            tabPageIdiomaRegiao.TabIndex = 0;
            tabPageIdiomaRegiao.Text = "Idioma/Região";
            tabPageIdiomaRegiao.UseVisualStyleBackColor = true;
            // 
            // lbRegiao
            // 
            lbRegiao.AutoSize = true;
            lbRegiao.Location = new Point(18, 12);
            lbRegiao.Name = "lbRegiao";
            lbRegiao.Size = new Size(85, 15);
            lbRegiao.TabIndex = 1;
            lbRegiao.Text = "Idioma/Região";
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Location = new Point(18, 30);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(121, 23);
            comboBoxIdioma.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(424, 154);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(357, 200);
            button1.Name = "button1";
            button1.Size = new Size(83, 39);
            button1.TabIndex = 1;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 241);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "FormConfiguracoes";
            Text = "FormConfiguracoes";
            tabControl1.ResumeLayout(false);
            tabPageIdiomaRegiao.ResumeLayout(false);
            tabPageIdiomaRegiao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageIdiomaRegiao;
        private Label lbRegiao;
        private ComboBox comboBoxIdioma;
        private TabPage tabPage2;
        private Button button1;
    }
}