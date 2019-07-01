using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_CSHARP_MYSQL.DAO.System;
using CRUD_CSHARP_MYSQL.MODEL.System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CRUD_CSHARP_MYSQL.DAO.System {
    public class CrudAluno : BancoDeDados{

        public void Cadastrar(Aluno aluno) {
            BancoDeDados.AbrirConexao();

            BancoDeDados.Comando.CommandText = "INSERT INTO aluno (nome, idcurso)" +
                "VALUES ('" + aluno.Nome + "','" + aluno.Cursos.Idcurso + "' )";
            BancoDeDados.ComandoInsertDeleteUpdate(BancoDeDados.Comando);
            BancoDeDados.FecharConexao();
        }

        public void Editar(Aluno aluno) {
            BancoDeDados.AbrirConexao();
            BancoDeDados.Comando.CommandText = "UPDATE aluno SET nome=@nome WHERE matricula = @id";
            BancoDeDados.ComandoInsertDeleteUpdate(BancoDeDados.Comando);
            BancoDeDados.FecharConexao();
        }

        public void Excluir(Aluno aluno) {
            BancoDeDados.AbrirConexao();
            BancoDeDados.Comando.CommandText = "DELETE FROM aluno WHERE matricula=@matricula";
            BancoDeDados.ComandoInsertDeleteUpdate(BancoDeDados.Comando);
            BancoDeDados.FecharConexao();
        }

        public List<Aluno> ListaDeAlunosECursos(Curso curso, string nome) {
            BancoDeDados.AbrirConexao();
            string nomeLike = nome + "%";
            BancoDeDados.Comando.CommandText = "SELECT aluno.matricula, aluno.nome, curso.descricao AS nomeCurso FROM aluno" +
                "INNER JOIN curso where curso.descricao =  '" + curso.Descricao + "'" + "AND aluno.nome LIKE '" + nomeLike + "'" + " AND curso.idcurso = aluno.idcurso";
            MySqlDataReader dados = BancoDeDados.executaComandoSelect(Comando);
            return ListaDeAlunos(dados);
        }

        public List<Aluno> ListaDeAlunos(MySqlDataReader dados) {
            List<Aluno> listaAluno = new List<Aluno>();
            if (dados.HasRows) {

                while (dados.Read()) {
                    Aluno aluno;
                    int matricula = int.Parse(dados["matricula"].ToString());
                    string nome = dados["nome"].ToString();
                    string descricao = dados["descricao"].ToString();
                    Curso novoCurso = new Curso(descricao);
                    aluno = new Aluno(nome, matricula, novoCurso);
                    listaAluno.Add(aluno);

                }
                dados.Close();

            }
            return listaAluno;
        }


    }
}
