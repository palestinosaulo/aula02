﻿using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormView
{
    public partial class frmListaAlunos : Form
    {
        public frmListaAlunos()
        {
            InitializeComponent();
        }

        private void frmListaAlunos_Load(object sender, EventArgs e)
        {
            AlunosController alunosController = new AlunosController();
            dgvAlunos.DataSource = alunosController.ListarTodos();
        }
    }
}
