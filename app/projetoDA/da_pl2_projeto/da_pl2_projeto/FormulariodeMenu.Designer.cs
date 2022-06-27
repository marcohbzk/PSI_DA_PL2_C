
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
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
            this.comboBoxAtivo = new System.Windows.Forms.ComboBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(100, 150);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(185, 20);
            this.textBoxNome.TabIndex = 51;
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.AutoSize = true;
            this.labelNifCliente.Location = new System.Drawing.Point(57, 154);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(38, 13);
            this.labelNifCliente.TabIndex = 45;
            this.labelNifCliente.Text = "Nome:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(57, 272);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(34, 13);
            this.labelNomeCliente.TabIndex = 44;
            this.labelNomeCliente.Text = "Ativo:";
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(296, 11);
            this.dataGridViewMenu.MultiSelect = false;
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenu.Size = new System.Drawing.Size(293, 342);
            this.dataGridViewMenu.TabIndex = 43;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemMenu_CellClick);
            // 
            // btnEditaraMenu
            // 
            this.btnEditaraMenu.Location = new System.Drawing.Point(105, 315);
            this.btnEditaraMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditaraMenu.Name = "btnEditaraMenu";
            this.btnEditaraMenu.Size = new System.Drawing.Size(89, 39);
            this.btnEditaraMenu.TabIndex = 42;
            this.btnEditaraMenu.Text = "Editar Item";
            this.btnEditaraMenu.UseVisualStyleBackColor = true;
            this.btnEditaraMenu.Click += new System.EventHandler(this.btnEditaraMenu_Click);
            // 
            // btnApagarMenu
            // 
            this.btnApagarMenu.Location = new System.Drawing.Point(198, 315);
            this.btnApagarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagarMenu.Name = "btnApagarMenu";
            this.btnApagarMenu.Size = new System.Drawing.Size(89, 39);
            this.btnApagarMenu.TabIndex = 41;
            this.btnApagarMenu.Text = "Remover Item";
            this.btnApagarMenu.UseVisualStyleBackColor = true;
            // 
            // btnRegistarMenu
            // 
            this.btnRegistarMenu.Location = new System.Drawing.Point(11, 314);
            this.btnRegistarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistarMenu.Name = "btnRegistarMenu";
            this.btnRegistarMenu.Size = new System.Drawing.Size(89, 39);
            this.btnRegistarMenu.TabIndex = 40;
            this.btnRegistarMenu.Text = "Adicionar Item";
            this.btnRegistarMenu.UseVisualStyleBackColor = true;
            this.btnRegistarMenu.Click += new System.EventHandler(this.btnRegistarMenu_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(265, 133);
            this.pictureBoxMenu.TabIndex = 52;
            this.pictureBoxMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Preço:";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(100, 237);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(185, 20);
            this.textBoxPreco.TabIndex = 54;
            // 
            // textBoxIngredientes
            // 
            this.textBoxIngredientes.Location = new System.Drawing.Point(100, 174);
            this.textBoxIngredientes.Name = "textBoxIngredientes";
            this.textBoxIngredientes.Size = new System.Drawing.Size(185, 20);
            this.textBoxIngredientes.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Ingredientes:";
            // 
            // comboBoxAtivo
            // 
            this.comboBoxAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAtivo.FormattingEnabled = true;
            this.comboBoxAtivo.Items.AddRange(new object[] {
            "Sim",
            "Nao"});
            this.comboBoxAtivo.Location = new System.Drawing.Point(100, 272);
            this.comboBoxAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAtivo.Name = "comboBoxAtivo";
            this.comboBoxAtivo.Size = new System.Drawing.Size(185, 21);
            this.comboBoxAtivo.TabIndex = 57;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(100, 206);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(185, 20);
            this.textBoxCategoria.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Categoria:";
            // 
            // FormulariodeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.comboBoxAtivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIngredientes);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNifCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.btnEditaraMenu);
            this.Controls.Add(this.btnApagarMenu);
            this.Controls.Add(this.btnRegistarMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
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

        private System.Windows.Forms.TextBox textBoxNome;
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
        private System.Windows.Forms.ComboBox comboBoxAtivo;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Label label3;
    }
}