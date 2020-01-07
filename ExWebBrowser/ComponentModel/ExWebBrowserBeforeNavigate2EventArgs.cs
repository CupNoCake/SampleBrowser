using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExControls.ComponentModel
{
    public class ExWebBrowserBeforeNavigate2EventArgs : CancelEventArgs
    {
        public object ActiveXInstance { get; set; }
        private string _url;
        public string URL { get { return _url; } }
        private string _targetFrameName;
        public string TargetFrameName { get { return _targetFrameName; } }

        public ExWebBrowserBeforeNavigate2EventArgs(object activeXInstance, string url, string targetFrameName)
        {
            ActiveXInstance = activeXInstance;
            _url = url;
            _targetFrameName = targetFrameName;
        }
    }
}
