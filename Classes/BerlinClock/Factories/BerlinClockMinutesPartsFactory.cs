using System.Collections.Generic;
using System.Linq;

namespace BerlinClock.Classes.BerlinClock.Factories
{
    public static class BerlinClockMinutesPartsFactory
    {
        public static List<BerlinClockPart> Create()
        {
            return new List<BerlinClockPart>{CreateTopPart(), CreateBottomPart()};
        }

        private static BerlinClockPart CreateBottomPart()
        {
            return BerlinClockPart.Create(
                lamps: Enumerable.Range(0, 4).Select(x =>  BerlinClockLamp.Create(Color.Yellow())), 
                lampsToSwitchOn: (units) => units % 5);
        }

        private static BerlinClockPart CreateTopPart()
        {
            return BerlinClockPart.Create(
                lamps: Enumerable.Range(1, 11)
                    .Select(x => x % 3 == 0
                                ? BerlinClockLamp.Create(Color.Red())
                                : BerlinClockLamp.Create(Color.Yellow())),
                lampsToSwitchOn: (units) => units / 5);
        }
    }
}