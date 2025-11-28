namespace Roteiro9
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
            txtNome = new TextBox();
            btnSalvar = new Button();
            btnListar = new Button();
            listarUsuarios = new ListBox();
            panel1 = new Panel();
            btnDeletar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSobrenome = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 14);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(3, 67);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(3, 102);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 29);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // listarUsuarios
            // 
            listarUsuarios.FormattingEnabled = true;
            listarUsuarios.Location = new Point(448, 27);
            listarUsuarios.Name = "listarUsuarios";
            listarUsuarios.Size = new Size(328, 284);
            listarUsuarios.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtSobrenome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDeletar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnListar);
            panel1.Controls.Add(listarUsuarios);
            panel1.Controls.Add(btnSalvar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 333);
            panel1.TabIndex = 4;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(3, 137);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 5;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 17);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 6;
            label2.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(292, 14);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(125, 27);
            txtSobrenome.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private Button btnSalvar;
        private Button btnListar;
        private ListBox listarUsuarios;
        private Panel panel1;
        private Label label1;
        private Button btnDeletar;
        private TextBox txtSobrenome;
        private Label label2;
    }
}
