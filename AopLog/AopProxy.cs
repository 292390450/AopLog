using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace AopLog
{
    /// <summary>
    /// Aop代理，调用
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AopProxy<T> : RealProxy
    {
        //被代理对象
        private T _realObject;
        public AopProxy(T realobject) : base(typeof(T))
        {
            _realObject = realobject;
        }
        public override IMessage Invoke(IMessage msg)
        {

            IMethodCallMessage callMsg = msg as IMethodCallMessage;
            //类型完整名
            string typeStr = callMsg.TypeName;
            var attribute = callMsg.MethodBase.GetCustomAttribute<BaseAttribute>();
            if (attribute != null)
            {
                if (attribute.State == State.Debug)
                {
                    //调用方法前的方法
                    attribute.DoDebugLog(typeStr);
                }
                else
                {
                    attribute.DoLog(typeStr);
                }
            }
            try
            {
                //调用真实方法；
                object retValue = callMsg.MethodBase.Invoke(_realObject, callMsg.Args);
                return new ReturnMessage(retValue, callMsg.Args, callMsg.ArgCount - callMsg.InArgCount, callMsg.LogicalCallContext, callMsg);
            }
            catch (Exception ex)
            {
                return new ReturnMessage(ex, callMsg);
            }
            finally
            {
                //调用后处理；
               
            }
        }   
    }
}
