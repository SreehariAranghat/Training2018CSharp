using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawable drawable = null;
            Brush brush        = null;

            Console.Write("Enter Shape : ");
            string shape = Console.ReadLine();

            Console.Write("Enter Brush : ");
            string strBrush = Console.ReadLine();

            switch(shape)
            {
                case "Square": drawable  = new SquareDrawable();break;
                case "Circle": drawable  = new CircleDrawable();break;
            }

            switch(strBrush)
            {
                case "Red" : brush = new Red1mmBrush();break;
                case "Blue": brush = new Blue2mmBrush();break;
            }

            drawable.Draw(brush);
        }
    }
}
