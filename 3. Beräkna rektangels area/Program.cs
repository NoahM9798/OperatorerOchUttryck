/*
 Skriv ett uttryck som beräknar area av en rektangel utifrån inmatade höjd och bredd
 */

Console.Write("Ange bredd: ");
double bredd = double.Parse(Console.ReadLine());
Console.Write("Ange höjd: ");
double höjd = double.Parse(Console.ReadLine());

Console.WriteLine($"Rektangelns area: {bredd * höjd}");