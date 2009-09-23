using System.Collections.Generic;

namespace DynamicProxyExamples.Model
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        IList<PhoneNumber> PhoneNumbers { get; set; }
    }
}