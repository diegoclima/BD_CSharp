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
        private Curso cursos = new Curso();
        private List<Aluno> listaAluno = new List<Aluno>();

        public Aluno() { }

        public Aluno(string n, int mat, Curso c) {
            Nome = n;
            Matricula = mat;
            Cursos = c;
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

        //public int IdCurso {
        //    get { return _idCurso; }
        //    set { if (value < 0) { MessageBox.Show("Valor inválido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error); } else {
        //            _idCurso = value;
        //        } }
        //}

        public Curso Cursos { get => cursos; set => cursos = value; }
        public List<Aluno> ListaAluno { get => listaAluno; set => listaAluno = value; }
    }
}
