using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_CSHARP_MYSQL.DAO.System;
using CRUD_CSHARP_MYSQL.BLL.System;
using CRUD_CSHARP_MYSQL.MODEL.System;
using MySql.Data.MySqlClient;

namespace CRUD_CSHARP_MYSQL {
    public partial class CadastroCurso : Form {
        public CadastroCurso() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Listar();
        }
        public void LimparCampos() {
            txtNome.Clear();
            txtNome.BackColor = Color.White;
            txtIdcurso.BackColor = Color.White;

        }

        private void Salvar(Curso c) {
            CRUDCurso crud = new CRUDCurso();
            Curso curso = new Curso();
            if ((txtNome.Text.Trim() == string.Empty)) {
                MessageBox.Show("Campos Obrigatórios a serem preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            curso.Descricao = txtNome.Text;
            crud.Cadastrar(curso);
            Listar();

        }
        private void bttSalvar_Click(object sender, EventArgs e) {
            Curso c = new Curso();
            Salvar(c);
        }
        private void Listar() {
            CRUDCurso curso = new CRUDCurso();
           
            
            MySqlDataReader dados = null;

            dg_dados.DataSource = curso.ListaDeCursos(dados);
            dg_dados.Columns[0].HeaderText = "ID";
            dg_dados.Columns[1].HeaderText = "Descricao";
            //dg_dados.Columns[2].HeaderText = "DISCIPLINA";
            dg_dados.Columns[0].Width = 80;
            dg_dados.Columns[1].Width = 300;
          //  dg_dados.Columns[2].Width = 200;
        }

        
    }
}
