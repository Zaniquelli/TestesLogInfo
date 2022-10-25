namespace TestesLogInfo
{
    class Exercicio1
    {
        public static List<string> LerNumeros()
        {
            string primeiroNumero = "";
            string segundoNumero = "";
            int flag = 0;

            Console.WriteLine("== Calculadora do Zé ==");
            
            while (flag == 0)
            {
                Console.WriteLine("Qual o primeiro número da operação?");
                primeiroNumero = Console.ReadLine();

                Console.WriteLine("Qual o segundo número da operação?");
                segundoNumero = Console.ReadLine();

                if (string.IsNullOrEmpty(primeiroNumero) && string.IsNullOrEmpty(segundoNumero))
                {
                    flag = 0;
                    Console.WriteLine("Os números inseridos estão inconsistentes, tente novamente!");
                }
                else
                {
                    flag = 1;
                    Console.WriteLine($"O primeiro número é {primeiroNumero} e o segundo número é {segundoNumero}.");
                }  
            }
            
            return new List<string> { primeiroNumero, segundoNumero };
        }

        public static string LerOperador()
        {
            Console.WriteLine("Qual é a operação que deverá ser realizada(+, -, * ou /)? Se nenhuma for escolhida, todas serão executadas.");
            string operacao = Console.ReadLine();

            return operacao;
        }
        public static List<double> ConverterNumeros(List<string> numeros)
        {
            List<double> numerosConvertidos = new();

            for (int i = 0; i < numeros.Count; i++)
            {
                numerosConvertidos.Add(double.Parse(numeros[i], System.Globalization.CultureInfo.InvariantCulture));
            }

            return numerosConvertidos;
        }

        public static void RealizarOperacoes(List<double> numerosConvertidos, string operacao)
        {
            switch (operacao)
            {
                case "+":
                    Console.WriteLine("O resultado da soma é: " + (numerosConvertidos[0] + numerosConvertidos[1]));
                    break;

                case "-":
                    Console.WriteLine("O resultado da subtração é: " + (numerosConvertidos[0] + numerosConvertidos[1]));
                    break;

                case "*":
                    Console.WriteLine("O resultado da multiplicação é: " + (numerosConvertidos[0] + numerosConvertidos[1]));
                    break;

                case "/":
                    Console.WriteLine("O resultado da divisão é: " + (numerosConvertidos[0] + numerosConvertidos[1]));
                    break;

                default:
                    Console.WriteLine("O resultado da soma é: " + (numerosConvertidos[0] + numerosConvertidos[1]));
                    Console.WriteLine("O resultado da subtração é: " + (numerosConvertidos[0] + numerosConvertidos[1]));
                    Console.WriteLine("O resultado da multiplicação é: " + (numerosConvertidos[0] + numerosConvertidos[1]));
                    Console.WriteLine("O resultado da divisão é: " + (numerosConvertidos[0] + numerosConvertidos[1]));
                    break;
            }
        }
    }
}
