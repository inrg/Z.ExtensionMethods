// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_TKey_TValue_ContainsAllKey
    {
        [TestMethod]
        public void ContainsAllKey()
        {
            // Type
            var @this = new Dictionary<string, string> {{"Fizz", "Buzz"}, {"Fizz2", "Buzz2"}};

            // Exemples
            bool value1 = @this.ContainsAllKey("Fizz", "Fizz2"); // return true;
            bool value2 = @this.ContainsAllKey("Fizz", "Fizz3"); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}