Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int xa = 20, ya = 1,
    xb = 60, yb = 1,
    xc = 1, yc = 15,
    xd = 80, yd = 15,
    xe = 20, ye = 30,
    xf = 60, yf = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

Console.SetCursorPosition(xe, ye);
Console.WriteLine("+");

Console.SetCursorPosition(xf, yf);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 6); // [0,3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    if (what == 3)
    {
        x = (x + xd) / 2;
        y = (y + yd) / 2;
    }
    
    if (what == 4)
    {
        x = (x + xe) / 2;
        y = (y + ye) / 2;
    }
    
    if (what == 5)
    {
        x = (x + xf) / 2;
        y = (y + yf) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
    // count = count + 1;
    // count +=1;
}