
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_220

	''' <summary>
	'''     Returns a specified number raised to the specified power.
	''' </summary>
	''' <param name="x">A double-precision floating-point number to be raised to a power.</param>
	''' <param name="y">A double-precision floating-point number that specifies a power.</param>
	''' <returns>The number  raised to the power .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Pow(x As [Double], y As [Double]) As [Double]
		Return Math.Pow(x, y)
	End Function
End Module


