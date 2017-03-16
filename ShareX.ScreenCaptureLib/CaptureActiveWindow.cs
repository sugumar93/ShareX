using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ScreenCaptureLib
{
    public class CaptureActiveWindow : iScreenShot
    {
        iCaptureType captureType = new TypeActiveWindow();

        public CaptureActiveWindow()
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
