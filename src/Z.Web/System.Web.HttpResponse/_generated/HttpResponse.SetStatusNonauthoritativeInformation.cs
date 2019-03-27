// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
#if !NETSTANDARD
using System.Web;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 203 (Nonauthoritative information.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusNonauthoritativeInformation(this HttpResponse @this)
    {
        @this.StatusCode = 203;
        @this.StatusDescription = "Nonauthoritative information.";
    }
#endif
}