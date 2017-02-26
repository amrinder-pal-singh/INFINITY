using INFINITY.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace INFINITY.Infrastructure
{
    public class MessageProvider: IMessageProvider
    {
        public string GetMessage()
        {
            return this.ToString();
        }
    }
}
