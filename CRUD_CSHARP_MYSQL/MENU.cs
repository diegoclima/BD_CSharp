using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CSHARP_MYSQL {
    public partial class MENU : Form {
        public MENU() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void buttAluno_Click(object sender, EventArgs e) {
            CadastroAluno cadastroAluno = new CadastroAluno();
            cadastroAluno.Show();
        }

        private void buttCurso_Click(object sender, EventArgs e) {
            CadastroCurso curso = new CadastroCurso();
            curso.Show();
        }
    }
}
