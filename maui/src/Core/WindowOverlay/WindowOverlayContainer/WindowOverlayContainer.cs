﻿namespace Syncfusion.Maui.Toolkit.Internals
{
    internal class WindowOverlayContainer : View
    {
        internal virtual bool canHandleTouch
        {
            get { return false; }
        }
        internal virtual void ProcessTouchInteraction(float x, float y) { }
    }
}
