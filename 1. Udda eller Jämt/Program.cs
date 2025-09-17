/*
 Skriv ett program som kollar om ett givet heltal är jämt eller udda
 */
Console.Write("Ange ett heltal: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Talet är {0} är {1}", number, number % 2 == 0 ? "jämt" : "udda");