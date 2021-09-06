Imports System.Windows
Imports System.Collections
' ...

Namespace LastRow

	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()

			Dim list As New ArrayList()
			list.Add(New TestData("1", "1"))
			list.Add(New TestData("2", "2"))
			list.Add(New TestData("3", "3"))
			list.Add(New TestData("4", "4"))
			list.Add(New TestData("5", "5"))
			list.Add(New TestData("6", "6"))
			list.Add(New TestData("7", "7"))
			list.Add(New TestData("8", "8"))
			list.Add(New TestData("9", "9"))
			list.Add(New TestData("10", "10"))
			list.Add(New TestData("11", "11"))
			grid.ItemsSource = list
		End Sub

		Private Sub btn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If view.FocusedRowData Is Nothing Then
				textbox.Text = "No Rows Selected"
			Else
				If grid.GetRowVisibleIndexByHandle(view.FocusedRowData.RowHandle.Value) = 0 Then
				textbox.Text = "First Row!"
			Else
				If grid.GetRowVisibleIndexByHandle(view.FocusedRowData.RowHandle.Value) = grid.VisibleRowCount - 1 Then
				textbox.Text = "Last Row!"
			Else
				textbox.Text = "Row Index: " & grid.GetRowVisibleIndexByHandle(view.FocusedRowData.RowHandle.Value).ToString()
			End If
			End If
			End If
		End Sub
	End Class

	Public Class TestData
		Public Property column1() As String
		Public Property column2() As String

		Public Sub New(ByVal str1 As String, ByVal str2 As String)
			column1 = str1
			column2 = str2
		End Sub
	End Class
End Namespace
