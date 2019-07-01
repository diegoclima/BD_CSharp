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
        private MySqlCommand comando = new MySqlCommand();

        public MySqlCommand Comando { get => comando; set => comando = value; }

        public void CadastrarProfessor(Professor prof) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO bd_csharp.aluno (nome,idcurso) VALUES(@nome,@idcurso)", Conexao);
                comando.Parameters.AddWithValue("@nome", prof.Nome.ToString().ToUpper());
                comando.Parameters.AddWithValue("@idcurso", prof.Cursos.Idcurso);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }
    }
}
