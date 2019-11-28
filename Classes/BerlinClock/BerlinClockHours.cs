using System;
using System.Collections.Generic;
using System.Linq;
using BerlinClock.Classes.BerlinClock.Factories;

namespace BerlinClock.Classes.BerlinClock
{
    public class BerlinClockHours: ITimeUnitProvider
    {
        private List<BerlinClockPart> ClockParts { get; }

        private BerlinClockHours(List<BerlinClockPart> clockParts)
        {
            ClockParts = clockParts;
        }

        public string Get(int hours)
        {
            return string.Join(Environment.NewLine, ClockParts.Select(x => x.Get(hours)));
        }

        public static BerlinClockHours Create()
        {
            return new BerlinClockHours(BerlinClockHoursPartsFactory.Create());
        }
    }
}