namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia() {}
        public Nokia(string numero) : base(numero) {}
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        private List<string> appsInstalados = new List<string>();

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (appsInstalados.Any(x => x == nomeApp))
            {
                Console.WriteLine("App já estava instalado.");
                return;
            }

            appsInstalados.Add(nomeApp);
            Console.WriteLine($"{nomeApp} foi instalado.");
        }
    }
}