using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_CSHARP_MYSQL.BLL.System;
using CRUD_CSHARP_MYSQL.DAO.System;
using CRUD_CSHARP_MYSQL.MODEL.System;
using MySql.Data.MySqlClient;


namespace CRUD_CSHARP_MYSQL {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        public void LimparCampos() {
            txtMatricula.Clear();
            txtNome.Clear();
            cmbCursos.SelectedIndex = -1;
            cmIdCurso.SelectedIndex = -1;
            txtNome.BackColor = Color.White;
            cmIdCurso.BackColor = Color.White;
            cmbCursos.BackColor = Color.White;

        }

        public void Salvar(Aluno a, Curso c) {
            CrudAluno aluno = new CrudAluno();
           
            if ((txtNome.Text.Trim()==string.Empty)||(cmbCursos.Text.Trim()==string.Empty)||(cmIdCurso.Text.Trim()==string.Empty)) {
                MessageBox.Show("Campos obrigatórios a serem preenchidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            a.Nome = txtNome.Text;
            cmbCursos.Text = c.Descricao;
            a.Matricula = int.Parse(cmIdCurso.Text);
            aluno.Cadastrar(a);
            Listar();

        }

        private void Listar() {
            AlunoBLL alunoBll = new AlunoBLL();
            CrudAluno crud = new CrudAluno();
            MySqlDataReader dados = null;

            dg_dados.DataSource = crud.ListaDeAlunos(dados);
            dg_dados.Columns[0].HeaderText = "MATRICULA";
            dg_dados.Columns[1].HeaderText = "ALUNO";
            dg_dados.Columns[2].HeaderText = "DISCIPLINA";
            dg_dados.Columns[0].Width = 80;
            dg_dados.Columns[1].Width = 300;
            dg_dados.Columns[2].Width = 200;

        }


        private void bttSalvar_Click(object sender, EventArgs e) {
            Aluno aluno = new Aluno();
            Curso curso = new Curso();
            Salvar(aluno, curso);
        }
    }
}
