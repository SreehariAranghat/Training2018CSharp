using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bike bike = new Bike();

            HondaVx vx = new HondaVx();
            HondaZx zx = new HondaZx();

            vx.PlayMusic();
            vx.DecreaseTemprature();

            zx.DecreaseTemprature();
            zx.OpenSunroof();
         
        }
    }
}
