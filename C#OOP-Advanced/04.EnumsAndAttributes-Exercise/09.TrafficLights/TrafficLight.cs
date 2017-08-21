using System;
using _09.TrafficLights.Enums;

namespace _09.TrafficLights
{
    public class TrafficLight
    {
        private TrafficLightColor colorState;

        public TrafficLight(TrafficLightColor colorState)
        {
            this.colorState = colorState;
        }

        public void ChangeState()
        {
            this.colorState = (TrafficLightColor)(((int)this.colorState + 1)
                                           % Enum.GetNames(typeof(TrafficLightColor)).Length);
        }

        public override string ToString()
        {
            return this.colorState.ToString();
        }
    }
}
