using System;
using System.Collections.Generic;
using System.Linq;

namespace BerlinClock.Classes.BerlinClock
{
    public class BerlinClockPart
    {
        private readonly Func<int, int> _lampsToSwitchOn;
        private List<BerlinClockLamp> Lamps { get; }

        private BerlinClockPart(IEnumerable<BerlinClockLamp> lamps, Func<int, int> lampsToSwitchOn)
        {
            _lampsToSwitchOn = lampsToSwitchOn;
            Lamps = lamps.ToList();
        }

        public string Display(int units)
        {
            Enumerable.Range(0, _lampsToSwitchOn(units)).ToList().ForEach(index => Lamps[index].SwitchOn());

            return string.Join(string.Empty, Lamps);
        }

        public static BerlinClockPart Create(IEnumerable<BerlinClockLamp> lamps, Func<int, int> lampsToSwitchOn)
        {
            if (lamps == null) throw new ArgumentNullException(nameof(lamps));

            return  new BerlinClockPart(lamps, lampsToSwitchOn);
        }
    }
}