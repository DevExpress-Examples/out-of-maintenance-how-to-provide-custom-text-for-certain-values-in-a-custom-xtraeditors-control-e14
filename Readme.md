<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622033/20.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1491)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomDisplayText/Form1.cs) (VB: [Form1.vb](./VB/CustomDisplayText/Form1.vb))
* [MyTextEdit.cs](./CS/CustomDisplayText/MyTextEdit.cs) (VB: [MyTextEdit.vb](./VB/CustomDisplayText/MyTextEdit.vb))
* [Program.cs](./CS/CustomDisplayText/Program.cs) (VB: [Program.vb](./VB/CustomDisplayText/Program.vb))
<!-- default file list end -->
# How to provide custom text for certain values in a custom XtraEditors control


<p>This is an example of a custom TextEdit descendant. It overrides the virtual DoFormatEditValue method to display custom text instead of the actual value stored in the EditValue. The DoParseEditValue method can be overridden to convert user text back to the editor's EditValue.</p>
<p>Please review the following blog post to learn more about API changes we made in version 20.1:<br />
<a href="https://community.devexpress.com/blogs/winforms/archive/2020/04/09/winforms-upcoming-v20-1-api-changes.aspx">WinForms - Upcoming v20.1 API Changes</a></p>

<p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/A1237">How to register a custom editor for use in the XtraGrid</a></p>

<br/>


