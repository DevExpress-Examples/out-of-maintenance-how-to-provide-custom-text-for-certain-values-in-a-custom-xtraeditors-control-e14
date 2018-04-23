Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Registrator

Namespace DevExpress.CustomEditors
	<UserRepositoryItem("RegisterMyTextEdit")> _
	Public Class RepositoryItemMyTextEdit
		Inherits RepositoryItemTextEdit
		Shared Sub New()
			RegisterMyTextEdit()
		End Sub
		Public Sub New()
		End Sub

		Public Shared Sub RegisterMyTextEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("MyTextEdit", GetType(MyTextEdit), GetType(RepositoryItemMyTextEdit), GetType(DevExpress.XtraEditors.ViewInfo.TextEditViewInfo), New DevExpress.XtraEditors.Drawing.TextEditPainter(), True, EditImageIndexes.TextEdit, GetType(DevExpress.Accessibility.TextEditAccessible)))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return "MyTextEdit"
			End Get
		End Property

		Public Overrides Overloads Function GetDisplayText(ByVal format As FormatInfo, ByVal editValue As Object) As String
			Return MyBase.GetDisplayText(format, editValue)
		End Function

		Protected Overrides Function DoFormatEditValue(ByVal val As Object) As ConvertEditValueEventArgs
			If TypeOf val Is Integer Then
				Select Case CInt(Fix(val))
					Case 0
						Return New ConvertEditValueEventArgs("zero")
					Case 1
						Return New ConvertEditValueEventArgs("one")
					Case 2
						Return New ConvertEditValueEventArgs("two")
					Case 3
						Return New ConvertEditValueEventArgs("three")
				End Select

			End If
			Return MyBase.DoFormatEditValue(val)
		End Function

		Protected Overrides Function DoParseEditValue(ByVal val As Object) As ConvertEditValueEventArgs
			If TypeOf val Is String Then
				Select Case CStr(val)
					Case "zero"
						Return New ConvertEditValueEventArgs(0)
					Case "one"
						Return New ConvertEditValueEventArgs(1)
					Case "two"
						Return New ConvertEditValueEventArgs(2)
					Case "three"
						Return New ConvertEditValueEventArgs(3)
				End Select
			End If
			Return MyBase.DoParseEditValue(val)
		End Function
	End Class

	Public Class MyTextEdit
		Inherits DevExpress.XtraEditors.TextEdit
		Shared Sub New()
			RepositoryItemMyTextEdit.RegisterMyTextEdit()
		End Sub
		Public Sub New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return "MyTextEdit"
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyTextEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyTextEdit)
			End Get
		End Property
	End Class
End Namespace

