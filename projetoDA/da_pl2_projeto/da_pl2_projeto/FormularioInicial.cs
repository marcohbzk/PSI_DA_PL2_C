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
    public partial class FormularioInicial : Form
    {
        public static Restaurante idRest;
        public FormularioInicial()
        {
            InitializeComponent();
        }

        private void btnGestaoClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioGestaoClientes fgc = new FormularioGestaoClientes();
            fgc.ShowDialog();
        }

        private void btnGestaoPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormulariodePedidos fp = new FormulariodePedidos();
            fp.ShowDialog();
        }

        private void btnSelecaoRestaurantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioIndividualRestaurante fsr = new FormularioIndividualRestaurante();
            fsr.ShowDialog();
        }

        private void btnMenuRestaurantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormulariodeMenu fm = new FormulariodeMenu();
            fm.ShowDialog();
        }

        private void btnGestaoRestaurantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioGestaoGlobalRestaurantes fggr = new FormularioGestaoGlobalRestaurantes();
            fggr.ShowDialog();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void FormularioPrinciapl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormularioPrincipal2 fp2 = new FormularioPrincipal2();
            fp2.Show();
        }
    }
}
