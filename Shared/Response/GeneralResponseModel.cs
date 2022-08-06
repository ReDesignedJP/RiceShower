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
        public bool Success { get; set; } = true;
        public object? Data { get; set; }
        public string? Code { get; set; } = ResponseCode.OK;
    }
}
