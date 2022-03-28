using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Response
{
    public class MessageResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }

        public MessageResponse(string Message)
        {
            this.Message = Message;
        }
    }
}
