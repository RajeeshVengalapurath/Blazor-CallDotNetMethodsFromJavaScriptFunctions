using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_CallDotNetMethodsFromJavaScriptFunctions.Data
{
    public class Person
    {
        public string Name { get; set; }
        public Person()
        {
            Name = "Rajeesh";
        }
        [JSInvokable]
        public string GetName()
        {
            return Name;
        }
    }
}
