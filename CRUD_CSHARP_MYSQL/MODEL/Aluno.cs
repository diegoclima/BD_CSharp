using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_CSHARP_MYSQL.MODEL.System;
using System.Windows.Forms;

namespace CRUD_CSHARP_MYSQL.MODEL.System {
    public class Aluno {
        private string _nome;
        private int _matricula;
        private int _idCurso;

        public Aluno() { }

        public Aluno(string n, int mat, int idcurso) {
            Nome = n;
            Matricula = mat;
            IdCurso = idcurso;
        }

        public string Nome {
            get { return _nome; }
            set { _nome = value; }

        }

        public int Matricula {
            get { return _matricula; }
            set {
                if (value < 0) {
                    MessageBox.Show("Valor Inválido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    _matricula = value;
                }
            }
        }

        public int IdCurso {
            get { return _idCurso; }
            set { if (value < 0) { MessageBox.Show("Valor inválido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error); } else {
                    _idCurso = value;
                } }
        }

        

    }
}
