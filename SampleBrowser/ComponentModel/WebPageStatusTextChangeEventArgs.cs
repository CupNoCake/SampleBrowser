using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBrowser.ComponentModel
{
    public class WebPageStatusTextChangeEventArgs : EventArgs
    {
        private string _text;

        public string Text
        {
            get { return _text; }
        }

        public WebPageStatusTextChangeEventArgs(string text)
          : base()
        {
            _text = text;
        }
    }
}
