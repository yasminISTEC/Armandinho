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
            lblEstatisticas = new Label();
            lblLivroMaisRequisitado = new Label();
            lblSociomaisativo = new Label();
            lblEmprestimosporrealizar = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblEstatisticas
            // 
            lblEstatisticas.AutoSize = true;
            lblEstatisticas.Location = new Point(232, 34);
            lblEstatisticas.Name = "lblEstatisticas";
            lblEstatisticas.Size = new Size(97, 25);
            lblEstatisticas.TabIndex = 0;
            lblEstatisticas.Text = "Estatísticas";
            // 
            // lblLivroMaisRequisitado
            // 
            lblLivroMaisRequisitado.AutoSize = true;
            lblLivroMaisRequisitado.Location = new Point(232, 73);
            lblLivroMaisRequisitado.Name = "lblLivroMaisRequisitado";
            lblLivroMaisRequisitado.Size = new Size(186, 25);
            lblLivroMaisRequisitado.TabIndex = 1;
            lblLivroMaisRequisitado.Text = "Livro mais requisitado";
            // 
            // lblSociomaisativo
            // 
            lblSociomaisativo.AutoSize = true;
            lblSociomaisativo.Location = new Point(240, 170);
            lblSociomaisativo.Name = "lblSociomaisativo";
            lblSociomaisativo.Size = new Size(145, 25);
            lblSociomaisativo.TabIndex = 2;
            lblSociomaisativo.Text = "Sócio Mais Ativo";
            // 
            // lblEmprestimosporrealizar
            // 
            lblEmprestimosporrealizar.AutoSize = true;
            lblEmprestimosporrealizar.Location = new Point(240, 251);
            lblEmprestimosporrealizar.Name = "lblEmprestimosporrealizar";
            lblEmprestimosporrealizar.Size = new Size(209, 25);
            lblEmprestimosporrealizar.TabIndex = 3;
            lblEmprestimosporrealizar.Text = "Empréstimos por realizar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(265, 344);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Formestatisticas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblEmprestimosporrealizar);
            Controls.Add(lblSociomaisativo);
            Controls.Add(lblLivroMaisRequisitado);
            Controls.Add(lblEstatisticas);
            Name = "Formestatisticas";
            Text = "Formestatisticas";
            ResumeLayout(false);
            PerformLayout();
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