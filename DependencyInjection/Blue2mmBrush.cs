using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Blue2mmBrush : Brush
    {
        public Blue2mmBrush()
        {
            base.Color = "Blue";
            base.Thickness = 2;
        }
    }
}
