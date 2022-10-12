//  Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.

void Piff()
{
    Random random = new Random();
    double a1 =  random.Next(1,20);
    double a2 =  random.Next(1,20);
    double a3 =  random.Next(1,20);
    double b1 =  random.Next(1,20);
    double b2 =  random.Next(1,20);
    double b3 =  random.Next(1,20);


  //  double a1 =  3;
  // double a2 =  6;
  //  double a3 =  8;
  //  double b1 =  2;
  //  double b2 =  1;
  //  double b3 = -7;
     // 15.84
    
    CoordRange(a1, a2, b1, b2, a3, b3);
}

void CoordRange(double a1, double a2, double b1, double b2, double a3, double b3)
{
    double range = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2) + Math.Pow(a3 - b3, 2));
    Console.WriteLine("Расстояние между 2мя точками " + (Math.Round(range, 2)));
}

Piff();