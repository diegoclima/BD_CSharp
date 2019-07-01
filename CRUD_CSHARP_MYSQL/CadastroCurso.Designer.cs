namespace CRUD_CSHARP_MYSQL {
    partial class CadastroCurso {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtIdcurso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.buttSair = new System.Windows.Forms.Button();
            this.buttCancelar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdcurso
            // 
            this.txtIdcurso.Location = new System.Drawing.Point(90, 9);
            this.txtIdcurso.Name = "txtIdcurso";
            this.txtIdcurso.ReadOnly = true;
            this.txtIdcurso.Size = new System.Drawing.Size(63, 20);
            this.txtIdcurso.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txtIdcurso, "Id");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID Curso:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(551, 20);
            this.txtNome.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtNome, "Disciplina");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Disciplina :";
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(12, 116);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(661, 347);
            this.dg_dados.TabIndex = 26;
            // 
            // buttSair
            // 
            this.buttSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttSair.Location = new System.Drawing.Point(688, 380);
            this.buttSair.Name = "buttSair";
            this.buttSair.Size = new System.Drawing.Size(140, 59);
            this.buttSair.TabIndex = 31;
            this.buttSair.Text = "SAIR";
            this.toolTip1.SetToolTip(this.buttSair, "Sair");
            this.buttSair.UseVisualStyleBackColor = true;
            // 
            // buttCancelar
            // 
            this.buttCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttCancelar.Location = new System.Drawing.Point(688, 315);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(140, 59);
            this.buttCancelar.TabIndex = 30;
            this.buttCancelar.Text = "CANCELAR";
            this.toolTip1.SetToolTip(this.buttCancelar, "Cancelar");
            this.buttCancelar.UseVisualStyleBackColor = true;
            // 
            // bttExcluir
            // 
            this.bttExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttExcluir.Location = new System.Drawing.Point(688, 246);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(140, 59);
            this.bttExcluir.TabIndex = 29;
            this.bttExcluir.Text = "EXCLUIR";
            this.toolTip1.SetToolTip(this.bttExcluir, "Excluir");
            this.bttExcluir.UseVisualStyleBackColor = true;
            // 
            // bttEditar
            // 
            this.bttEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttEditar.Location = new System.Drawing.Point(688, 182);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(140, 58);
            this.bttEditar.TabIndex = 28;
            this.bttEditar.Text = "EDITAR";
            this.toolTip1.SetToolTip(this.bttEditar, "Editar");
            this.bttEditar.UseVisualStyleBackColor = true;
            // 
            // bttSalvar
            // 
            this.bttSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttSalvar.Location = new System.Drawing.Point(688, 116);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(140, 60);
            this.bttSalvar.TabIndex = 27;
            this.bttSalvar.Text = "SALVAR";
            this.toolTip1.SetToolTip(this.bttSalvar, "Salvar");
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // CadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 475);
            this.Controls.Add(this.buttSair);
            this.Controls.Add(this.buttCancelar);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.txtIdcurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "CadastroCurso";
            this.Text = "CadastroCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdcurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Button buttSair;
        private System.Windows.Forms.Button buttCancelar;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}