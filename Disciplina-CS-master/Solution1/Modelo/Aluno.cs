using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Aluno
    {

        public int AlunoID { get; set; }

        private string nome;
        
        public string Nome
        {
            get { return nome; }

            set { nome = value; }

        }


        [Required]
        public int Matricula { get; set; }

        public string Disciplina { get; set; }

    }
}
