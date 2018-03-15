# AopLog
A library that uses Aop to record Log
使用它很简单，源代码中有项目LogAop示例使用。
使用时它时，你要将需要进行日志记录的类继承至LogObject，然后实现一个自己的特性继承至BaseAttribute
 
 
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


    不需要使用new关键字生成类，需要使用LogGenerate生成你需要的类
   
	 My my=LogGenerate.Reslove<My>(new My());
            my.Add();
            my.Se();
						
    调用方法将会在调用前执行记录。
		
		
    整个项目简单的实现的Aop，需要更复杂的功能可以对源码进行修改，有其他的建议或问题请联系到我邮箱292390450@qq.com
