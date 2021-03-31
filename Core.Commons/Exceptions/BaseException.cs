using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Commons.Exceptions
{
    public class BaseException : Exception
    {

        /// <summary>
        /// 
        /// </summary>
        public BaseException()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public BaseException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public BaseException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
