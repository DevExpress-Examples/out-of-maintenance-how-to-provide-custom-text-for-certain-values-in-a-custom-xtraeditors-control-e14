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

        protected override ConvertEditValueEventArgs DoFormatEditValue(object val) {
            if(val is int) {
                switch((int)val) {
                    case 0: return new ConvertEditValueEventArgs("zero");
                    case 1: return new ConvertEditValueEventArgs("one");
                    case 2: return new ConvertEditValueEventArgs("two");
                    case 3: return new ConvertEditValueEventArgs("three");
                }
                
            }
            return base.DoFormatEditValue(val);
        }

        protected override ConvertEditValueEventArgs DoParseEditValue(object val) {
            if(val is string) {
                switch((string)val) {
                    case "zero": return new ConvertEditValueEventArgs(0);
                    case "one": return new ConvertEditValueEventArgs(1);
                    case "two": return new ConvertEditValueEventArgs(2);
                    case "three": return new ConvertEditValueEventArgs(3);
                }
            }
            return base.DoParseEditValue(val);
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

