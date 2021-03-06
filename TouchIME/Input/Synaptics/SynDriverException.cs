﻿using System;

namespace TouchIME.Input.Synaptics
{
    /// <summary>
    /// Exception thrown if the Synaptics kernel-mode driver
    /// is not installed or is too old to support the Synaptics
    /// COM API.
    /// </summary>
    public sealed class SynDriverException : NotSupportedException
    {
        internal SynDriverException() : base("Synaptics driver not found or outdated")
        {
            
        }
    }
}
