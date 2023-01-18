namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }

        public Smartphone() {}

        public Smartphone(string numero)
        {
            Numero = numero;
        }  

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para {numero}.");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação de {numero}. Atender? (s/n) ");
            string decisao = Console.ReadLine();

            if (decisao == "s")
            {
                Console.WriteLine($"Você está em uma chamada com {numero}");
            } else {
                Console.WriteLine("A chamada foi rejeitada.");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}