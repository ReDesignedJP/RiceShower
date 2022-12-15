using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Enum;

namespace Shared.Response
{
    public class GeneralResponseModel
    {
        public GeneralResponseModel() { }

        public GeneralResponseModel(string message)
        {
            Data = new { Message = message };
        }

        public GeneralResponseModel(bool success, object? data, string? code)
        {
            Success = success;
            Data = data;
            Code = code;
        }

        public GeneralResponseModel(object data)
        {
            Data = data;
        }

        public bool Success { get; set; } = true;
        public object? Data { get; set; }
        public string? Code { get; set; } = ResponseCode.OK;
    }
}
