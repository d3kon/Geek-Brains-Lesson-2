using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2;
    public static class Ex21
    {
        public static double ThirdDimDist(double A1, double A2, double A3, double B1, double B2, double B3)
        {
            var squareX = (A1 - B1)*(A1 - B1);
            var squareY = (A2 - B2)*(A2 - B2);
            var squareZ = (A3 - B3)*(A3 - B3);
            var result = Math.Sqrt(squareX+squareY+squareZ);
            return result;
        }
    }
