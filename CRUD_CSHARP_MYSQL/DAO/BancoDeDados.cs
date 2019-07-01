using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_CSHARP_MYSQL.MODEL.System;
using MySql.Data.MySqlClient;


namespace CRUD_CSHARP_MYSQL.DAO.System {
    /// <summary>
    /// Classe de conexao com o banco de dados MySQL. 
    /// Recebe do usuario o servidor, usuario, senha e nome do bd.
    /// </summary>
    public class BancoDeDados {
        private static string StrConectarBD = "DATABASE=bd_csharp; SERVER=localhost; UID=root; PWD=Mxw34379@";
        protected static MySqlConnection Conexao = new MySqlConnection();
        protected static MySqlCommand Comando = new MySqlCommand();

        protected static void AbrirConexao() {
            try {
                Conexao = new MySqlConnection(StrConectarBD);
                Conexao.Open();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro " + ex.Message);
            }
        }

        protected static void FecharConexao() {
            try {
                Conexao.Close();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        protected static int ComandoInsertDeleteUpdate(MySqlCommand comando) {
            int result = 0;

            try {
                comando = new MySqlCommand(comando.CommandText, Conexao);
                result = comando.ExecuteNonQuery();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro " + ex.Message);
            }
            return result;
        }

        protected static MySqlDataReader executaComandoSelect(MySqlCommand comando) {

            MySqlDataReader obj = null;
            try {
                comando = new MySqlCommand(comando.CommandText, Conexao);
                obj = comando.ExecuteReader();
            }
            catch (Exception ex) {

                MessageBox.Show("Error " + ex.Message);
                
            }
            return obj;
        }

        

       
        
    }
}
