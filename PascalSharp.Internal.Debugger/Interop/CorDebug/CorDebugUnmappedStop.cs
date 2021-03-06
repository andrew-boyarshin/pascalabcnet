﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2077 $</version>
// </file>

#pragma warning disable 108, 1591 

namespace PascalSharp.Internal.Debugger.Interop.CorDebug
{
    public enum CorDebugUnmappedStop
    {
        // Fields
        STOP_ALL = 0xffff,
        STOP_EPILOG = 2,
        STOP_NO_MAPPING_INFO = 4,
        STOP_NONE = 0,
        STOP_OTHER_UNMAPPED = 8,
        STOP_PROLOG = 1,
        STOP_UNMANAGED = 0x10
    }
}

#pragma warning restore 108, 1591