using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComStructs
{
    public struct CarFeatures
    {
        public bool HasBluetooth { get; set; }
        public bool HasRearViewCamera { get; set; }
        public bool HasTractionControl { get; set; }
        public bool HasHeatedSeats { get; set; }
        public bool HasBlindSpotMonitoring { get; set; }
        public bool HasNavigationSystem { get; set; }

        public string GetFeatures()
        {
            return 
                $"HasBluetooth= {HasBluetooth}" +
                $"\nHasRearViewCamera= {HasRearViewCamera}" +
                $"\nHasTractionControl= {HasTractionControl}" +
                $"\nHasHeatedSeats= {HasHeatedSeats}" +
                $"\nHasBlindSpotMonitoring= {HasBlindSpotMonitoring}" +
                $"\n" +
                $"HasNavigationSystem= {HasNavigationSystem}";
        }
    }
}
