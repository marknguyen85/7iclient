#region

using System;

#endregion

namespace UG.Mobile.Framework
{
    public class BusinessException : Encryption
    {
        public BusinessException(ErrorCode code, string message)
            : base(code, message)
        {
        }
    }
}
