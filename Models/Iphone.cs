namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Propriedade específica de iphone
        public string FaceID { get; set; }
        public Iphone(string numero, string imei, int memoria, string faceid) : base(numero,"Iphone",imei, memoria)
        {
            FaceID = faceid;
            Console.WriteLine($"Um smartphone do tipo Iphone foi criado com numero: {numero}");
        }
        
        // Sobrescrever (implementa) o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iphone instalando {nomeApp}...");
        }
    }
}