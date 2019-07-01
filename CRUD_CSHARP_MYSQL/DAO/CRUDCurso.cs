using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_CSHARP_MYSQL.BLL.System;
using CRUD_CSHARP_MYSQL.DAO.System;
using CRUD_CSHARP_MYSQL.MODEL.System;
using MySql.Data.MySqlClient;

namespace CRUD_CSHARP_MYSQL.DAO.System {
    public class CRUDCurso :BancoDeDados {
        public void Cadastrar(Curso curso) {
            BancoDeDados.AbrirConexao();

            BancoDeDados.Comando.CommandText = "INSERT INTO curso (descricao)" +
                "VALUES ('" + curso.Descricao + ")";
            BancoDeDados.ComandoInsertDeleteUpdate(BancoDeDados.Comando);
            BancoDeDados.FecharConexao();
        }

        public void Editar(Curso curso) {
            BancoDeDados.AbrirConexao();
            BancoDeDados.Comando.CommandText = "UPDATE curso SET descricao=@desc WHERE idcurso = @id";
            BancoDeDados.ComandoInsertDeleteUpdate(BancoDeDados.Comando);
            BancoDeDados.FecharConexao();
        }

        public void Excluir(Curso curso) {
            BancoDeDados.AbrirConexao();
            BancoDeDados.Comando.CommandText = "DELETE FROM curso WHERE idcurso=@idcurso";
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

        public List<Curso> ListaDeCursos(MySqlDataReader dados) {
            List<Curso> listaCursos = new List<Curso>();
            if (dados.HasRows) {

                while (dados.Read()) {

                    int idcurso = int.Parse(dados["idcurso"].ToString());
                    string descricao = dados["descricao"].ToString();
                    //string descr = dados["descricao"].ToString();
                    Curso novoCurso = new Curso(descricao);
                    novoCurso = new Curso(descricao,idcurso);
                    listaCursos.Add(novoCurso);

                }
                dados.Close();

            }
            return listaCursos;
        }
    }
}
