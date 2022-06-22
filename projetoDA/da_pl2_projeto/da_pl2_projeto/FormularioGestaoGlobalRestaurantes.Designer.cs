
namespace da_pl2_projeto
{
    partial class FormularioGestaoGlobalRestaurantes
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
            this.textBoxCodPostalRestauranteGlobal = new System.Windows.Forms.TextBox();
            this.textBoxCidadeRestauranteGlobal = new System.Windows.Forms.TextBox();
            this.textBoxRuaRestauranteGlobal = new System.Windows.Forms.TextBox();
            this.textBoxNomeRestauranteGlobal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.dataGridViewRestaurantes = new System.Windows.Forms.DataGridView();
            this.btnEditarRestauranteGlobal = new System.Windows.Forms.Button();
            this.btnApagarRestauranteGlobal = new System.Windows.Forms.Button();
            this.btnRegistarRestauranteGlobal = new System.Windows.Forms.Button();
            this.Pais = new System.Windows.Forms.Label();
            this.textBoxPaisRestauranteGlobal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurantes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCodPostalRestauranteGlobal
            // 
            this.textBoxCodPostalRestauranteGlobal.Location = new System.Drawing.Point(138, 134);
            this.textBoxCodPostalRestauranteGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodPostalRestauranteGlobal.Name = "textBoxCodPostalRestauranteGlobal";
            this.textBoxCodPostalRestauranteGlobal.Size = new System.Drawing.Size(245, 22);
            this.textBoxCodPostalRestauranteGlobal.TabIndex = 55;
            this.textBoxCodPostalRestauranteGlobal.TextChanged += new System.EventHandler(this.textBoxCodPostalRestauranteGlobal_TextChanged);
            // 
            // textBoxCidadeRestauranteGlobal
            // 
            this.textBoxCidadeRestauranteGlobal.Location = new System.Drawing.Point(138, 103);
            this.textBoxCidadeRestauranteGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCidadeRestauranteGlobal.Name = "textBoxCidadeRestauranteGlobal";
            this.textBoxCidadeRestauranteGlobal.Size = new System.Drawing.Size(245, 22);
            this.textBoxCidadeRestauranteGlobal.TabIndex = 54;
            // 
            // textBoxRuaRestauranteGlobal
            // 
            this.textBoxRuaRestauranteGlobal.Location = new System.Drawing.Point(138, 69);
            this.textBoxRuaRestauranteGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRuaRestauranteGlobal.Name = "textBoxRuaRestauranteGlobal";
            this.textBoxRuaRestauranteGlobal.Size = new System.Drawing.Size(245, 22);
            this.textBoxRuaRestauranteGlobal.TabIndex = 53;
            // 
            // textBoxNomeRestauranteGlobal
            // 
            this.textBoxNomeRestauranteGlobal.Location = new System.Drawing.Point(140, 25);
            this.textBoxNomeRestauranteGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeRestauranteGlobal.Name = "textBoxNomeRestauranteGlobal";
            this.textBoxNomeRestauranteGlobal.Size = new System.Drawing.Size(245, 22);
            this.textBoxNomeRestauranteGlobal.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cod. Postal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Rua:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(28, 30);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(49, 17);
            this.labelNomeCliente.TabIndex = 44;
            this.labelNomeCliente.Text = "Nome:";
            // 
            // dataGridViewRestaurantes
            // 
            this.dataGridViewRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurantes.Location = new System.Drawing.Point(394, 14);
            this.dataGridViewRestaurantes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRestaurantes.Name = "dataGridViewRestaurantes";
            this.dataGridViewRestaurantes.RowHeadersWidth = 51;
            this.dataGridViewRestaurantes.Size = new System.Drawing.Size(391, 421);
            this.dataGridViewRestaurantes.TabIndex = 43;
            this.dataGridViewRestaurantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEditarRestauranteGlobal
            // 
            this.btnEditarRestauranteGlobal.Location = new System.Drawing.Point(140, 388);
            this.btnEditarRestauranteGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarRestauranteGlobal.Name = "btnEditarRestauranteGlobal";
            this.btnEditarRestauranteGlobal.Size = new System.Drawing.Size(119, 48);
            this.btnEditarRestauranteGlobal.TabIndex = 42;
            this.btnEditarRestauranteGlobal.Text = "Update Restaurante";
            this.btnEditarRestauranteGlobal.UseVisualStyleBackColor = true;
            // 
            // btnApagarRestauranteGlobal
            // 
            this.btnApagarRestauranteGlobal.Location = new System.Drawing.Point(264, 388);
            this.btnApagarRestauranteGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApagarRestauranteGlobal.Name = "btnApagarRestauranteGlobal";
            this.btnApagarRestauranteGlobal.Size = new System.Drawing.Size(119, 48);
            this.btnApagarRestauranteGlobal.TabIndex = 41;
            this.btnApagarRestauranteGlobal.Text = "Apagar Restaurante";
            this.btnApagarRestauranteGlobal.UseVisualStyleBackColor = true;
            this.btnApagarRestauranteGlobal.Click += new System.EventHandler(this.btnApagarRestauranteGlobal_Click);
            // 
            // btnRegistarRestauranteGlobal
            // 
            this.btnRegistarRestauranteGlobal.Location = new System.Drawing.Point(16, 388);
            this.btnRegistarRestauranteGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistarRestauranteGlobal.Name = "btnRegistarRestauranteGlobal";
            this.btnRegistarRestauranteGlobal.Size = new System.Drawing.Size(119, 48);
            this.btnRegistarRestauranteGlobal.TabIndex = 40;
            this.btnRegistarRestauranteGlobal.Text = "Adicionar Restaurante";
            this.btnRegistarRestauranteGlobal.UseVisualStyleBackColor = true;
            this.btnRegistarRestauranteGlobal.Click += new System.EventHandler(this.btnRegistarRestauranteGlobal_Click);
            // 
            // Pais
            // 
            this.Pais.AutoSize = true;
            this.Pais.Location = new System.Drawing.Point(28, 168);
            this.Pais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(39, 17);
            this.Pais.TabIndex = 56;
            this.Pais.Text = "Pais:";
            this.Pais.Click += new System.EventHandler(this.Pais_Click);
            // 
            // textBoxPaisRestauranteGlobal
            // 
            this.textBoxPaisRestauranteGlobal.Location = new System.Drawing.Point(138, 168);
            this.textBoxPaisRestauranteGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPaisRestauranteGlobal.Name = "textBoxPaisRestauranteGlobal";
            this.textBoxPaisRestauranteGlobal.Size = new System.Drawing.Size(245, 22);
            this.textBoxPaisRestauranteGlobal.TabIndex = 57;
            // 
            // FormularioGestaoGlobalRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPaisRestauranteGlobal);
            this.Controls.Add(this.Pais);
            this.Controls.Add(this.textBoxCodPostalRestauranteGlobal);
            this.Controls.Add(this.textBoxCidadeRestauranteGlobal);
            this.Controls.Add(this.textBoxRuaRestauranteGlobal);
            this.Controls.Add(this.textBoxNomeRestauranteGlobal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.dataGridViewRestaurantes);
            this.Controls.Add(this.btnEditarRestauranteGlobal);
            this.Controls.Add(this.btnApagarRestauranteGlobal);
            this.Controls.Add(this.btnRegistarRestauranteGlobal);
            this.Name = "FormularioGestaoGlobalRestaurantes";
            this.Text = "FormularioGestaoGlobalRestaurantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioGestaoGlobalRestaurantes_FormClosing);
            this.Load += new System.EventHandler(this.FormularioGestaoGlobalRestaurantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodPostalRestauranteGlobal;
        private System.Windows.Forms.TextBox textBoxCidadeRestauranteGlobal;
        private System.Windows.Forms.TextBox textBoxRuaRestauranteGlobal;
        private System.Windows.Forms.TextBox textBoxNomeRestauranteGlobal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.DataGridView dataGridViewRestaurantes;
        private System.Windows.Forms.Button btnEditarRestauranteGlobal;
        private System.Windows.Forms.Button btnApagarRestauranteGlobal;
        private System.Windows.Forms.Button btnRegistarRestauranteGlobal;
        private System.Windows.Forms.Label Pais;
        private System.Windows.Forms.TextBox textBoxPaisRestauranteGlobal;
    }
}