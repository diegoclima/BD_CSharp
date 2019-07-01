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
    public class CrudProfessor : BancoDeDados{
        public void Cadastrar(Professor prof) {
            BancoDeDados.AbrirConexao();
            BancoDeDados.Comando.CommandText = "INSERT INTO professor (nome, idcurso)" +
                           "VALUES ('" + prof.Nome + "','" + prof.Cursos.Idcurso + "' )";
            BancoDeDados.ComandoInsertDeleteUpdate(BancoDeDados.Comando);
            BancoDeDados.FecharConexao();
        }

        public void Editar(Professor p) {
            BancoDeDados.AbrirConexao();
            BancoDeDados.Comando.CommandText = "UPDATE professor SET nome=@nome WHERE matricula=@matricula";
            BancoDeDados.ComandoInsertDeleteUpdate(BancoDeDados.Comando);
            BancoDeDados.FecharConexao();
        }

        public void Excluir(Professor p) {
            BancoDeDados.AbrirConexao();
            BancoDeDados.Comando.CommandText = "DELETE FROM professor WHERE matricula=@matricula";
            BancoDeDados.ComandoInsertDeleteUpdate(BancoDeDados.Comando);
            BancoDeDados.FecharConexao();
        }

        //public List<Aluno> ListaDeAlunosECursos(Curso curso, string nome) {
        //    BancoDeDados.AbrirConexao();
        //    string nomeLike = nome + "%";
        //    BancoDeDados.Comando.CommandText = "SELECT aluno.matricula, aluno.nome, curso.descricao AS nomeCurso FROM aluno" +
        //        "INNER JOIN curso where curso.descricao =  '" + curso.Descricao + "'" + "AND aluno.nome LIKE '" + nomeLike + "'" + " AND curso.idcurso = aluno.idcurso";
        //    MySqlDataReader dados = BancoDeDados.executaComandoSelect(Comando);
        //    return ListaDeAlunos(dados);
        //}

        public List<Professor> ListaDeProfessor(MySqlDataReader dados) {
            List<Professor> listaProfessores = new List<Professor>();
            if (dados.HasRows) {

                while (dados.Read()) {

                    Professor prof;
                    int matricula = int.Parse(dados["matricula"].ToString());
                    string nome = dados["nome"].ToString();
                    string descricao = dados["descricao"].ToString();
                    Curso novoCurso = new Curso(descricao);
                    prof = new Professor(nome, matricula, novoCurso);
                    listaProfessores.Add(prof);

                }
                dados.Close();

            }
            return listaProfessores;
        }
        public List<Professor> ListaDeAlunosECursos(Curso curso, string nome) {
            BancoDeDados.AbrirConexao();
            string nomeLike = nome + "%";
            BancoDeDados.Comando.CommandText = "SELECT professor.matricula, professor.nome, curso.descricao AS nomeCurso FROM professor" +
                "INNER JOIN curso where curso.descricao =  '" + curso.Descricao + "'" + "AND professor.nome LIKE '" + nomeLike + "'" + " AND curso.idcurso = professor.idcurso";
            MySqlDataReader dados = BancoDeDados.executaComandoSelect(Comando);
            return ListaDeProfessor(dados);
        }
        //private MySqlCommand comando = new MySqlCommand();

        //public MySqlCommand Comando { get => comando; set => comando = value; }

        //public void CadastrarProfessor(Professor prof) {
        //    try {
        //        AbrirConexao();
        //        comando = new MySqlCommand("INSERT INTO bd_csharp.aluno (nome,idcurso) VALUES(@nome,@idcurso)", Conexao);
        //        comando.Parameters.AddWithValue("@nome", prof.Nome.ToString().ToUpper());
        //        comando.Parameters.AddWithValue("@idcurso", prof.Cursos.Idcurso);
        //        comando.ExecuteNonQuery();
        //    }
        //    catch (Exception ex) {

        //        MessageBox.Show("Erro: " + ex.Message);
        //    }
        //    finally {
        //        FecharConexao();
        //    }
        //}
    }
}
