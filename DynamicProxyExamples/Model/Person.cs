using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicProxyExamples.Model
{
    public class Person : IPerson
    {
        public virtual string Name { get; set; }

        public virtual int Age { get; set; }

        public virtual IList<PhoneNumber> PhoneNumbers { get; set; }
    }
}
