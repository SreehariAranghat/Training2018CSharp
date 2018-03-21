using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Red1mmBrush : Brush
    {
        public Red1mmBrush()
        {
            base.Color = "Red";
            base.Thickness = 1;
        }

    }
}
