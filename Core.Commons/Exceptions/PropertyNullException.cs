using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Commons.Exceptions
{
    public class PropertyNullException : BaseException
    {
        public PropertyNullException(string message)
            : base(message)
        {
        }
    }
}
