using System.Collections.Generic;
using System.Linq;

namespace BerlinClock.Classes.BerlinClock.Factories
{
    public static class BerlinClockHoursPartsFactory
    {
        public static List<BerlinClockPart> Create()
        {
            return new List<BerlinClockPart>{CreateTopPart(), CreateBottomPart()};
        }

        private static BerlinClockPart CreateBottomPart()
        {
            return BerlinClockPart.Create(
                lamps: Enumerable.Range(0, 4).Select(x => BerlinClockLamp.Create(Color.Red())),
                lampsToSwitchOn: (units) => units % 5);
        }

        private static BerlinClockPart CreateTopPart()
        {
            return BerlinClockPart.Create(
                lamps: Enumerable.Range(0, 4).Select(x => BerlinClockLamp.Create(Color.Red())),
                lampsToSwitchOn: (units) => units / 5);
        }
    }
}