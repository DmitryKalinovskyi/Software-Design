using Memento.Editor.Memento.Attributes;
using System.Reflection;

namespace Memento.Editor
{
    public partial class TextEditor
    {
        public IEditorSnapshot GetSnapshot()
        {
            var snapshot = new EditorSnapshot();

            snapshot.TextDocument = (TextDocument)_textDocument.Clone();

            return snapshot;

        }

        public void Restore(IEditorSnapshot snapshot)
        {
            if (snapshot is EditorSnapshot fullSnapshot)
            {
                _textDocument = fullSnapshot.TextDocument ?? _textDocument;
            }
            else
                throw new ArgumentException("Can't restore from that snapshot.");
        }

        // this was attemp to do this with reflection

        //public EditorSnapshot GetSnapshot()
        //{
        //    var snapshot = new EditorSnapshot();

        //    var properties = GetType().GetProperties(
        //        BindingFlags.NonPublic
        //        | BindingFlags.Public
        //        | BindingFlags.Instance);
        //    var fields = GetType()
        //        .GetFields(BindingFlags.NonPublic
        //        | BindingFlags.Public
        //        | BindingFlags.Instance);

        //    foreach (var field in fields)
        //    {
        //        if (Attribute.IsDefined(field, typeof(MementoFieldAttribute)))
        //        {

        //            // bind field

        //            Console.WriteLine(field.Name);
        //        }
        //    }

        //    foreach (var prop in properties)
        //    {
        //        if (Attribute.IsDefined(prop, typeof(MementoFieldAttribute)))
        //        {

        //            // bind prop

        //            Console.WriteLine(prop.Name);
        //        }
        //    }

        //    snapshot.TextDocument = (TextDocument)_textDocument.Clone();

        //    return snapshot;

        //}
    }
}
