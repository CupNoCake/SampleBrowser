using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExControls.ComponentModel
{
    public class ExWebBrowserStatusTextChangeEventArgs : EventArgs
    {
        private string _text;

        public string Text
        {
            get { return _text; }
        }

        public ExWebBrowserStatusTextChangeEventArgs(string text)
          : base()
        {
            _text = text;
        }
    }
}
