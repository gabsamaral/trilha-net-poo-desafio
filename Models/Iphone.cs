namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, int memoria) : base(numero,"Iphone",imei, memoria)
        {
            Console.WriteLine("Um smartphone do tipo Iphone foi criado");
        }
        
        // Sobrescrever (implementando) o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iphone instalando {nomeApp}...");
        }
    }
}