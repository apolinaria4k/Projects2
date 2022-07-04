using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Agamalyan
{
    class AgamalyanLog: LogAbstract, LogInterface
    {
        private List<string> store = new List<string>();
        private static AgamalyanLog instance;

        private AgamalyanLog()
        { }

        public static AgamalyanLog getInstance()
        {
            if (instance == null)
                instance = new AgamalyanLog();
            return instance;
        }
        public LogInterface log(string str)
        {
            store.Add(str);
            return this;
        }
        public LogInterface write()
        {
            writeConsole(store.ToArray());
            return this;
        }
    }
}
