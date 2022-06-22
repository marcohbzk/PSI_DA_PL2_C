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
    public partial class FormularioGestaoGlobalRestaurantes : Form
    {
        GereRestauranteContainer GereRestauranteContainer = new GereRestauranteContainer();
        public static string nomeRes;
        public FormularioGestaoGlobalRestaurantes()
        {
            InitializeComponent();
        }

        private void FormularioGestaoGlobalRestaurantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormularioPrincipal2 fp2 = new FormularioPrincipal2();
            fp2.Show();
        }
        private void btnRegistarRestauranteGlobal_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(textBoxNomeRestauranteGlobal.Text) ||
                string.IsNullOrWhiteSpace(textBoxRuaRestauranteGlobal.Text) ||
                string.IsNullOrWhiteSpace(textBoxCidadeRestauranteGlobal.Text) ||
                string.IsNullOrWhiteSpace(textBoxCodPostalRestauranteGlobal.Text) ||
                string.IsNullOrWhiteSpace(textBoxPaisRestauranteGlobal.Text)
               )
            {
                MessageBox.Show("Preencha os Campos Obrigatórios!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Morada tempMorada = new Morada();
                Restaurante tempRestaurante = new Restaurante();

                tempRestaurante.Nome = textBoxNomeRestauranteGlobal.Text;
                nomeRes = textBoxNomeRestauranteGlobal.Text;
                tempMorada.Rua = textBoxRuaRestauranteGlobal.Text;
                tempMorada.Cidade = textBoxCidadeRestauranteGlobal.Text;
                tempMorada.CodPostal = textBoxCodPostalRestauranteGlobal.Text;
                tempMorada.Pais = textBoxPaisRestauranteGlobal.Text;

                tempRestaurante.Morada = tempMorada;

                GereRestauranteContainer.Moradas.Add(tempMorada);
                GereRestauranteContainer.Restaurantes.Add(tempRestaurante);
                GereRestauranteContainer.SaveChanges();
                LerDados();
            } 
        }
        private void btnEditarRestauranteGlobal_Click(object sender, EventArgs e)
        {
            Restaurante tempRestaurante = new Restaurante();

            tempRestaurante = dataGridViewRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;

            tempRestaurante.Nome = textBoxNomeRestauranteGlobal.Text;
            tempRestaurante.Morada.Rua = textBoxRuaRestauranteGlobal.Text;
            tempRestaurante.Morada.Cidade = textBoxCidadeRestauranteGlobal.Text;
            tempRestaurante.Morada.CodPostal = textBoxCodPostalRestauranteGlobal.Text;
            tempRestaurante.Morada.Pais = textBoxPaisRestauranteGlobal.Text;

            GereRestauranteContainer.SaveChanges();
            LerDados();
        }
        private void btnApagarRestauranteGlobal_Click(object sender, EventArgs e)
        {
            Restaurante userdata = GetSelectedRestaurante();

            GereRestauranteContainer.Restaurantes.Remove(userdata);

            GereRestauranteContainer.SaveChanges();
            LerDados();
        }
        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Restaurante tempRestaurante = new Restaurante();

            tempRestaurante = dataGridViewRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;

            textBoxNomeRestauranteGlobal.Text = tempRestaurante.Nome;
            textBoxRuaRestauranteGlobal.Text = tempRestaurante.Morada.Rua;
            textBoxCidadeRestauranteGlobal.Text = tempRestaurante.Morada.Cidade;
            textBoxCodPostalRestauranteGlobal.Text = tempRestaurante.Morada.CodPostal;
            textBoxPaisRestauranteGlobal.Text = tempRestaurante.Morada.Pais;

            GereRestauranteContainer.SaveChanges();
            LerDados();
        }

        private void LerDados()
        {
            List<Restaurante> restaurantes = new List<Restaurante>();
            try
            {
                //Percorre todas as pessoas na base de dados
                foreach (Restaurante restaurante in GereRestauranteContainer.Restaurantes.ToList())
                {
                    restaurantes.Add(restaurante);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dataGridViewRestaurantes.DataSource = restaurantes; //Muda a datasource para a lista

            //TAMANHO DAS COLUNAS AUTOMATICAMENTE

            // Escolhe o tamanho da coluna indicada. Podes usar .AllCells ou .Fill
            dataGridViewRestaurantes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRestaurantes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRestaurantes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           

            // Depois da DataGrid calcular a largura da columa podemos então guardar a largura de cada coluna
            for (int i = 0; i <= dataGridViewRestaurantes.Columns.Count - 1; i++)
            {
                // Guardar a largura das colunas na variável:
                int colw = dataGridViewRestaurantes.Columns[i].Width;

                // Remover AutoSizing:
                dataGridViewRestaurantes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Alterar a largura para o valor do AutoSize:
                dataGridViewRestaurantes.Columns[i].Width = colw;
            }
        }
        private Restaurante GetSelectedRestaurante()
        {
            int row = dataGridViewRestaurantes.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewRestaurantes.Rows[row].Cells["id"].Value;
            Restaurante data = GereRestauranteContainer.Restaurantes.First(c => c.Id == id) as Restaurante;

            return data;
        }
        private void FormularioGestaoGlobalRestaurantes_Load(object sender, EventArgs e)
        {
            LerDados();
        }
    }
}
