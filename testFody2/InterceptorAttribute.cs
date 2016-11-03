using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace testFody2
{
    public class InterceptorAttribute : Attribute, IMethodDecorator
    {
        // instance, method and args can be captured here and stored in attribute instance fields
        // for future usage in OnEntry/OnExit/OnException
        public void Init(object instance, MethodBase method, object[] args)
        {
            //TestMessages.Record(string.Format("Init: {0} [{1}]", method.DeclaringType.FullName + "." + method.Name, args.Length));
            Console.WriteLine(string.Format("Init: {0} [{1}]", method.DeclaringType.FullName + "." + method.Name, args.Length));
        }
        public void OnEntry()
        {
            //TestMessages.Record("OnEntry");
            Console.WriteLine("OnEntry");
        }

        public void OnExit()
        {
            //TestMessages.Record("OnExit");
            Console.WriteLine("OnExit");
        }

        public void OnException(Exception exception)
        {
            //TestMessages.Record(string.Format("OnException: {0}: {1}", exception.GetType(), exception.Message));
            Console.WriteLine(string.Format("OnException: {0}: {1}", exception.GetType(), exception.Message));
        }

    }
}
