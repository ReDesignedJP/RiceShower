using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Enum
{
    public class ResponseCode
    {
        public const string OK = "OK";
        public const string EXCEPTION = "EXCEPTION";
        public const string NOT_FOUND = "NOT_FOUND";
        public const string EXIST = "EXIST";
        public const string INCORRECT_PW = "INCORRECT_PW";
        public const string UNAUTHORIZED = "UNAUTHORIZED";
        public const string FORBIDDEN = "FORBIDDEN";
        public const string BAD_REQUEST = "BAD_REQUEST";
    }
}
