using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingInterfaces
{
    public class Car : Vechile
                        , IEnableEntertainmentSystem
                        , IEnableAirCondition
    {
        public void DecreaseTemprature()
        {
            Console.WriteLine("Decreasing Temprature");
        }

        public void IncreaseTemprature()
        {
            Console.WriteLine("Increasing Temprature");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Playing Music");
        }

        public void PlayRadio()
        {
            Console.WriteLine("Switching to radio");
        }

        public void StopMusic()
        {
            Console.WriteLine("Stopping All Music");
        }

        public void SwitchOffAc()
        {
            throw new NotImplementedException();
        }
    }
}
