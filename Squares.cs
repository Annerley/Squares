using System;

namespace Squares
{
    public class Squares
    {
        public double areaOfTriangle(double x, double y, double z)
        {
            double p = (z + y + x) / 2;
            Math.Sqrt(p *(p - x)*(p - y)*(p - z));
            //Проверка на прямогульность треугольника, но оно сюда архитектурно как-то не очень клеится, поэтому закомменчено
            /*
             * if ((z * z + y * y == x * x) || (z * z + x * x == y * y) || (x * x + y * y == z * z))
            {
                Console.WriteLine("It`s right triangle");
            }
            */
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }

        public double areaOfCircle(double r)
        {
            return r * r * Math.PI;
        }

        //любые фигуры несложно добавить новыми методами

        //Без знания типа фигуры можно сделать несколько методов с разным количеством параметров, для треугольника - 3, для круга - 1
    }
}
