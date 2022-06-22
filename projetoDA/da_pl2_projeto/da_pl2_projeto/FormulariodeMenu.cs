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
    public partial class FormulariodeMenu : Form
    {
        GereRestauranteContainer GereRestauranteContainer = new GereRestauranteContainer();
        public FormulariodeMenu()
        {
            InitializeComponent();
        }

        private void btnRegistarMenu_Click(object sender, EventArgs e)
        {
            if(
                string.IsNullOrWhiteSpace(textBoxCategoria.Text) ||
                string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(textBoxIngredientes.Text) ||
                string.IsNullOrWhiteSpace(textBoxPreco.Text) ||
                string.IsNullOrWhiteSpace(comboBoxAtivo.Text)
              )
            {
                MessageBox.Show("Preencha os Campos Obrigatórios!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else 
            {
                ItemMenu tempItemMenu = new ItemMenu();
                Categoria tempCategoria = new Categoria();
                Restaurante restaurante = GereRestauranteContainer.Restaurantes.Find(FormularioInicial.idRest.Id);

                //tempItemMenu.Fotografia = new byte[2];

                tempCategoria.Nome = textBoxCategoria.Text;
                tempCategoria.Ativo = comboBoxAtivo.SelectedItem.ToString();
                tempItemMenu.Nome = textBoxNome.Text;
                tempItemMenu.Ingredientes = textBoxIngredientes.Text;
                tempItemMenu.Preco = Convert.ToDecimal(textBoxPreco.Text);
                tempItemMenu.Ativo = comboBoxAtivo.SelectedItem.ToString();
                tempItemMenu.Categoria = tempCategoria;

                tempItemMenu.Restaurante.Add(restaurante);

                GereRestauranteContainer.Categorias.Add(tempCategoria);
                GereRestauranteContainer.ItensMenu.Add(tempItemMenu);

                GereRestauranteContainer.SaveChanges();
                LerDados();
            }
        }
        private void btnEditarMenu_Click(object sender, EventArgs e)
        {
            ItemMenu tempItemMenu = new ItemMenu();

            tempItemMenu = dataGridViewMenu.SelectedRows[0].DataBoundItem as ItemMenu;

            tempItemMenu.Nome = textBoxNome.Text;
            tempItemMenu.Ingredientes = textBoxIngredientes.Text;
            tempItemMenu.Categoria.Nome = textBoxCategoria.Text;
            tempItemMenu.Preco = Convert.ToDecimal(textBoxPreco.Text);
            tempItemMenu.Ativo = Convert.ToString(comboBoxAtivo.SelectedItem);
            
            GereRestauranteContainer.SaveChanges();
            LerDados();
        }
        private void btnApagarMenu_Click(object sender, EventArgs e)
        {
            ItemMenu userdata = GetSelectedItemMenu();

            GereRestauranteContainer.ItensMenu.Remove(userdata);

            GereRestauranteContainer.SaveChanges();
            LerDados();
        }
        private void dataGridViewItemMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemMenu tempItemMenu = new ItemMenu();

            tempItemMenu = dataGridViewMenu.SelectedRows[0].DataBoundItem as ItemMenu;

            textBoxNome.Text = tempItemMenu.Nome;
            textBoxIngredientes.Text = tempItemMenu.Ingredientes;
            textBoxCategoria.Text = tempItemMenu.Categoria.Nome;
            textBoxPreco.Text = Convert.ToString(tempItemMenu.Preco);
            comboBoxAtivo.SelectedItem = tempItemMenu.Ativo;


            GereRestauranteContainer.SaveChanges();
            LerDados();
        }
        private void LerDados()
        {
            List<ItemMenu> itemMenus = new List<ItemMenu>();
            ItemMenu tempItemMenu = new ItemMenu();
            try
            {
                //Percorre todas as pessoas na base de dados
                foreach (ItemMenu itemMenu in GereRestauranteContainer.ItensMenu.ToList())
                { 
                    itemMenus.Add(itemMenu);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dataGridViewMenu.DataSource = itemMenus; //Muda a datasource para a lista

            //TAMANHO DAS COLUNAS AUTOMATICAMENTE
            // Escolhe o tamanho da coluna indicada. Podes usar .AllCells ou .Fill
            dataGridViewMenu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMenu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMenu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMenu.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Depois da DataGrid calcular a largura da columa podemos então guardar a largura de cada coluna
            for (int i = 0; i <= dataGridViewMenu.Columns.Count - 1; i++)
            {
                // Guardar a largura das colunas na variável:
                int colw = dataGridViewMenu.Columns[i].Width;

                // Remover AutoSizing:
                dataGridViewMenu.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Alterar a largura para o valor do AutoSize:
                dataGridViewMenu.Columns[i].Width = colw;
            }
        }

        private void FormulariodeMenu_Load(object sender, EventArgs e)
        {
            LerDados();
        }
        private void FormulariodeMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormularioInicial fp = new FormularioInicial();
            fp.Show();
        }

        
        private ItemMenu GetSelectedItemMenu()
        {
            int row = dataGridViewMenu.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewMenu.Rows[row].Cells["id"].Value;
            ItemMenu data = GereRestauranteContainer.ItensMenu.First(c => c.Id == id) as ItemMenu;

            return data;
        }
    }
}
