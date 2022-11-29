// int numberA = 32;
// int numberB = 51;
// // Можно прописать и так:
// // int result = numberA + numberB;
// // Console.WriteLine(result);
// Console.WriteLine(numberA + numberB);

int numberA = new Random().Next(1, 10); // 1 2 3 4 5 6 7 8 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10) ;
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);