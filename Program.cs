using DesafioPOO.Models;
// Implementado !!!
Console.WriteLine("Nokia: ");
Nokia nokia = new("12345", "c23", "0123499-29", 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Joguinho");

Console.WriteLine();

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone("12342", "16", "0123499-22", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Joguinho");