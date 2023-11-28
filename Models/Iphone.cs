namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Propriedade específica para iPhone
        public string FaceID { get; set; }

        // Construtor
        public Iphone(string numero, string imei, int memoria, string faceID) : base(numero, "iPhone", imei, memoria)
        {
            FaceID = faceID;
        }

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no {Modelo} com FaceID {FaceID}.");
        }
    }
}