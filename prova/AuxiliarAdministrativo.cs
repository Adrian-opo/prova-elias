using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    internal class AuxiliarAdministrativo : Funcinario


    /*  Existe também os funcionários do administrativo que possui todos os atributos de funcionários
    além da função.Esse tipo de funcionário tem no seu salário uma acréscimo de R$ 150 de vale
    transporte e 15% a mais do salário de vale alimentação(sobre o salário sem conta o vale transporte)*/
    {
        public AuxiliarAdministrativo(string nome, string CPF, string matricula, DateTime dataNascimento, string sexo, double salario, double valeTransporte) : base(nome, CPF, matricula, dataNascimento, sexo, salario)
        {
            this.funcao = funcao;
            this.valeAlimentacao = calcularValeAlimentacao();
            this.valeTransporte = 150;
        }

        public AuxiliarAdministrativo()
        {
        }

        public string funcao { get; set; }

        public double valeTransporte { get; set; }

        public double valeAlimentacao { get; set; }

        public double calcularSalario()
        {
            return salario + 150;
        }

        public double calcularValeAlimentacao()
        {
            return calcularSalario() * 0.15;
        }

        public double calcularSalarioTotal()
        {
            return calcularSalario() + calcularValeAlimentacao() + valeTransporte;
        }


    }
}
