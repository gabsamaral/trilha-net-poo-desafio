using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Teste com a classe Nokia
            Console.WriteLine("Smartphone Nokia: ");
            Smartphone nokia = new Nokia(numero: "555-1234", imei: "123456789", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            // Teste com a classe Iphone
            Console.WriteLine("Smartphone iPhone: ");
            Smartphone iphone = new Iphone(numero: "555-5678", imei: "987654321", memoria: 128, faceID: "123FaceID");
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine(); // Aguarda pressionamento de tecla para encerrar
        }
    }
}