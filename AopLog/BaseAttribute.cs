using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopLog
{
    /// <summary>
    /// 日志记录特性的基类，抽象类，需要继承并实现日志记录的详细操作
    /// </summary>
    public abstract class BaseAttribute:Attribute
    {
        public State State { get; set; }
        public string LogText { get; set; }
        /// <summary>
        /// 执行日志输入记录，需要重写此方法
        /// </summary>
        public abstract void DoLog(string typeName);
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="logText">记录</param>
        /// <param name="state">运行状态</param>
        public BaseAttribute(string logText, State state)
        {
            LogText = logText;
            State = state;
        }
        public abstract void DoDebugLog(string typeName);
    }
}
