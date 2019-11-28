using System;
using System.Collections.Generic;
using System.Linq;
using BerlinClock.Classes.BerlinClock.Factories;

namespace BerlinClock.Classes.BerlinClock
{
    public class BerlinClockSeconds : ITimeUnitProvider
    {
        private List<BerlinClockPart> ClockParts { get; }

        private BerlinClockSeconds(List<BerlinClockPart> clockParts)
        {
            ClockParts = clockParts;
        }

        public string Get(int seconds)
        {
            return string.Join(Environment.NewLine, ClockParts.Select(x => x.Display(seconds)));
        }

        public static BerlinClockSeconds Create()
        {
            return new BerlinClockSeconds(BerlinClockSecondsPartFactory.Create());
        }
    }
}