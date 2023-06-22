using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
   /* Para evitar que um usuário crie um funcionário sem um tipo, faça uma programação que evite
criar instâncias da classe funcionário*/


    internal abstract class Funcinario 
    {
        //nome, CPF, matrícula, data de nascimento, sexo, salário
        public string nome { get; set; }
        public string CPF { get; set; }
        public string matricula { get; set; }
        public DateTime dataNascimento { get; set; }
        public string sexo { get; set; }
        public double salario { get; set; }



        public Funcinario(string nome, string CPF, string matricula, DateTime dataNascimento, string sexo, double salario)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.matricula = matricula;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.salario = salario;
        }

        public Funcinario()
        {
        }



    }
}
