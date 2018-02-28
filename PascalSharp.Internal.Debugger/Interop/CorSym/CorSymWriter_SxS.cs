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
    [ComImport, CoClass(typeof(CorSymWriter_SxSClass)), Guid("ED14AA72-78E2-4884-84E2-334293AE5214")]
    public interface CorSymWriter_SxS : ISymUnmanagedWriter
    {
    }
}

#pragma warning restore 108, 1591