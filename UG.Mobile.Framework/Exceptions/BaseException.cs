#region

using System;

#endregion

namespace UG.Mobile.Framework
{
    public enum ErrorCode
    {
        IsSuccess = 0,
        OpenConnection = 99,
        JsonParser = 100,
        WebService = 101,
        Permission = 102,
        Business = 1,
        Unknown = 10000,
    }
    public class Encryption : Exception
    {
        #region Fields
        private DateTime mTime;
        private ErrorCode errorNumber;
        private string errorMsg = "";
        #endregion

        #region Constructors
        public Encryption(ErrorCode errorNumber, string errorMsg)
            : base(errorMsg)
        {
            this.mTime = DateTime.Now;
            this.errorNumber = errorNumber;
            this.errorMsg = errorMsg;
        }
        public Encryption(ErrorCode errorNumber, string errorMsg, Exception innerError)
            : base(errorMsg, innerError)
        {
            this.mTime = DateTime.Now;
            this.errorNumber = errorNumber;
            this.errorMsg = errorMsg + (innerError == null ? string.Empty : ": " + innerError.Message);
        }
        #endregion

        #region Properties
        public ErrorCode ErrorNumber
        {
            get { return errorNumber; }
        }
        public string ErrorMsg
        {
            get { return this.errorMsg;}
        }
       
        public DateTime Time
        {
            get { return this.mTime; }
        }
        #endregion
    }
}
