namespace InterfaceLayer
{
    partial class Formlivros
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
            txtISBN = new Label();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblAno = new Label();
            lblExemplares = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            btnLimpar = new Button();
            btnVoltar = new Button();
            dataGridView1 = new DataGridView();
            lblGestãodelivros = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtISBN
            // 
            txtISBN.AutoSize = true;
            txtISBN.Location = new Point(52, 70);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(50, 25);
            txtISBN.TabIndex = 0;
            txtISBN.Text = "ISBN";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(52, 104);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(52, 141);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(57, 25);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(52, 181);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(45, 25);
            lblAno.TabIndex = 3;
            lblAno.Text = "Ano";
            // 
            // lblExemplares
            // 
            lblExemplares.AutoSize = true;
            lblExemplares.Location = new Point(52, 215);
            lblExemplares.Name = "lblExemplares";
            lblExemplares.Size = new Size(101, 25);
            lblExemplares.TabIndex = 4;
            lblExemplares.Text = "Exemplares";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(239, 178);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(239, 215);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(39, 279);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(210, 279);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(379, 279);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(112, 34);
            btnRemover.TabIndex = 12;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += button3_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(556, 279);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button4_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(306, 474);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 333);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 113);
            dataGridView1.TabIndex = 15;
            // 
            // lblGestãodelivros
            // 
            lblGestãodelivros.AutoSize = true;
            lblGestãodelivros.Location = new Point(345, 9);
            lblGestãodelivros.Name = "lblGestãodelivros";
            lblGestãodelivros.Size = new Size(143, 25);
            lblGestãodelivros.TabIndex = 17;
            lblGestãodelivros.Text = "Gestão de Livros";
            // 
            // Formlivros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 520);
            Controls.Add(lblGestãodelivros);
            Controls.Add(btnVoltar);
            Controls.Add(dataGridView1);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblExemplares);
            Controls.Add(lblAno);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(txtISBN);
            Name = "Formlivros";
            Text = "Formlivros";
            Load += Formlivros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtISBN;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblAno;
        private Label lblExemplares;

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;

        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnLimpar;
        private Button button5;
        private Button btnVoltar;

        private DataGridView dataGridView1;
        private Label lblGestãodelivros;
    }
}