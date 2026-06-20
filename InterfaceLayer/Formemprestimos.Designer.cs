namespace InterfaceLayer
{
    partial class Formemprestimos
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
            lblGestaodeemprestimos = new Label();
            label2 = new Label();
            lblSocios = new Label();
            lblLivro = new Label();
            lblData1 = new Label();
            lblData2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnRequisitar = new Button();
            btnDevolver = new Button();
            btnVoltar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblGestaodeemprestimos
            // 
            lblGestaodeemprestimos.AutoSize = true;
            lblGestaodeemprestimos.Location = new Point(299, 9);
            lblGestaodeemprestimos.Name = "lblGestaodeemprestimos";
            lblGestaodeemprestimos.Size = new Size(201, 25);
            lblGestaodeemprestimos.TabIndex = 0;
            lblGestaodeemprestimos.Text = "Gestão de Empréstimos";
            lblGestaodeemprestimos.Click += lblGestaodeemprestimos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 42);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // lblSocios
            // 
            lblSocios.AutoSize = true;
            lblSocios.Location = new Point(68, 85);
            lblSocios.Name = "lblSocios";
            lblSocios.Size = new Size(64, 25);
            lblSocios.TabIndex = 2;
            lblSocios.Text = "Sócios";
            // 
            // lblLivro
            // 
            lblLivro.AutoSize = true;
            lblLivro.Location = new Point(68, 122);
            lblLivro.Name = "lblLivro";
            lblLivro.Size = new Size(50, 25);
            lblLivro.TabIndex = 3;
            lblLivro.Text = "Livro";
            // 
            // lblData1
            // 
            lblData1.AutoSize = true;
            lblData1.Location = new Point(68, 165);
            lblData1.Name = "lblData1";
            lblData1.Size = new Size(64, 25);
            lblData1.TabIndex = 4;
            lblData1.Text = "Data 1";
            // 
            // lblData2
            // 
            lblData2.AutoSize = true;
            lblData2.Location = new Point(68, 211);
            lblData2.Name = "lblData2";
            lblData2.Size = new Size(64, 25);
            lblData2.TabIndex = 5;
            lblData2.Text = "Data 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 211);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 10;
            // 
            // btnRequisitar
            // 
            btnRequisitar.Location = new Point(179, 254);
            btnRequisitar.Name = "btnRequisitar";
            btnRequisitar.Size = new Size(112, 34);
            btnRequisitar.TabIndex = 11;
            btnRequisitar.Text = "Requisitar";
            btnRequisitar.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(490, 254);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(112, 34);
            btnDevolver.TabIndex = 12;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(358, 403);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 294);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(590, 103);
            dataGridView1.TabIndex = 13;
            // 
            // Formemprestimos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(dataGridView1);
            Controls.Add(btnDevolver);
            Controls.Add(btnRequisitar);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblData2);
            Controls.Add(lblData1);
            Controls.Add(lblLivro);
            Controls.Add(lblSocios);
            Controls.Add(label2);
            Controls.Add(lblGestaodeemprestimos);
            Name = "Formemprestimos";
            Text = "Formemprestimos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGestaodeemprestimos;
        private Label label2;
        private Label lblSocios;
        private Label lblLivro;
        private Label lblData1;
        private Label lblData2;

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;

        private Button btnRequisitar;
        private Button btnDevolver;
        private Button btnVoltar;

        private DataGridView dataGridView1;
    }
}