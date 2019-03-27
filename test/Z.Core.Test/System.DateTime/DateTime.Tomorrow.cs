// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_Tomorrow
    {
        [TestMethod]
        public void Tomorrow()
        {
            // Type
            DateTime @this = DateTime.Now;

            // Exemples
            DateTime result = @this.Tomorrow(); // Return date as tomorrow

            // Unit Test
            Assert.AreEqual(@this.AddDays(1).Day, result.Day);
        }
    }
}