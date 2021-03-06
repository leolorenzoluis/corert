// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
** Class: COMException
**
**
** Purpose: Exception class for all errors from COM Interop where we don't
** recognize the HResult.
**
**
=============================================================================*/

using System;

namespace System.Runtime.InteropServices
{
    // Exception for COM Interop errors where we don't recognize the HResult.
    //
    public class COMException : System.Exception
    {
        internal COMException(int hr)
        {
            HResult = hr;
        }

        public COMException()
        {
        }

        public COMException(string message) :
            base(message)
        {
        }

        public COMException(string message, Exception inner) :
            base(message, inner)
        {
        }

        public COMException(string message, int errorCode) :
            base(message)
        {
            HResult = errorCode;
        }
    }
}
