using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfaceLayer
{
    public partial class Formprincipal : Form
    {
        public Formprincipal()
        {
            InitializeComponent();
        }

        private void btnGerirLivros_Click(object sender, EventArgs e)
        {
            Formlivros form = new Formlivros();
            form.ShowDialog();
        }

        private void btnGerirSocios_Click(object sender, EventArgs e)
        {
            Formsocios form = new Formsocios();
            form.Show();
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            Formemprestimos form = new Formemprestimos();
            form.Show();
        }

        private void btnestatisticas_Click(object sender, EventArgs e)
        {
            Formestatisticas form = new Formestatisticas();
            form.Show();
        }
    }
}
