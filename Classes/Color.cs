namespace BerlinClock.Classes
{
    public class Color
    {
        public string Value { get; }

        private Color(string value)
        {
            Value = value;
        }

        public static Color Yellow()
        {
            return new Color("Y");
        }

        public static Color Red()
        {
            return new Color("R");
        }
    }
}