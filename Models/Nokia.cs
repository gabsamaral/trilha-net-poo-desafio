namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor
        public Nokia(string numero, string imei, int memoria) : base(numero, "Nokia", imei, memoria)
        {
        }

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no Nokia.");
        }
    }
}