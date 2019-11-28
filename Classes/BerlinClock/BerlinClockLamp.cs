using System;

namespace BerlinClock.Classes.BerlinClock
{
    public class BerlinClockLamp
    {
        private readonly Color _color;
        private State _state = State.Off;

        private BerlinClockLamp(Color color)
        {
            _color = color;
        }

        public void SwitchOn()
        {
            _state = State.On;
        }

        public override string ToString()
        {
            return _state == State.On ? _color.Value : "O";
        }

        public static BerlinClockLamp Create(Color color)
        {
            if (color == null) throw new ArgumentNullException(nameof(color));

            return new BerlinClockLamp(color);
        }
    }
}