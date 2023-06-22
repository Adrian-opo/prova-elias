using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    internal class Meidico : Funcinario
    {
        /*        Médico é um tipo de funcionário que possui todos os atributos e métodos de funcionário além do
        CRM(registro no conselho), valor de hora extra e especialidade.Os médicos recebem um benefício
        de 20% sobre o s
        alário de auxílio periculosidade (não é contabilizado para esse cálculo o valor da
        hora extra). */
        public string CRM { get; set; }
        public double valorHoraExtra { get; set; }
        public string especialidade { get; set; }
        public double salarioAuxilioPericulosidade { get; set; }

        public Meidico(string nome, string CPF, string matricula, DateTime dataNascimento, string sexo, double salario) : base(nome, CPF, matricula, dataNascimento, sexo, salario)
        {

        }

        public Meidico(string nome, string CPF, string matricula, DateTime dataNascimento, string sexo, double salario, string CRM, double valorHoraExtra, string especialidade, double salarioAuxilioPericulosidade) : base(nome, CPF, matricula, dataNascimento, sexo, salario)
        {
            this.CRM = CRM;
            this.valorHoraExtra = valorHoraExtra;
            this.especialidade = especialidade;
            this.salarioAuxilioPericulosidade = calcularBeneficio();
        }

        public Meidico()
        {
        }

        public double calcularSalario()
        {
            return salario + salarioAuxilioPericulosidade;
        }

        public double calcularBeneficio()
        {
            return salarioAuxilioPericulosidade * 0.2;
        }

        public double calcularSalarioTotal()
        {
            return calcularSalario() + calcularBeneficio();
        }



     

    }
}
