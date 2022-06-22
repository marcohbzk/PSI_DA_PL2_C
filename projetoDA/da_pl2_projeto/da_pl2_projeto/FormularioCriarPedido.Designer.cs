
namespace da_pl2_projeto
{
    partial class FormularioCriarPedido
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
            this.btnRegistarMenu = new System.Windows.Forms.Button();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistarMenu
            // 
            this.btnRegistarMenu.Location = new System.Drawing.Point(275, 386);
            this.btnRegistarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistarMenu.Name = "btnRegistarMenu";
            this.btnRegistarMenu.Size = new System.Drawing.Size(119, 48);
            this.btnRegistarMenu.TabIndex = 60;
            this.btnRegistarMenu.Text = "Criar Pedido";
            this.btnRegistarMenu.UseVisualStyleBackColor = true;
            this.btnRegistarMenu.Click += new System.EventHandler(this.btnRegistarMenu_Click);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(401, 13);
            this.dataGridViewPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersWidth = 51;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(391, 421);
            this.dataGridViewPedidos.TabIndex = 73;
            // 
            // FormularioCriarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.btnRegistarMenu);
            this.Name = "FormularioCriarPedido";
            this.Text = "FormularioCriarPedido";
            this.Load += new System.EventHandler(this.FormularioCriarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistarMenu;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
    }
}