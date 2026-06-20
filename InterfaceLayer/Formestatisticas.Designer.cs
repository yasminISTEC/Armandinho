namespace InterfaceLayer
{
    partial class Formestatisticas
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
            this.lblEstatisticas = new Label();
            this.lblLivroMaisRequisitado = new Label();
            this.lblSociomaisativo = new Label();
            this.lblEmprestimosporrealizar = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.btnVoltar = new Button();

            this.SuspendLayout();

            // lblEstatisticas
            this.lblEstatisticas.AutoSize = true;
            this.lblEstatisticas.Location = new Point(232, 34);
            this.lblEstatisticas.Name = "lblEstatisticas";
            this.lblEstatisticas.Size = new Size(97, 25);
            this.lblEstatisticas.TabIndex = 0;
            this.lblEstatisticas.Text = "Estatísticas";

            // lblLivroMaisRequisitado
            this.lblLivroMaisRequisitado.AutoSize = true;
            this.lblLivroMaisRequisitado.Location = new Point(232, 73);
            this.lblLivroMaisRequisitado.Name = "lblLivroMaisRequisitado";
            this.lblLivroMaisRequisitado.Size = new Size(186, 25);
            this.lblLivroMaisRequisitado.TabIndex = 1;
            this.lblLivroMaisRequisitado.Text = "Livro mais requisitado";

            // lblSociomaisativo
            this.lblSociomaisativo.AutoSize = true;
            this.lblSociomaisativo.Location = new Point(240, 170);
            this.lblSociomaisativo.Name = "lblSociomaisativo";
            this.lblSociomaisativo.Size = new Size(145, 25);
            this.lblSociomaisativo.TabIndex = 2;
            this.lblSociomaisativo.Text = "Sócio Mais Ativo";

            // lblEmprestimosporrealizar
            this.lblEmprestimosporrealizar.AutoSize = true;
            this.lblEmprestimosporrealizar.Location = new Point(240, 251);
            this.lblEmprestimosporrealizar.Name = "lblEmprestimosporrealizar";
            this.lblEmprestimosporrealizar.Size = new Size(209, 25);
            this.lblEmprestimosporrealizar.TabIndex = 3;
            this.lblEmprestimosporrealizar.Text = "Empréstimos por realizar";

            // textBox1
            this.textBox1.Location = new Point(240, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(150, 31);
            this.textBox1.TabIndex = 4;

            // textBox2
            this.textBox2.Location = new Point(240, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(150, 31);
            this.textBox2.TabIndex = 5;

            // textBox3
            this.textBox3.Location = new Point(240, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(150, 31);
            this.textBox3.TabIndex = 6;

            // btnVoltar
            this.btnVoltar.Location = new Point(265, 344);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new Size(112, 34);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;

            // Formestatisticas
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEmprestimosporrealizar);
            this.Controls.Add(this.lblSociomaisativo);
            this.Controls.Add(this.lblLivroMaisRequisitado);
            this.Controls.Add(this.lblEstatisticas);
            this.Name = "Formestatisticas";
            this.Text = "Formestatisticas";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblEstatisticas;
        private Label lblLivroMaisRequisitado;
        private Label lblSociomaisativo;
        private Label lblEmprestimosporrealizar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnVoltar;
    }
}