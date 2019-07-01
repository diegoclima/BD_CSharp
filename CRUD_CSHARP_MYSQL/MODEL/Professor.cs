using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_CSHARP_MYSQL.MODEL.System;

namespace CRUD_CSHARP_MYSQL.MODEL.System {
    public class Professor {
        private int _matricula;
        private Curso cursos = new Curso();
        private string _nome;

        public Professor() { }

        public Professor(string nome, int matricula, Curso c) {
            Nome = nome;
            Matricula = matricula;
            Cursos = c;
        }
        public int Matricula {
            get { return _matricula; }
            set {
                if (value < 0) {
                    MessageBox.Show("Valor inválido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    _matricula = value;
                }
            }
        }

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }

        //public int IdCurso {
        //    get { return _idcurso; }
        //    set {
        //        if (value<0) {
        //            MessageBox.Show("Valor inválido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }
        //}

        public Curso Cursos { get => cursos; set => cursos = value; }
    }
}
