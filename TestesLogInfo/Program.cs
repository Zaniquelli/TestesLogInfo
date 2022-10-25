using TestesLogInfo;

internal class Program
{
    private static void Main()
    {
        int flag = 0;

        while (flag == 0)
        {
            Console.WriteLine("Qual o exercício que você deseja executar?");
            string exercicio = Console.ReadLine();

            switch (exercicio)
            {
                case "1":
                    flag = 1;

                    var numeros = Exercicio1.LerNumeros();
                    var operacao = Exercicio1.LerOperador();
                    var numerosConvertidos = Exercicio1.ConverterNumeros(numeros);

                    Exercicio1.RealizarOperacoes(numerosConvertidos, operacao);
                    break;

                case "2":
                    flag = 1;

                    Exercicio2.RepeticaoWhile();
                    break;

                case "3":
                    flag = 1;

                    Pessoa.MensagemQualquer();
                    Pessoa.MultiplicarQualquer();
                    break;

                default:
                    flag = 0;
                    Console.WriteLine("Opção incorreta! :c");
                    break;
            }
        }
    }
}