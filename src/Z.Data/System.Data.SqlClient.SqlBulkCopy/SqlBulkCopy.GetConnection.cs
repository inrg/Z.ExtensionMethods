// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System;
using System.Data.SqlClient;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A SqlBulkCopy extension method that gets a connection.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The connection.</returns>
    public static SqlConnection GetConnection(this SqlBulkCopy @this)
    {
        Type type = @this.GetType();
        FieldInfo field = type.GetField("_connection", BindingFlags.NonPublic | BindingFlags.Instance);
// ReSharper disable PossibleNullReferenceException
        return field.GetValue(@this) as SqlConnection;
// ReSharper restore PossibleNullReferenceException
    }
}