using System;
namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        //Construtor da classe filha : passando o construtor da classe mãe /comando base(...) invoca a mãe
        public Nokia(string numero, string imei, int memoria) : base(numero,"Nokia",imei, memoria)
        {
            Console.WriteLine($"Um smartphone do tipo Nokia foi criado com numero: {numero}");
        }
        
        // Sobrescrever (implementa) o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Nokia instalando {nomeApp}...");
        }
    }
}