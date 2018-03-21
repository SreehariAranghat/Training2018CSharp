using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingInterfaces
{
    public class HondaZx : HondaVx, IEnableSunroof
    {
        public void CloseSunroof()
        {
            Console.WriteLine("Closing Sunroof");
        }

        public void OpenSunroof()
        {
            Console.WriteLine("Opening Sunroof");
        }
    }
}
