/*
 * 7.   Skriv ett uttryck som beräknar arean på en parallelltrapets givet 
 *      sidorna a och b samt höjden h.
*/

Console.WriteLine("Parallelltrapetsens sidor:");
Console.Write("   a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("   b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("Höjd h = ");
double h = double.Parse(Console.ReadLine());

double area = (a + b) * h / 2;
Console.WriteLine($"Parallelltrapetsens area: {area}");