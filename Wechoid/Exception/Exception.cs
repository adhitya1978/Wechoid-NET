using System;
using System.Collections.Generic;
using System.Text;

namespace Wechoid.Exception
{
   public class CoreException :System.Exception
    {
         private uint ErrorCode;
    private string ErrorMessage;

    // Methods
    public CoreException()
    {
        this.ErrorCode = 0;
        this.ErrorMessage = "";
    }

    public CoreException(uint errorCode, string errorMessage)
    {
        this.ErrorCode = errorCode;
        this.ErrorMessage = errorMessage;
    }

    public uint getErrorCode()
    {
        return this.ErrorCode;
    }

    public string getErrorMessage()
    {
        return this.ErrorMessage;
    }

    }
}
