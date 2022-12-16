Imports System.Windows
Imports System.Collections

' ...
Namespace LastRow

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim list As ArrayList = New ArrayList()
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
            Me.grid.ItemsSource = list
        End Sub

        Private Sub btn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.view.FocusedRowData Is Nothing Then
                Me.textbox.Text = "No Rows Selected"
            ElseIf Me.grid.GetRowVisibleIndexByHandle(Me.view.FocusedRowData.RowHandle.Value) = 0 Then
                Me.textbox.Text = "First Row!"
            ElseIf Me.grid.GetRowVisibleIndexByHandle(Me.view.FocusedRowData.RowHandle.Value) = Me.grid.VisibleRowCount - 1 Then
                Me.textbox.Text = "Last Row!"
            Else
                Me.textbox.Text = "Row Index: " & Me.grid.GetRowVisibleIndexByHandle(CInt(Me.view.FocusedRowData.RowHandle.Value)).ToString()
            End If
        End Sub
    End Class

    Public Class TestData

        Public Property column1 As String

        Public Property column2 As String

        Public Sub New(ByVal str1 As String, ByVal str2 As String)
            column1 = str1
            column2 = str2
        End Sub
    End Class
End Namespace
