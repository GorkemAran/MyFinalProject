using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //get; readOnly idir ve ctor'da set edilebilir.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        //public bool Success => throw new NotImplementedException(); //sadece get oldugu icin lambda var
        public bool Success { get; }
        public string Message { get; }
    }
}
