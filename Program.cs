using System.Text;
using DesafioPOO.Models;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "012345678912345", memoria: 64);
nokia.Ligar("21 9999-9999");
nokia.ReceberLigacao("21 12345-1234");
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "012345678912345", memoria: 64);
iphone.Ligar("21 9999-9999");
iphone.ReceberLigacao("21 12345-1234");
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Telegram");