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
    public partial class FormularioSelecaoRestaurante : Form
    {
        GereRestauranteContainer GereRestauranteContainer = new GereRestauranteContainer();

        public FormularioSelecaoRestaurante()
        {
            InitializeComponent();
        }

        private void listBoxSelecionarRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
        private void FormularioSelecaoRestaurante_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FormularioInicial.idRest.Id == 0)
            {
                this.Hide();
                FormularioPrincipal2 fp2 = new FormularioPrincipal2();
                fp2.Show();
            }
        }

        private void FormularioSelecaoRestaurante_Load(object sender, EventArgs e)
        {
            listBoxSelecionarRestaurante.DataSource = GereRestauranteContainer.Restaurantes.ToList<Restaurante>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = (Restaurante)listBoxSelecionarRestaurante.SelectedItem;
            FormularioInicial.idRest = restaurante;
            this.Hide();
            FormularioInicial fp = new FormularioInicial();
            fp.Show();
        }
    }
}
