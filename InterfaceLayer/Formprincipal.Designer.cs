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
            this.lblSistemadegestaodebiblioteca = new Label();

            this.btnGerirLivros = new Button();
            this.btnGerirSocios = new Button();
            this.btnEmprestimos = new Button();
            this.btnestatisticas = new Button();
            this.button5 = new Button();

            this.SuspendLayout();

            // lblSistemadegestaodebiblioteca
            this.lblSistemadegestaodebiblioteca.AutoSize = true;
            this.lblSistemadegestaodebiblioteca.Location = new Point(293, 9);
            this.lblSistemadegestaodebiblioteca.Name = "lblSistemadegestaodebiblioteca";
            this.lblSistemadegestaodebiblioteca.Size = new Size(265, 25);
            this.lblSistemadegestaodebiblioteca.TabIndex = 0;
            this.lblSistemadegestaodebiblioteca.Text = "Sistema de Gestão de Biblioteca";

            // btnGerirLivros
            this.btnGerirLivros.Location = new Point(381, 67);
            this.btnGerirLivros.Name = "btnGerirLivros";
            this.btnGerirLivros.Size = new Size(112, 34);
            this.btnGerirLivros.TabIndex = 1;
            this.btnGerirLivros.Text = "Gerir Livros";
            this.btnGerirLivros.UseVisualStyleBackColor = true;

            // btnGerirSocios
            this.btnGerirSocios.Location = new Point(381, 119);
            this.btnGerirSocios.Name = "btnGerirSocios";
            this.btnGerirSocios.Size = new Size(150, 34);
            this.btnGerirSocios.TabIndex = 2;
            this.btnGerirSocios.Text = "Gerir Sócios";
            this.btnGerirSocios.UseVisualStyleBackColor = true;

            // btnEmprestimos
            this.btnEmprestimos.Location = new Point(381, 173);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new Size(128, 34);
            this.btnEmprestimos.TabIndex = 3;
            this.btnEmprestimos.Text = "Empréstimos";
            this.btnEmprestimos.UseVisualStyleBackColor = true;

            // btnestatisticas
            this.btnestatisticas.Location = new Point(381, 238);
            this.btnestatisticas.Name = "btnestatisticas";
            this.btnestatisticas.Size = new Size(112, 34);
            this.btnestatisticas.TabIndex = 4;
            this.btnestatisticas.Text = "Estatísticas";
            this.btnestatisticas.UseVisualStyleBackColor = true;

            // button5
            this.button5.Location = new Point(375, 322);
            this.button5.Name = "button5";
            this.button5.Size = new Size(112, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;

            // Formprincipal
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);

            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnestatisticas);
            this.Controls.Add(this.btnEmprestimos);
            this.Controls.Add(this.btnGerirSocios);
            this.Controls.Add(this.btnGerirLivros);
            this.Controls.Add(this.lblSistemadegestaodebiblioteca);

            this.Name = "Formprincipal";
            this.Text = "Formprincipal";

            this.ResumeLayout(false);
            this.PerformLayout();
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