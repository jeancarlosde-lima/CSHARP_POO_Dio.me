DesafioPOO.Models;

 // TODO: Realizar os testes com as classes Motorola e Iphone
 Console.Writeline("Smartphone Motorola:");
Smartphone motorola = new Motorola(numero: "123456", modelo: "N95", imei: "111111", memoria: 128);
motorola.Ligar();
motorola.InstalarAplicativo("whatsapp")

Console.Writeline(---------------------------------)

Console.Writeline("Smartphone Iphone")
Smartphone Iphone = new Iphone(numero: "9876543", modelo:"13 pro max", imei:"222222", memoria: "256");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");