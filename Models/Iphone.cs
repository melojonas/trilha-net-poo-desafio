namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone() {}
        public Iphone(string numero) : base(numero) {}
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        private List<string> appsInstalados = new List<string>();

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (appsInstalados.Any(x => x == nomeApp))
            {
                Console.WriteLine("App já instalado.");
                return;
            }

            appsInstalados.Add(nomeApp);
        }
    }
}