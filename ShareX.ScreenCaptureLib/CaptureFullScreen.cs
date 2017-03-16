using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ScreenCaptureLib
{
    public class CaptureFullScreen : iScreenShot  
    {
        iCaptureType captureType = new TypeFullScreen();

        public bool CaptureCursor { get; set; }
        public bool CaptureShadow { get; set; }
        public int ShadowOffset { get; set; }

        public void setCaptureType(iCaptureType c)
        {
            captureType = c;
        }

        public iCaptureType getCaptureType()
        {
            return captureType;
        }

        public CaptureFullScreen()
        {
        }

        public override Image Screenshot()
        {
            return captureType.Capture(new Rectangle(0,0,0,0), new IntPtr(0), false);
        }
    }
}
