namespace BD_CSharp_01 {
    partial class Menu {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.buttCadEmpregado = new System.Windows.Forms.Button();
            this.buttCadastrarSetor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttCadEmpregado
            // 
            this.buttCadEmpregado.Location = new System.Drawing.Point(81, 56);
            this.buttCadEmpregado.Name = "buttCadEmpregado";
            this.buttCadEmpregado.Size = new System.Drawing.Size(142, 52);
            this.buttCadEmpregado.TabIndex = 0;
            this.buttCadEmpregado.Text = "Cadastrar Empregado";
            this.buttCadEmpregado.UseVisualStyleBackColor = true;
            // 
            // buttCadastrarSetor
            // 
            this.buttCadastrarSetor.Location = new System.Drawing.Point(81, 173);
            this.buttCadastrarSetor.Name = "buttCadastrarSetor";
            this.buttCadastrarSetor.Size = new System.Drawing.Size(142, 52);
            this.buttCadastrarSetor.TabIndex = 1;
            this.buttCadastrarSetor.Text = "Cadastrar Setor";
            this.buttCadastrarSetor.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 374);
            this.Controls.Add(this.buttCadastrarSetor);
            this.Controls.Add(this.buttCadEmpregado);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttCadEmpregado;
        private System.Windows.Forms.Button buttCadastrarSetor;
    }
}

