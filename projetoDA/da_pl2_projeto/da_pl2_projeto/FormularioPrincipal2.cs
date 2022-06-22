using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace da_pl2_projeto
{
    public partial class FormularioPrincipal2 : Form
    {
        public FormularioPrincipal2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioGestaoGlobalRestaurantes fggr = new FormularioGestaoGlobalRestaurantes();
            fggr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioSelecaoRestaurante fsr = new FormularioSelecaoRestaurante();
            fsr.ShowDialog();
        }

        private void FormularioPrincipal2_Load(object sender, EventArgs e)
        {

        }
    }
}
