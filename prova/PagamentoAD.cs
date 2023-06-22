using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
   sealed internal class PagamentoAD : AuxiliarAdministrativo
    {
        public PagamentoAD(string nome, string CPF, string matricula, DateTime dataNascimento, string sexo, double salario, string? mes, double valeTransporte) : base(nome, CPF, matricula, dataNascimento, sexo, salario, valeTransporte)
        {
valorTotalPagamento = valorTotalPagamentoFuncionariosM();
            this.mes = mes;
            this.valorIPRF = calcularValorIPRF();
            this.horasExtrasTrabalhadas = horasExtrasTrabalhadas;
            this.valorPagamento = calcularValorPagamento();

        }

        /*    Você também deve implementar a folha de pagamento que possui um mês correspondente, um
funcionário, valor de IPRF(calculado sobre o valor final), quantidade de horas extras trabalhadas e
calcular o valor de pagamento(salário mais benefícios). Após o calculo desse valor, deve-se
   descontar 17% dos salários acima de R$ 5.000,00 referentes ao IPRF(esse cálculo não leva em
conta o valor de horas extras)*/

        /*Na folha de pagamento, crie um atributo estático para controlar o valor total de pagamento para
todos os funcionários*/

        public static double valorTotalPagamento { get; set; }
        public string mes { get; set; }
        public double valorIPRF { get; set; }

        public double horasExtrasTrabalhadas { get; set; }

        public double valorPagamento { get; set; }

        public double calcularValorPagamento()
        {
            return calcularSalarioTotal() + horasExtrasTrabalhadas;
        }

        public double calcularValorPagamento(double valeTransporte)
        {
            return calcularSalarioTotal() + horasExtrasTrabalhadas + valeTransporte;
        }

        public double calcularValorIPRF()
        {
            if (calcularSalarioTotal() > 5000)
            {
                return calcularSalarioTotal() * 0.17;
            }
            else
            {
                return 0;
            }
        }

        public double calcularValorIPRF(double valeTransporte)
        {
            if (calcularSalarioTotal() > 5000)
            {
                return calcularSalarioTotal() * 0.17;
            }
            else
            {
                return 0;
            }
        }


        public double calcularValorPagamentoTotal()
        {
            return calcularValorPagamento() - calcularValorIPRF();
        }

        public double valorTotalPagamentoFuncionariosM()
        {
            return valorTotalPagamento += calcularValorPagamentoTotal();
        }

        /*    Faça um método estático na classe folha de pagamento que receba como parâmetro uma lista de
   folha de pagamento e um mês e retorne o valor gasto com pagamento no mês recebido por
   parâmetro.Realize o teste do método usando os dados informados pelo usuário*/

        public static double valorTotalPagamentoMes(List<PagamentoAD> listaPagamento, string mes)
        {
            double valorTotal = 0;
            foreach (PagamentoAD pagamento in listaPagamento)
            {
                if (pagamento.mes == mes)
                {
                    valorTotal += pagamento.valorPagamento;
                }
            }
            return valorTotal;
        }


    }
}
