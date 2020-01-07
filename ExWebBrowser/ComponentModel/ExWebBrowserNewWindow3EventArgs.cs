using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExControls.ComponentModel
{
    public class ExWebBrowserNewWindow3EventArgs : CancelEventArgs
    {
        public object ActiveXInstance { get; set; }
        private string _url;
        public string URL { get { return _url; } }
        private string _urlContext;
        public string UrlContext { get { return _urlContext; } }

        public ExWebBrowserNewWindow3EventArgs(object activeXInstance, string url, string urlContext)
        {
            ActiveXInstance = activeXInstance;
            _url = url;
            _urlContext = urlContext;
        }
    }
}
