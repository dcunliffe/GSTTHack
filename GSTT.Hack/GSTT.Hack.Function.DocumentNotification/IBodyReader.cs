using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GSTT.Hack.Function.DocumentNotification
{
    interface IBodyReader<T>
    {
        T ReadBody(HttpContent content);
    }
}
