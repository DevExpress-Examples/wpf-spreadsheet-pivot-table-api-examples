Imports DevExpress.Xpf.Grid
Imports System.Collections

Namespace SpreadsheetWPFPivotTableExamples
	Public Class CodeExampleGroupChildrenSelector
		Implements IChildNodesSelector

		Private Function IChildNodesSelector_SelectChildren(ByVal item As Object) As IEnumerable Implements IChildNodesSelector.SelectChildren
			If TypeOf item Is CodeExampleGroup Then
				Return DirectCast(item, CodeExampleGroup).Examples
			End If
			Return Nothing
		End Function
	End Class
End Namespace
