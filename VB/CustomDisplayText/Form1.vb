Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace CustomDisplayText
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			For i As Integer = 0 To 9
				dataTable1.Rows.Add(New Object() { i })
			Next i
			textEdit2.EditValue = 3
		End Sub
	End Class
End Namespace