using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExControls.ComponentModel
{
    public class ExWebBrowserNewWindow2EventArgs : CancelEventArgs
    {
        public object ActiveXInstance { get; set; }

        public ExWebBrowserNewWindow2EventArgs(object activeXInstance)
        {
            ActiveXInstance = activeXInstance;
        }
    }
}
