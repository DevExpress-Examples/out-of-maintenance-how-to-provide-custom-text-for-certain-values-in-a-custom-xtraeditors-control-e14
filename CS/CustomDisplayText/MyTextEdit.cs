using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Registrator;

namespace DevExpress.CustomEditors {
    [UserRepositoryItem("RegisterMyTextEdit")]
    public class RepositoryItemMyTextEdit : RepositoryItemTextEdit {
        static RepositoryItemMyTextEdit() {
            RegisterMyTextEdit();
        }
        public RepositoryItemMyTextEdit() { }

        public static void RegisterMyTextEdit() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("MyTextEdit", typeof(MyTextEdit), 
                typeof(RepositoryItemMyTextEdit), typeof(DevExpress.XtraEditors.ViewInfo.TextEditViewInfo), 
                new DevExpress.XtraEditors.Drawing.TextEditPainter(), true, EditImageIndexes.TextEdit, typeof(DevExpress.Accessibility.TextEditAccessible)));
        }
        public override string EditorTypeName {
            get { return "MyTextEdit"; }
        }

        public override string GetDisplayText(FormatInfo format, object editValue) {
            return base.GetDisplayText(format, editValue);
        }  
        protected override void RaiseFormatEditValue(ConvertEditValueEventArgs e) {
            base.RaiseFormatEditValue(e);
            if(e.Value is int) {
                e.Handled = true;
                switch((int)e.Value) {
                    case 0: e.Value = "zero";
                        break;
                    case 1: e.Value = "one";
                        break;
                    case 2: e.Value = "two";
                        break;
                    case 3: e.Value = "three";
                        break;                            
                }
            }            
        }
        protected override void RaiseParseEditValue(ConvertEditValueEventArgs e) {
            base.RaiseParseEditValue(e);
            if(e.Value is string) {
                e.Handled = true;
                switch((string)e.Value) {
                    case "zero": e.Value = 0;
                        break;
                    case "one": e.Value = 1;
                        break;
                    case "two": e.Value = 2;
                        break;
                    case "three": e.Value = 3;
                        break;
                }
            }
        }
    }

    public class MyTextEdit : DevExpress.XtraEditors.TextEdit {
        static MyTextEdit() {
            RepositoryItemMyTextEdit.RegisterMyTextEdit();
        }
        public MyTextEdit() { }

        public override string EditorTypeName { get { return "MyTextEdit"; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyTextEdit Properties {
            get { return base.Properties as RepositoryItemMyTextEdit; }
        }
    }
}

