using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOne.Models
{
    public class BaseResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public BaseResult(bool success, string message = "", object data = null)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}
