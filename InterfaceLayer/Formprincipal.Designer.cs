namespace InterfaceLayer
{
    partial class Formprincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblSistemadegestaodebiblioteca = new Label();
            btnGerirLivros = new Button();
            btnGerirSocios = new Button();
            btnEmprestimos = new Button();
            btnestatisticas = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // lblSistemadegestaodebiblioteca
            // 
            lblSistemadegestaodebiblioteca.AutoSize = true;
            lblSistemadegestaodebiblioteca.Location = new Point(293, 9);
            lblSistemadegestaodebiblioteca.Name = "lblSistemadegestaodebiblioteca";
            lblSistemadegestaodebiblioteca.Size = new Size(265, 25);
            lblSistemadegestaodebiblioteca.TabIndex = 0;
            lblSistemadegestaodebiblioteca.Text = "Sistema de Gestão de Biblioteca";
            // 
            // btnGerirLivros
            // 
            btnGerirLivros.Location = new Point(381, 67);
            btnGerirLivros.Name = "btnGerirLivros";
            btnGerirLivros.Size = new Size(112, 34);
            btnGerirLivros.TabIndex = 1;
            btnGerirLivros.Text = "Gerir Livros";
            btnGerirLivros.UseVisualStyleBackColor = true;
            btnGerirLivros.Click += btnGerirLivros_Click;
            // 
            // btnGerirSocios
            // 
            btnGerirSocios.Location = new Point(381, 119);
            btnGerirSocios.Name = "btnGerirSocios";
            btnGerirSocios.Size = new Size(150, 34);
            btnGerirSocios.TabIndex = 2;
            btnGerirSocios.Text = "Gerir Sócios";
            btnGerirSocios.UseVisualStyleBackColor = true;
            btnGerirSocios.Click += btnGerirSocios_Click;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.Location = new Point(381, 173);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(128, 34);
            btnEmprestimos.TabIndex = 3;
            btnEmprestimos.Text = "Empréstimos";
            btnEmprestimos.UseVisualStyleBackColor = true;
            btnEmprestimos.Click += btnEmprestimos_Click;
            // 
            // btnestatisticas
            // 
            btnestatisticas.Location = new Point(381, 238);
            btnestatisticas.Name = "btnestatisticas";
            btnestatisticas.Size = new Size(112, 34);
            btnestatisticas.TabIndex = 4;
            btnestatisticas.Text = "Estatísticas";
            btnestatisticas.UseVisualStyleBackColor = true;
            btnestatisticas.Click += btnestatisticas_Click;
            // 
            // button5
            // 
            button5.Location = new Point(375, 322);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 5;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = true;
            // 
            // Formprincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(btnestatisticas);
            Controls.Add(btnEmprestimos);
            Controls.Add(btnGerirSocios);
            Controls.Add(btnGerirLivros);
            Controls.Add(lblSistemadegestaodebiblioteca);
            Name = "Formprincipal";
            Text = "Formprincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSistemadegestaodebiblioteca;

        private Button btnGerirLivros;
        private Button btnGerirSocios;
        private Button btnEmprestimos;
        private Button btnestatisticas;
        private Button button5;
    }
}