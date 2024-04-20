using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Handlers
{
    /// <summary>
    /// Base handler for the chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="TArg"></typeparam>
    public abstract class BaseHandler<TArg>
    {
        private BaseHandler<TArg>? _next;

        /// <summary>
        /// Base method for building the chain
        /// </summary>
        /// <param name="handler"></param>
        /// <returns>handler that passed as argument, to allow fluent-interface chain building.</returns>
        public BaseHandler<TArg> SetNext(BaseHandler<TArg> handler)
        {
            _next = handler;
            return _next;
        }

        public abstract void Handle(TArg argument);
        
        protected void HandleNext(TArg argument)
        {
            _next?.Handle(argument);
        }

    }
}
