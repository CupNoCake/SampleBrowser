using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBrowser.ComponentModel
{
    public class WebPageTitleChangeEventArgs : EventArgs
    {
        private string _title;
        public string Title { get { return _title; } }

        public WebPageTitleChangeEventArgs(string title) : base()
        {
            _title = title;
        }
    }
}
