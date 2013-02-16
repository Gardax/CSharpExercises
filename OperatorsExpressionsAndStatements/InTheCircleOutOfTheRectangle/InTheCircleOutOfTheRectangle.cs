using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InTheCircleOutOfTheRectangle
{
    class InTheCircleOutOfTheRectangle
    {
        static void Main(string[] args)
        {
            int x = 4; // x of the point
            int y = 4; // y of the point
            int xk = 1; // x of the K
            int yk = 1; // y of the K
            int rk = 3; // radius of the K
            int top = 1; //top of the rectangle 
            int left = -1; // left point of the rectangle
            int width = 6; // width of the rectangle
            int height = 2; // heiht of the rectangle
            if ((x < (xk + rk)) && (x > (xk - rk)) && (y < (yk + rk)) && (y > (yk - rk))
             && (((x < left) || (x > (left + width))) || ((y > top) || (y < (top - height)))))
            {
                Console.WriteLine("The point is out of the rectangle and in the circle!");
            }
            else
            {
                Console.WriteLine("The point is not out of the rectangle and in the circle!");
            }
        }
    }
}
