using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandria.Logic.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler next;

        public IHandler SetNext(IHandler handler)
        {
            this.next = handler;

            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this.next != null)
            {
                return this.next.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
