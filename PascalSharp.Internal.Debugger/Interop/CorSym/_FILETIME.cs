﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2077 $</version>
// </file>

using System.Runtime.InteropServices;

#pragma warning disable 108, 1591 

namespace PascalSharp.Internal.Debugger.Interop.CorSym
{
    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct _FILETIME
    {
        public uint dwLowDateTime;
        public uint dwHighDateTime;
    }
}

#pragma warning restore 108, 1591