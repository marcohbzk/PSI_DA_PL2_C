
namespace da_pl2_projeto
{
    partial class FormulariodeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.labelNifCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.btnEditaraMenu = new System.Windows.Forms.Button();
            this.btnApagarMenu = new System.Windows.Forms.Button();
            this.btnRegistarMenu = new System.Windows.Forms.Button();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxIngredientes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBoxNomeCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(133, 184);
            this.TextBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(245, 22);
            this.TextBoxNome.TabIndex = 51;
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.AutoSize = true;
            this.labelNifCliente.Location = new System.Drawing.Point(76, 189);
            this.labelNifCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(49, 17);
            this.labelNifCliente.TabIndex = 45;
            this.labelNifCliente.Text = "Nome:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(76, 335);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(43, 17);
            this.labelNomeCliente.TabIndex = 44;
            this.labelNomeCliente.Text = "Ativo:";
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(394, 14);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.Size = new System.Drawing.Size(391, 421);
            this.dataGridViewMenu.TabIndex = 43;
            // 
            // btnEditaraMenu
            // 
            this.btnEditaraMenu.Location = new System.Drawing.Point(140, 388);
            this.btnEditaraMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditaraMenu.Name = "btnEditaraMenu";
            this.btnEditaraMenu.Size = new System.Drawing.Size(119, 48);
            this.btnEditaraMenu.TabIndex = 42;
            this.btnEditaraMenu.Text = "Editar Item";
            this.btnEditaraMenu.UseVisualStyleBackColor = true;
            // 
            // btnApagarMenu
            // 
            this.btnApagarMenu.Location = new System.Drawing.Point(264, 388);
            this.btnApagarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApagarMenu.Name = "btnApagarMenu";
            this.btnApagarMenu.Size = new System.Drawing.Size(119, 48);
            this.btnApagarMenu.TabIndex = 41;
            this.btnApagarMenu.Text = "Remover Item";
            this.btnApagarMenu.UseVisualStyleBackColor = true;
            this.btnApagarMenu.Click += new System.EventHandler(this.btnApagarMenu_Click);
            // 
            // btnRegistarMenu
            // 
            this.btnRegistarMenu.Location = new System.Drawing.Point(15, 387);
            this.btnRegistarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistarMenu.Name = "btnRegistarMenu";
            this.btnRegistarMenu.Size = new System.Drawing.Size(119, 48);
            this.btnRegistarMenu.TabIndex = 40;
            this.btnRegistarMenu.Text = "Adicionar Item";
            this.btnRegistarMenu.UseVisualStyleBackColor = true;
            this.btnRegistarMenu.Click += new System.EventHandler(this.btnRegistarMenu_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Location = new System.Drawing.Point(15, 14);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(353, 164);
            this.pictureBoxMenu.TabIndex = 52;
            this.pictureBoxMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Preço:";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(133, 292);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(245, 22);
            this.textBoxPreco.TabIndex = 54;
            // 
            // textBoxIngredientes
            // 
            this.textBoxIngredientes.Location = new System.Drawing.Point(133, 214);
            this.textBoxIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIngredientes.Name = "textBoxIngredientes";
            this.textBoxIngredientes.Size = new System.Drawing.Size(245, 22);
            this.textBoxIngredientes.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Ingredientes:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sim",
            "Nao"});
            this.comboBox1.Location = new System.Drawing.Point(133, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 24);
            this.comboBox1.TabIndex = 57;
            // 
            // TextBoxNomeCategoria
            // 
            this.TextBoxNomeCategoria.Location = new System.Drawing.Point(133, 253);
            this.TextBoxNomeCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxNomeCategoria.Name = "TextBoxNomeCategoria";
            this.TextBoxNomeCategoria.Size = new System.Drawing.Size(245, 22);
            this.TextBoxNomeCategoria.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Categoria:";
            // 
            // FormulariodeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxNomeCategoria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIngredientes);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.labelNifCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.btnEditaraMenu);
            this.Controls.Add(this.btnApagarMenu);
            this.Controls.Add(this.btnRegistarMenu);
            this.Name = "FormulariodeMenu";
            this.Text = "FormulariodeMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormulariodeMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormulariodeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Label labelNifCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button btnEditaraMenu;
        private System.Windows.Forms.Button btnApagarMenu;
        private System.Windows.Forms.Button btnRegistarMenu;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.TextBox textBoxIngredientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TextBoxNomeCategoria;
        private System.Windows.Forms.Label label3;
    }
}