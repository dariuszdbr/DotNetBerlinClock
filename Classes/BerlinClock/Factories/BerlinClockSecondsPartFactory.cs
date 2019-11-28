using System.Collections.Generic;
using System.Linq;

namespace BerlinClock.Classes.BerlinClock.Factories
{
    public static class BerlinClockSecondsPartFactory
    {
        public static List<BerlinClockPart> Create()
        {
            return new List<BerlinClockPart>{CreateTopPart()};
        }
        private static BerlinClockPart CreateTopPart()
        {
            return BerlinClockPart.Create(
                lamps: Enumerable.Range(0, 1).Select(x => BerlinClockLamp.Create(Color.Yellow())),
                lampsToSwitchOn: (units) => units % 2==0? 1:0);
        }
    }
}