using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopLog
{
    /// <summary>
    /// 包含获取透明代理对象的静态方法
    /// </summary>
    public class LogGenerate
    {
        /// <summary>
        /// 获取对象的代理对象
        /// </summary>
        /// <typeparam name="T">该对象类型</typeparam>
        /// <param name="obj">该对象</param>
        /// <returns></returns>
        public static T Reslove<T>(T obj)
        {
            AopProxy<T> proxy = new AopProxy<T>(obj);
            return (T)proxy.GetTransparentProxy();
        }
    }
}
