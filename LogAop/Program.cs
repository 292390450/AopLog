using AopLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAop
{
    class Program
    {
        static void Main(string[] args)
        {
            My my=LogGenerate.Reslove<My>(new My());
            my.Add();
            my.Se();
            Console.Read();
        }
    }
    public class My : LogObject
    {
        [MyLog("执行加法",State.Debug)]
        public void Add()
        {

        }
        [MyLog("se方法",State.Run)]
        public void Se()
        {

        }
    }
}
