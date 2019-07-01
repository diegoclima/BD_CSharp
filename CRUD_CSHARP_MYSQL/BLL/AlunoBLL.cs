using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_CSHARP_MYSQL.BLL.System;
using CRUD_CSHARP_MYSQL.DAO.System;
using CRUD_CSHARP_MYSQL.MODEL.System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CRUD_CSHARP_MYSQL.BLL.System {
    public class AlunoBLL :BancoDeDados {
        CrudAluno crud = new CrudAluno();
        

        public void Salvar(Aluno aluno) {
            try {
                crud.Cadastrar(aluno);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro " + ex.Message);
                
            }
        }

        //public void Listar() {
        //    MySqlCommand comando = new MySqlCommand();
        //    BancoDeDados.executaComandoSelect(comando);
        //}

        public void Editar(Aluno aluno) {
            try {
                crud.Editar(aluno);
            }
            catch (Exception ex) {

                MessageBox.Show("Erro " + ex.Message);
            }
        }

       
    }
}
