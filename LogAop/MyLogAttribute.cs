using AopLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAop
{
    public class MyLogAttribute:BaseAttribute
    {
        public MyLogAttribute(string logText, State state) : base(logText,state)
        {

        }
        /// <summary>
        /// Dubug时记录的日志
        /// </summary>
        /// <param name="typeName">反射出被调用方法的类的全名</param>
        public override void DoDebugLog(string typeName)
        {
            //这里写下你执行记录日志的详细操作，如存到配置文件
            Console.WriteLine("this is debug log:"+typeName+LogText);
        }
        /// <summary>
        /// 运行时记录的日志
        /// </summary>
        /// <param name="typeName">反射出被调用方法的类的全名</param>
        public override void DoLog(string typeName)
        {
            //这里写下你执行记录日志的详细操作，如存到配置文件
            Console.WriteLine("this is runtime log :"+typeName + LogText);
        }
    }
}
