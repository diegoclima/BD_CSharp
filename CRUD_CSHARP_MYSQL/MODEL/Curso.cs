using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_CSHARP_MYSQL.DAO.System;
using CRUD_CSHARP_MYSQL.MODEL.System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUD_CSHARP_MYSQL.MODEL.System {
    public class Curso {
        private string descricao;
        private int idcurso;

        public Curso() { }

        public Curso(string descricao, int idcurso) {
            this.descricao = descricao;
            this.idcurso = idcurso;
        }

        public Curso(string desc) {
            this.Descricao = desc;
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public int Idcurso { get => idcurso; set => idcurso = value; }
    }
}
