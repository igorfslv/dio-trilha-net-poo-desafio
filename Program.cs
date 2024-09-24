using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "NK-1", imei:"111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Google Chrome");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Iphone 1", imei:"222222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Safari");