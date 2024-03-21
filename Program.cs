using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine ("Smartphone Nokia:");
Smartphone Nokia = new Nokia (numero :"11981463439" , modelo : "Modelo 1" , imei: "12345" , memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine ("Smartphone Iphone:");
Smartphone Iphone = new Iphone (numero :"11980723318" , modelo : "Modelo 2" , imei: "123456" , memoria: 68);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");


