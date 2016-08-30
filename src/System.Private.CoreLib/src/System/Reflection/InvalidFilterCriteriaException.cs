// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System.Reflection
{
    public class InvalidFilterCriteriaException : Exception
    {
        public InvalidFilterCriteriaException()
            : this(SR.Arg_InvalidFilterCriteriaException)
        {
        }

        public InvalidFilterCriteriaException(string message)
            : this(message, null)
        {
        }

        public InvalidFilterCriteriaException(string message, Exception inner)
            : base(message, inner)
        {
            SetErrorCode(__HResults.COR_E_INVALIDFILTERCRITERIA);
        }

        protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}