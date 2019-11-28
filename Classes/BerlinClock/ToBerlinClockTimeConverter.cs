using System;
using System.Text;

namespace BerlinClock.Classes.BerlinClock
{
    public class ToBerlinClockTimeConverter
    {
        private readonly ITimeUnitProvider _hoursProvider;
        private readonly ITimeUnitProvider _minutesProvider;
        private readonly ITimeUnitProvider _secondsProvider;

        private ToBerlinClockTimeConverter()
        {
            _hoursProvider = BerlinClockHours.Create();
            _minutesProvider = BerlinClockMinutes.Create();
            _secondsProvider = BerlinClockSeconds.Create();
        }

        private string FromString(string aTime)
        {
            if (!TimeSpan.TryParse(aTime.Contains("24:00:") ? "1.00:00" : aTime , out var time)) 
                throw new ArgumentException("Couldn't parse time");

            var builder = new StringBuilder()
                .Append(_secondsProvider.Get(time.Seconds))
                .Append(Environment.NewLine)
                .Append(_hoursProvider.Get((int)time.TotalHours))
                .Append(Environment.NewLine)
                .Append(_minutesProvider.Get(time.Minutes));

            return builder.ToString();
        }

        public static string Convert(string aTime)
        {
            return new ToBerlinClockTimeConverter().FromString(aTime);
        }
    }
}