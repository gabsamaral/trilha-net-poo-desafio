﻿using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

//Testar classe Nokia
//Instanciando objeto nokia
Nokia nokia = new Nokia("12345678","00197001010000",128);

//Chamando função Ligar() implementada na classe Smartphone
nokia.Ligar();

//Chamando função ReceberLigacao() implementada na classe Smartphone
nokia.ReceberLigacao();

//Chamando função InstalarAplicativo(nomeApp) sobrescrita na classe 
nokia.InstalarAplicativo("TikTok");

//Testar classe Iphone
//Instanciando objeto iphone
Iphone iphone = new Iphone("87654321","00895001013496",256,"New FaceID");

//Chamando função Ligar() implementada na classe Smartphone
iphone.Ligar();

//Chamando função ReceberLigacao() implementada na classe Smartphone
iphone.ReceberLigacao();

//Chamando função InstalarAplicativo(nomeApp) sobrescrita na classe 
iphone.InstalarAplicativo("Instagram");
