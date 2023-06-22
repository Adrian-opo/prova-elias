/*Faça uma interação com o usuário que pergunte quantos funcionários deseja cadastrar. Após isso,
leia essa quantidade de funcionário perguntado a cada funcionário se é Administrativo ou Médico e
criando a instância da classe folha de pagamento passando esse funcionário para a folha de
pagamento.*/
using prova;

try
{


    Console.WriteLine("Quantos funcionários deseja cadastrar?");
    int quantidadeFuncionarios = int.Parse(Console.ReadLine());
    int contador = 0;
    List<PagamentoM> listaPagamento = new List<PagamentoM>();
    List<PagamentoAD> listaPagamentoAD = new List<PagamentoAD>();


    do
    {

        Console.WriteLine("QUal o TIPO do funcinario?");
        Console.WriteLine("1 - Auxiliar Admisitrativo");
        Console.WriteLine("2 - Médico");
        int tipoFuncionario = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o mês do " + (contador + 1) + "º da folah de pagamento do funcionário");
        string mes = Console.ReadLine();

        Meidico medico = new Meidico();
        AuxiliarAdministrativo auxiliarAdministrativo = new AuxiliarAdministrativo();
        PagamentoM pagamentoM;
        PagamentoAD pagamentoA;

        switch (tipoFuncionario)
        {
            case 1:

                //funcao
                Console.WriteLine("Digite a função do " + (contador + 1) + "º funcionário");
                auxiliarAdministrativo.funcao = Console.ReadLine();

                Console.WriteLine("Digite o nome do " + (contador + 1) + "º funcionário");
                auxiliarAdministrativo.nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF do " + (contador + 1) + "º funcionário");
                auxiliarAdministrativo.CPF = Console.ReadLine();
                Console.WriteLine("Digite a matricula do " + (contador + 1) + "º funcionário");
                auxiliarAdministrativo.matricula = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento do " + (contador + 1) + "º funcionário");
                Console.WriteLine("Exemplo 22/09/22");
                auxiliarAdministrativo.dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o sexo do " + (contador + 1) + "º funcionário");
                auxiliarAdministrativo.sexo = Console.ReadLine();
                Console.WriteLine("Digite o salário do " + (contador + 1) + "º funcionário");
                auxiliarAdministrativo.salario = double.Parse(Console.ReadLine());


                //vale alimentação
                /*Console.WriteLine("Digite o vale alimentação do " + (contador + 1) + "º funcionário");
                auxiliarAdministrativo.valeAlimentacao = double.Parse(Console.ReadLine());*/



                //vale transporte
                /* Console.WriteLine("Digite o vale transporte do " + (contador + 1) + "º funcionário");
                 double valeTransporte = double.Parse(Console.ReadLine());*/
                pagamentoA = new PagamentoAD(auxiliarAdministrativo.nome, auxiliarAdministrativo.CPF, auxiliarAdministrativo.matricula, auxiliarAdministrativo.dataNascimento, auxiliarAdministrativo.sexo, auxiliarAdministrativo.salario, mes, auxiliarAdministrativo.valeTransporte);
                Console.WriteLine("O valor do pagamento é: " + pagamentoA.calcularValorPagamento());
                Console.WriteLine("O valor do IPRF é: " + pagamentoA.calcularValorIPRF());
                listaPagamentoAD.Add(pagamentoA);
                break;
            case 2:

                Console.WriteLine("Digite o nome do " + (contador + 1) + "º funcionário");
                medico.nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF do " + (contador + 1) + "º funcionário");
                medico.CPF = Console.ReadLine();
                Console.WriteLine("Digite a matricula do " + (contador + 1) + "º funcionário");
                medico.matricula = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento do " + (contador + 1) + "º funcionário");
                Console.WriteLine("Exemplo 22/09/22");
                medico.dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o sexo do " + (contador + 1) + "º funcionário");
                medico.sexo = Console.ReadLine();
                Console.WriteLine("Digite o salário do " + (contador + 1) + "º funcionário");
                medico.salario = double.Parse(Console.ReadLine());

                //mes


                Console.WriteLine("Digite a especialidade do " + (contador + 1) + "º funcionário");
                medico.especialidade = Console.ReadLine();
                //crm
                Console.WriteLine("Digite o CRM do " + (contador + 1) + "º funcionário");
                medico.CRM = Console.ReadLine();
                //horas extras trabalhadas
                Console.WriteLine("Digite as horas extras trabalhadas do " + (contador + 1) + "º funcionário");
                double horasExtrasTrabalhadas = double.Parse(Console.ReadLine());
                //valor hora extra
                Console.WriteLine("Digite o valor da hora extra do " + (contador + 1) + "º funcionário");
                medico.valorHoraExtra = double.Parse(Console.ReadLine());
                pagamentoM = new PagamentoM(medico.nome, medico.CPF, medico.matricula, medico.dataNascimento, medico.sexo, medico.salario, mes, horasExtrasTrabalhadas);
                Console.WriteLine("O valor do pagamento é: " + pagamentoM.calcularValorPagamento());
                listaPagamento.Add(pagamentoM);

                Console.WriteLine("O valor do IPRF é: " + pagamentoM.calcularValorIPRF());
                break;
            default:
                break;
        }


        Console.WriteLine("Total folha de pagamento");


        contador++;


    } while (contador != quantidadeFuncionarios);

    Console.WriteLine("O valor total da folha de pagamento é: " + (PagamentoM.valorTotalPagamento + PagamentoAD.valorTotalPagamento));

    // mostrar volor total pagamento no mes
    Console.WriteLine("Digite um mes para verificar a folha de pagamento");
    string mese = Console.ReadLine();
    Console.WriteLine(PagamentoAD.valorTotalPagamentoMes(listaPagamentoAD, mese) + PagamentoM.valorTotalPagamentoMes(listaPagamento, mese));


}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
//fiz o selaed de um jeito diferente pense com carinho

