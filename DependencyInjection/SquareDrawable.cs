using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class SquareDrawable : IDrawable
    {
        public void Draw(Brush brush)
        {
      
            Console.WriteLine($"Drawing Square using {brush.Color} with thickness {brush.Thickness}");
        }
    }
}
