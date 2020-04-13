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
	<UserRepositoryItem("RegisterMyTextEdit")>
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

		Public Overrides Function GetDisplayText(ByVal format As FormatInfo, ByVal editValue As Object) As String
			Return MyBase.GetDisplayText(format, editValue)
		End Function
		Protected Overrides Sub RaiseFormatEditValue(ByVal e As ConvertEditValueEventArgs)
			MyBase.RaiseFormatEditValue(e)
			If TypeOf e.Value Is Integer Then
				e.Handled = True
				Select Case CInt(Math.Truncate(e.Value))
					Case 0
						e.Value = "zero"
					Case 1
						e.Value = "one"
					Case 2
						e.Value = "two"
					Case 3
						e.Value = "three"
				End Select
			End If
		End Sub
		Protected Overrides Sub RaiseParseEditValue(ByVal e As ConvertEditValueEventArgs)
			MyBase.RaiseParseEditValue(e)
			If TypeOf e.Value Is String Then
				e.Handled = True
				Select Case CStr(e.Value)
					Case "zero"
						e.Value = 0
					Case "one"
						e.Value = 1
					Case "two"
						e.Value = 2
					Case "three"
						e.Value = 3
				End Select
			End If
		End Sub
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

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyTextEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyTextEdit)
			End Get
		End Property
	End Class
End Namespace

