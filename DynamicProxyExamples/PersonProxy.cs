using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Interceptor;
using Castle.DynamicProxy;

namespace DynamicProxyExamples
{
    public class PersonProxy : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

            if (invocation.ReturnValue == null)
            {
                ProxyGenerator generator = new ProxyGenerator();

                if (invocation.Method.ReturnType.IsInterface)
                    invocation.ReturnValue = generator.CreateInterfaceProxyWithoutTarget(invocation.Method.ReturnType, new PersonProxy());
                else
                    invocation.ReturnValue = generator.CreateClassProxy(invocation.Method.ReturnType, new PersonProxy());

            }
        }

    }
}
