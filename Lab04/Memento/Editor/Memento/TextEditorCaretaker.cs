using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Editor
{
    public class TextEditorCaretaker
    {
        //private List<TextEditor.EditorSnapshot> _history;

        //private TextEditor _originator;

        //public TextEditorCaretaker(TextEditor originator)
        //{
        //    _originator = originator;
        //    _history = new();
        //}

        //public void Save()
        //{
        //    _history.Add(_originator.GetSnapshot());
        //}

        //public void Undo()
        //{
        //    if (_history.Count == 0)
        //    {
        //        throw new InvalidOperationException("Can't undo text document.");
        //    }

        //    var memento = _history.Last();
        //    _history.RemoveAt(_history.Count - 1);

        //    _originator.Restore(memento);
        //}

        //internal string GetHistoryInfo()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine($"History size: {_history.Count}");

        //    foreach (var memento in _history)
        //    {
        //        sb.AppendLine(memento.ToString());
        //    }

        //    return sb.ToString();
        //}
    }
}
