using System.Drawing;

namespace SerialPortTools
{
    public class Threshold
    {
        public Threshold(int Value, Color FontColor, Color BackColor)
        {
            this.Value = Value;
            this.FontColor = FontColor;
            this.BackColor = BackColor;
        }

        public int Value = 0;

        public Color FontColor = Color.Black;

        public Color BackColor = Color.White;

    }
}
