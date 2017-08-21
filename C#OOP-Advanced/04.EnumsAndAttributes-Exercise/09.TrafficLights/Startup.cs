using System;
using System.Collections.Generic;
using _09.TrafficLights.Enums;

namespace _09.TrafficLights
{
    public class Startup
    {
        public static void Main()
        {
            List<TrafficLight> allTraficLights = new List<TrafficLight>();

            string[] inputSignal = Console.ReadLine().Split();
            int stateChangeCount = int.Parse(Console.ReadLine());

            foreach (var signal in inputSignal)
            {
                TrafficLightColor initialColorState = (TrafficLightColor)Enum.Parse(typeof(TrafficLightColor), signal);
                allTraficLights.Add(new TrafficLight(initialColorState));
            }

            for (int i = 0; i < stateChangeCount; i++)
            {
                foreach (var trafficLight in allTraficLights)
                {
                    trafficLight.ChangeState();
                }

                Console.WriteLine(String.Join(" ", allTraficLights));
            }
        }
    }
}
