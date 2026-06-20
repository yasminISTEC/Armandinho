namespace InterfaceLayer
{
    partial class Formsocios
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
            lblTitulo = new Label();
            lblNumero = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            txtNumero = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnVoltar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(320, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestão de Sócios";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(50, 60);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(77, 25);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(50, 100);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(50, 140);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(77, 25);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(150, 60);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 31);
            txtNumero.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(150, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(150, 140);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(150, 31);
            txtTelefone.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(40, 200);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(120, 34);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(180, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 34);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(320, 200);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(320, 405);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 34);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(700, 150);
            dataGridView1.TabIndex = 11;
            // 
            // Formsocios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnVoltar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtNumero);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblNumero);
            Controls.Add(lblTitulo);
            Name = "Formsocios";
            Text = "Formsocios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumero;
        private Label lblNome;
        private Label lblTelefone;

        private TextBox txtNumero;
        private TextBox txtNome;
        private TextBox txtTelefone;

        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnVoltar;

        private DataGridView dataGridView1;
    }
}