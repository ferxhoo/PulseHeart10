using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ColorChangedEventArgs : EventArgs
    {
        public Color NewColor { get; }

        public ColorChangedEventArgs(Color newColor)
        {
            NewColor = newColor;
        }
    }
}
