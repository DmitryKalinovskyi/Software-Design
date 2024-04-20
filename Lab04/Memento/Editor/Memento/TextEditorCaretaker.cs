using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Editor
{
    public class TextEditorCaretaker(TextEditor originator)
    {
        private readonly List<TextEditor.EditorSnapshot> _history = [];

        public readonly TextEditor Originator = originator;

        public void Save()
        {
            _history.Add(Originator.GetSnapshot());
        }

        public void Undo()
        {
            if (_history.Count == 0)
            {
                throw new InvalidOperationException("Can't undo text document.");
            }

            var memento = _history.Last();
            _history.RemoveAt(_history.Count - 1);

            Originator.Restore(memento);
        }

        public void ClearHistory()
        {
            _history.Clear();
        }

        internal string GetHistoryInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"History size: {_history.Count}");

            foreach (var memento in _history)
            {
                sb.AppendLine(memento.ToString());
            }

            return sb.ToString();
        }
    }
}
