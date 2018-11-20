using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoDotNet3
{
    public class ExternalClass1
    {
        public static String doSomthing(String foo)
        {
            String didthis = foo + "that did";

            String password = "wood";
            Console.Out.WriteLine(didthis);

            ExternalLib.Class1.ExternalNet20(password);

            return didthis;
        }
    }
}