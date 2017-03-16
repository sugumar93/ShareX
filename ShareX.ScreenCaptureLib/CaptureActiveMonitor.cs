using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ScreenCaptureLib
{
    public class CaptureActiveMonitor : iScreenShot
    {
        iCaptureType captureType = new TypeActiveMonitor();

        public CaptureActiveMonitor()
        {
        }

        public bool CaptureCursor { get; set; }
        public bool CaptureShadow { get; set; }
        public int ShadowOffset { get; set; }

        public override Image Screenshot()
        {
            return captureType.Capture(new Rectangle(0, 0, 0, 0), new IntPtr(0), false);
        }
    }
}
