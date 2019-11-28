using System;
using System.Text;
using BerlinClock.Classes.BerlinClock;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            return ToBerlinClockTimeConverter.Convert(aTime);
        }
    }
}