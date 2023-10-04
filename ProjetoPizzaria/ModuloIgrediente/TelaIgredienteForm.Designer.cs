namespace ProjetoPizzaria.ModuloIgrediente
{
    partial class TelaIgredienteForm
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
            lbId = new Label();
            lbNome = new Label();
            txId = new TextBox();
            txNome = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(23, 23);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 0;
            lbId.Text = "Id";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(148, 23);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // txId
            // 
            txId.Location = new Point(23, 41);
            txId.Name = "txId";
            txId.Size = new Size(100, 23);
            txId.TabIndex = 0;
            // 
            // txNome
            // 
            txNome.Location = new Point(148, 41);
            txNome.Name = "txNome";
            txNome.Size = new Size(219, 23);
            txNome.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(211, 97);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 40);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(292, 97);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaIgredienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 149);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(txNome);
            Controls.Add(txId);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            KeyPreview = true;
            Name = "TelaIgredienteForm";
            Text = "CadastroIgredienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbNome;
        private TextBox txId;
        private TextBox txNome;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}