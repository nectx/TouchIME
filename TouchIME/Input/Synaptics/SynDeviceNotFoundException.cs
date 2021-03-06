﻿using System;

namespace TouchIME.Input.Synaptics
{
    /// <summary>
    /// Exception thrown when an appropriate Synaptics device
    /// could not be found.
    /// </summary>
    public sealed class SynDeviceNotFoundException : NotSupportedException
    {
        internal SynDeviceNotFoundException() : base("Synaptics device not found")
        {
            
        }
    }
}
