namespace TestesLogInfo
{
    class Exercicio2
    {
        public static void RepeticaoWhile()
        {
            int flag = 0;

            Console.WriteLine("== Repetidor ==");

            int estrutura = LerEstrutura();

            string frase = LerFrase();


            while (flag == 0)
            {
                if (estrutura == 2)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"A frase foi: {frase}");
                    }

                    string repeticao = LerRepeticao();

                    if (string.Equals(repeticao, "N"))
                    {
                        Console.WriteLine("Repetição encerrada!");
                        flag = 1;
                    }
                } 
                else if (estrutura == 1)
                {
                    do
                    {
                        Console.WriteLine($"A frase foi: {frase}");

                        string repeticao = LerRepeticao();

                        if (string.Equals(repeticao, "N"))
                        {
                            Console.WriteLine("Repetição encerrada!");
                            flag = 1;
                        }

                    } while (flag == 0);
                }
            }
        }

        public static string LerFrase()
        {
            Console.WriteLine("Qual é a frase que deverá ser repetida?");
            string frase = Console.ReadLine();

            if (!string.IsNullOrEmpty(frase))
            {
                return frase;
            }
            else
            {
                return "Frase não definida!";
            }
        }

        public static int LerEstrutura()
        {
            int flag = 0;
            int estrutura = 1;

            while (flag == 0)
            {
                Console.WriteLine("Qual o tipo de repetição você deseja realizar, DoWhile (1) ou For (2)? Por padrão, será While!");
                var insercao = Console.ReadLine();

                if (insercao == "1" )
                {
                    estrutura = Int32.Parse(insercao);
                    flag = 1;
                }
                else if (insercao == "2")
                {
                    estrutura = Int32.Parse(insercao);
                    flag = 1;
                }
            }
            return estrutura;
        }

        public static string LerRepeticao()
        {
            Console.WriteLine("Deseja continuar a repetição (S ou N)?");
            string repeticao = Console.ReadLine();

            return repeticao;
        }
    }
}
