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
    public partial class FormularioIndividualRestaurante : Form
    {
        GereRestauranteContainer GereRestauranteContainer = new GereRestauranteContainer();
        public FormularioIndividualRestaurante()
        {
            InitializeComponent();
        }

        private void FormularioIndividualRestaurante_Load(object sender, EventArgs e)
        {
            LerDados();
        }

        private void btnRegistarTrabalhador_Click(object sender, EventArgs e)
        {
            Morada tempMorada = new Morada();
            Trabalhador tempTrabalhador = new Trabalhador();

            tempTrabalhador.Nome = textBoxNomeTrabalhador.Text;
            tempTrabalhador.Posicao = textBoxPosicaoTrabalhador.Text;
            tempTrabalhador.Salario = Convert.ToDecimal(textBoxSalarioTrabalhador.Text);
            tempTrabalhador.Telemovel = Convert.ToInt32(textBoxTelemovelTrabalhador.Text);

            tempTrabalhador.RestauranteId = FormularioInicial.idRest.Id;

            tempMorada.Rua = textBoxRuaTrabalhador.Text;
            tempMorada.Cidade = textBoxCidadeTrabalhador.Text;
            tempMorada.CodPostal = textBoxCodPostalTrabalhador.Text;
            tempMorada.Pais = textBoxPaisTrabalhador.Text;

            tempTrabalhador.Morada = tempMorada;

            //Adiciona o cliente e a morada à base de dados e atualiza a DataGridView
            GereRestauranteContainer.Moradas.Add(tempMorada);
            GereRestauranteContainer.Pessoas.Add(tempTrabalhador);
            GereRestauranteContainer.SaveChanges();
            LerDados();
        }

        private void FormularioIndividualRestaurante_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormularioInicial fp = new FormularioInicial();
            fp.Show();
        }

        private void LerDados()
        {
            List<Pessoa> trabalhadores = new List<Pessoa>();
            Trabalhador tempTrabalhador = new Trabalhador();
            try
            {
                //Percorre todas as pessoas na base de dados
                foreach (Pessoa pessoa in GereRestauranteContainer.Pessoas.ToList())
                {
                    if (pessoa is Trabalhador) //Se a pessoa for um trabalhador adiciona-a à lista
                    {

                        tempTrabalhador = (Trabalhador)pessoa;
                        if(tempTrabalhador.RestauranteId == FormularioInicial.idRest.Id)
                        {
                            trabalhadores.Add(pessoa as Trabalhador);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dataGridViewRestaurantes.DataSource = trabalhadores; //Muda a datasource para a lista

            //TAMANHO DAS COLUNAS AUTOMATICAMENTE
            // Escolhe o tamanho da coluna indicada. Podes usar .AllCells ou .Fill
            dataGridViewRestaurantes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRestaurantes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRestaurantes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRestaurantes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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

        private void btnApagarTrabalhador_Click(object sender, EventArgs e)
        {
            Trabalhador userdata = GetSelectedTrabalhador();

            GereRestauranteContainer.Pessoas.Remove(userdata);

            GereRestauranteContainer.SaveChanges();
            LerDados();
        }

        private Trabalhador GetSelectedTrabalhador()
        {
            int row = dataGridViewRestaurantes.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewRestaurantes.Rows[row].Cells["id"].Value;
            Trabalhador data = GereRestauranteContainer.Pessoas.First(c => c.Id == id) as Trabalhador;

            return data;
        }
    }
}

