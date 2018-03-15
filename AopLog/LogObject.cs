using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopLog
{
    /// <summary>
    /// 作为需要日志记录类的基类被继承
    /// </summary>
    public class LogObject : MarshalByRefObject
    {
        public LogObject()
        {

        }
    }
}
