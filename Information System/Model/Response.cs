using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System.Model
{
    public class Response<T>
    {
        public int code { get; set; }
        public T data { get; set; }
        public string message { get; set; }
    }
}
