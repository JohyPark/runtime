// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Microsoft.Win32.SafeHandles
{
    public sealed partial class SafeMemoryMappedViewHandle
    {
        protected override bool ReleaseHandle()
        {
            IntPtr h = handle;
            handle = IntPtr.Zero;
            return Interop.Kernel32.UnmapViewOfFile(h);
        }
    }
}
