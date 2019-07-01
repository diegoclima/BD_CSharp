namespace CRUD_CSHARP_MYSQL {
    partial class Cadastro {
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
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.buttSair = new System.Windows.Forms.Button();
            this.buttCancelar = new System.Windows.Forms.Button();
            this.cmIdCurso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(12, 104);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(636, 310);
            this.dg_dados.TabIndex = 12;
            // 
            // buttSair
            // 
            this.buttSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttSair.Location = new System.Drawing.Point(653, 386);
            this.buttSair.Name = "buttSair";
            this.buttSair.Size = new System.Drawing.Size(140, 59);
            this.buttSair.TabIndex = 41;
            this.buttSair.Text = "SAIR";
            this.buttSair.UseVisualStyleBackColor = true;
            // 
            // buttCancelar
            // 
            this.buttCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttCancelar.Location = new System.Drawing.Point(653, 321);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(140, 59);
            this.buttCancelar.TabIndex = 40;
            this.buttCancelar.Text = "CANCELAR";
            this.buttCancelar.UseVisualStyleBackColor = true;
            // 
            // cmIdCurso
            // 
            this.cmIdCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmIdCurso.FormattingEnabled = true;
            this.cmIdCurso.Location = new System.Drawing.Point(585, 59);
            this.cmIdCurso.Name = "cmIdCurso";
            this.cmIdCurso.Size = new System.Drawing.Size(102, 21);
            this.cmIdCurso.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(498, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "ID Curso:";
            // 
            // bttExcluir
            // 
            this.bttExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttExcluir.Location = new System.Drawing.Point(653, 256);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(140, 59);
            this.bttExcluir.TabIndex = 37;
            this.bttExcluir.Text = "EXCLUIR";
            this.bttExcluir.UseVisualStyleBackColor = true;
            // 
            // bttEditar
            // 
            this.bttEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttEditar.Location = new System.Drawing.Point(653, 183);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(140, 58);
            this.bttEditar.TabIndex = 36;
            this.bttEditar.Text = "EDITAR";
            this.bttEditar.UseVisualStyleBackColor = true;
            // 
            // bttSalvar
            // 
            this.bttSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttSalvar.Location = new System.Drawing.Point(653, 117);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(140, 60);
            this.bttSalvar.TabIndex = 35;
            this.bttSalvar.Text = "SALVAR";
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // cmbCursos
            // 
            this.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(91, 60);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(395, 21);
            this.cmbCursos.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Curso:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(596, 20);
            this.txtNome.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome: ";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(91, 12);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Matricula: ";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttSair);
            this.Controls.Add(this.buttCancelar);
            this.Controls.Add(this.cmIdCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_dados);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Button buttSair;
        private System.Windows.Forms.Button buttCancelar;
        private System.Windows.Forms.ComboBox cmIdCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
    }
}