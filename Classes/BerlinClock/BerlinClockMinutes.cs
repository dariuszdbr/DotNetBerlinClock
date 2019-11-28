using System;
using System.Collections.Generic;
using System.Linq;
using BerlinClock.Classes.BerlinClock.Factories;

namespace BerlinClock.Classes.BerlinClock
{
    public class BerlinClockMinutes : ITimeUnitProvider
    {
        private List<BerlinClockPart> ClockParts { get; }

        private BerlinClockMinutes(List<BerlinClockPart> clockParts)
        {
            ClockParts = clockParts;
        }

        public string Get(int minutes)
        {
            return string.Join(Environment.NewLine, ClockParts.Select(x => x.Display(minutes)));
        }

        public static BerlinClockMinutes Create()
        {
            return new BerlinClockMinutes(BerlinClockMinutesPartsFactory.Create());
        }
    }
}