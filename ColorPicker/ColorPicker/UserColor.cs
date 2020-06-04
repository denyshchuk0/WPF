using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColorPicker
{
    public class UserColor
    {
        public string ColorName { get; set; }
        public Brush ColorRGB { get; set; }
        public int index { get; set; } = 0;
    }
}
