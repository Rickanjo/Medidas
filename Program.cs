// Receba uma medida em metros e exiba seus equivalentes em quilômetros e centímetros.

double metros;
double Km;
double cm;

Console.WriteLine("----Conversor de Equivalêcia----\n");

Console.Write("Digite a medida em metros: ");
metros = double.Parse(Console.ReadLine()!);

Km = metros / 1000;
cm = metros * 100;

Console.WriteLine($"\n{metros} equivalente a {Km} quilômetros e {cm} centímetros");