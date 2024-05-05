using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Document.State
{
    public interface IDocumentState
    {
        public void Render();
    }
}
