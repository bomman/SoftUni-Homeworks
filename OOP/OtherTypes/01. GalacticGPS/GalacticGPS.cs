using System;

namespace _01.GalacticGPS
{
    class GalacticGPS
    {
        static void Main()
        {
            Location gps = new Location(-90, 180, Planet.Earth);
            Console.WriteLine(gps);
        }
    }
}
