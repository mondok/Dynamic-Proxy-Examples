using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;
using DynamicProxyExamples.Model;

namespace DynamicProxyExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProxyGenerator generator = new ProxyGenerator();

            IPerson  person = new Person { Age = 21 };

            person = generator.CreateInterfaceProxyWithTarget(person, new PersonProxy());

            var phoneNumbers = person.PhoneNumbers;

            bool notNull = phoneNumbers != null;
        }
    }
}
