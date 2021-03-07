using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //TEMEL VOIDLER İÇİN BAŞLANGIÇ
    //1 TANE İŞLEM SONUCU 1 TANE MESAJ
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
