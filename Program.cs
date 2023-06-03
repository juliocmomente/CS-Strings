System.Console.WriteLine("Olá, mundo!");
Console.WriteLine("Qual o seu nome?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Olá, {name}, Hoje é  {currentDate:d}, agora são {currentDate:t}!");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);