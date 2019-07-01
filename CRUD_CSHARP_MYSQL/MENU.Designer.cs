namespace CRUD_CSHARP_MYSQL {
    partial class MENU {
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
            this.buttSair = new System.Windows.Forms.Button();
            this.buttCurso = new System.Windows.Forms.Button();
            this.buttProf = new System.Windows.Forms.Button();
            this.buttAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttSair
            // 
            this.buttSair.Location = new System.Drawing.Point(106, 203);
            this.buttSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttSair.Name = "buttSair";
            this.buttSair.Size = new System.Drawing.Size(127, 35);
            this.buttSair.TabIndex = 9;
            this.buttSair.Text = "SAIR";
            this.buttSair.UseVisualStyleBackColor = true;
            // 
            // buttCurso
            // 
            this.buttCurso.Location = new System.Drawing.Point(106, 25);
            this.buttCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttCurso.Name = "buttCurso";
            this.buttCurso.Size = new System.Drawing.Size(127, 35);
            this.buttCurso.TabIndex = 6;
            this.buttCurso.Text = "CURSO";
            this.buttCurso.UseVisualStyleBackColor = true;
            // 
            // buttProf
            // 
            this.buttProf.Location = new System.Drawing.Point(106, 140);
            this.buttProf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttProf.Name = "buttProf";
            this.buttProf.Size = new System.Drawing.Size(127, 35);
            this.buttProf.TabIndex = 8;
            this.buttProf.Text = "PROFESSOR";
            this.buttProf.UseVisualStyleBackColor = true;
            // 
            // buttAluno
            // 
            this.buttAluno.Location = new System.Drawing.Point(106, 78);
            this.buttAluno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttAluno.Name = "buttAluno";
            this.buttAluno.Size = new System.Drawing.Size(127, 35);
            this.buttAluno.TabIndex = 7;
            this.buttAluno.Text = "ALUNO";
            this.buttAluno.UseVisualStyleBackColor = true;
            this.buttAluno.Click += new System.EventHandler(this.buttAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU: ";
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 262);
            this.Controls.Add(this.buttSair);
            this.Controls.Add(this.buttCurso);
            this.Controls.Add(this.buttProf);
            this.Controls.Add(this.buttAluno);
            this.Controls.Add(this.label1);
            this.Name = "MENU";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSair;
        private System.Windows.Forms.Button buttCurso;
        private System.Windows.Forms.Button buttProf;
        private System.Windows.Forms.Button buttAluno;
        private System.Windows.Forms.Label label1;
    }
}

