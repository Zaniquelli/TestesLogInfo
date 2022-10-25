namespace TestesLogInfo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        public static void MensagemQualquer()
        {
            Console.WriteLine("Ok.");
        }

        public static void MultiplicarQualquer()
        {
            var data = DateTime.Now;
            Console.WriteLine("Resultado multiplicação: " + (data.Day * data.Month));
        }
    }
}
