using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dao
{
    class ContextFactory
    {
        private static Contexto Context { get; set; }

        public Contexto GetContext()
        {
            if (Context == null)
            {
               // Context = new DataBaseContext();
            }
            return Context;
        }
    }
}
