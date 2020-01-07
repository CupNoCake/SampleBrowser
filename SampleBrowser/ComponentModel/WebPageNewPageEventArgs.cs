using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBrowser.ComponentModel
{
    public class WebPageNewPageEventArgs : CancelEventArgs
    {
        public object ActiveXInstance { get; set; }

        public WebPageNewPageEventArgs(object activeXInstance)
        {
            ActiveXInstance = activeXInstance;
        }
    }
}
