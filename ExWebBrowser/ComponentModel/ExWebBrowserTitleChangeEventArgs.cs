using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExControls.ComponentModel
{
    public class ExWebBrowserTitleChangeEventArgs : EventArgs
    {
        private string _title;
        public string Title { get { return _title; } }

        public ExWebBrowserTitleChangeEventArgs(string title) : base()
        {
            _title = title;
        }
    }
}
