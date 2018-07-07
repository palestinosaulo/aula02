using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormView.TelasAluno;

namespace WindowsFormView
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarAluno_Click(object sender, EventArgs e)
        {
            frmCadastroAluno cadAluno = new frmCadastroAluno();
            cadAluno.ShowDialog();
            
        }

        private void listarAluno_Click(object sender, EventArgs e)
        {
            frmListaAlunos listaAlunos = new frmListaAlunos();
            listaAlunos.Show();
        }
    }
}
