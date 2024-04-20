using Memento.Attributes;
using System.Reflection;

namespace Memento.Editor
{
    public partial class TextEditor
    {
        public EditorSnapshot GetSnapshot()
        {
            var snapshot = new EditorSnapshot();

            var properties = GetType().GetProperties(
                BindingFlags.NonPublic
                | BindingFlags.Public
                | BindingFlags.Instance);
            var fields = GetType()
                .GetFields(BindingFlags.NonPublic 
                | BindingFlags.Public 
                | BindingFlags.Instance);

            foreach(var field in fields)
            {
                if (Attribute.IsDefined(field, typeof(MementoFieldAttribute))){

                    // we found field with Memento

                    Console.WriteLine(field.Name);
                }
            }

            foreach(var prop in properties)
            {
                if (Attribute.IsDefined(prop, typeof(MementoFieldAttribute)))
                {

                    // we found property with Memento

                    Console.WriteLine(prop.Name);
                }
            }

            snapshot.TextDocument = (TextDocument)_textDocument.Clone();

            return snapshot;

        }

        public void Restore(EditorSnapshot snapshot)
        {
            _textDocument = snapshot.TextDocument ?? _textDocument;
        }
    }
}
