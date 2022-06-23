// FIRST SOLUTION

/* Console.WriteLine("Enter coordinate X for the first point: ");
double X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Y for the first point: ");
double Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Z for the first point: ");
double Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinate X for the second point: ");
double X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Y for the second point: ");
double Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Z for the second point: ");
double Z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2) + Math.Pow(Z2-Z1, 2));
Console.Write("Distance between two points is ");
Console.Write(result); */

// SECOND SOLUTION

int[] point1 = new int[3];
Console.WriteLine("Enter coordinate X for the first point: ");
point1[0]=int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Y for the first point: ");
point1[1]=int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Z for the first point: ");
point1[2]=int.Parse(Console.ReadLine());

int[] point2 = new int[3];
Console.WriteLine("Enter coordinate X for the second point: ");
point2[0]=int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Y for the second point: ");
point2[1]=int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Z for the second point: ");
point2[2]=int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(point2[0]-point1[0], 2) + Math.Pow(point2[1]-point1[1], 2) + Math.Pow(point2[2]-point1[2], 2));
Console.Write("Distance between two points is ");
Console.Write(result);

/* Здесь тоже массивы выглядят гораздо массивнее, код длиннее. 
Возможно, мы просто еще другие решения не знаем просто. Первый
вариант полаконичнее */
