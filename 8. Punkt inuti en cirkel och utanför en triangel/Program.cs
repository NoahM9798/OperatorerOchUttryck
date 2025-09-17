/*
 * 8.   Skriv ett uttryck som kontrollerar om en given punkt (x, y) ligger 
 *      innanför cirkeln K((1, 1), 3) och 
 *      utanför rektangeln R(top=1, left=-1, width=6, height=2)
*/



Point point = new Point();
Console.WriteLine("Punktens x- och y- koordinater:");
Console.Write("   x = ");
point.X = int.Parse(Console.ReadLine());
Console.Write("   y = ");
point.Y = int.Parse(Console.ReadLine());

bool isInsideCircle = InsideCircle(point);
bool isInsideRectangle = InsideRectangle(point);

if (isInsideCircle && isInsideRectangle)
{
    Console.WriteLine("Punkten ({0}, {1}) är innanför cirkeln och rektangeln", point.X, point.Y);
}
else if (!isInsideCircle && !isInsideRectangle)
{
    Console.WriteLine("Punkten ({0}, {1}) är inte innanför cirkeln eller rektangeln", point.X, point.Y);
}
else if (isInsideCircle && !isInsideRectangle)
{
    Console.WriteLine("Punkten ({0}, {1}) är innanför cirkeln men inte rektangeln", point.X, point.Y);
}
else if (!isInsideCircle && isInsideRectangle)
{
    Console.WriteLine("Punkten ({0}, {1}) är inte innanför cirkeln men inuti rektangeln", point.X, point.Y);
}

static bool InsideCircle(Point point)
    {
        sbyte circleX = 1, circleY = 1, radius = 3;

        point.X = point.X - circleX;
        point.Y = point.Y - circleY;

        if (point.X * point.X + point.Y * point.Y <= radius * radius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

static bool InsideRectangle(Point point)
{
    sbyte rxleft = -1, rytop = 1, rRight = 5, rBottom = -1;

    if ((point.X >= rxleft && point.X <= rRight) && (point.Y >= rBottom && point.Y <= rytop))
    {
        return true;
    }
    else
    {
               return false;
    }
}

public struct Point
{
       public int X;
       public int Y;
}