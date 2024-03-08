using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarThunderMinimapRangefinder
{
    public class OverlaySettings
    {
        public Point OverlayLocation { get; set; }
        public int OverlayLocationStep { get; set; }
        public FontInfo OverlayFontInfo { get; set; }
        public int PbVectorSizeStep { get; set; }
        public int PbMinimapVectorWidth { get; set; }
        public int PbMinimapVectorHeight { get; set; }

    }
    public class FontInfo
    {
        public string FontName { get; set; }
        public float Size { get; set; }
        public FontStyle Style { get; set; }
    }
}
