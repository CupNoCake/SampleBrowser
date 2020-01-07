using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleBrowser.ComponentModel;

namespace SampleBrowser
{
    public partial class WebPage : UserControl
    {
/*        private bool isAppExit;
        private bool isRun;*/
        public event EventHandler<WebPageStatusTextChangeEventArgs> StatusTextChange;
        public event EventHandler<WebPageTitleChangeEventArgs> TitleChange;
        public event EventHandler<WebPageNewPageEventArgs> NewPage;
        public WebPage()
        {
            InitializeComponent();

            /*isAppExit = false;
            isRun = false;*/
        }

        #region method

        private void UpdateAddressText()
        {
            if (exWebBrowser1.Url != null)
                tb_address.Text = exWebBrowser1.Url.ToString();
        }

/*        private void WaitWebResult()
        {
            // 等待网页加载完成

            do
            {
                Application.DoEvents();
            }
            while (!isAppExit && isRun && exWebBrowser1.ReadyState != WebBrowserReadyState.Complete);

            isRun = false;
            btn_refresh.BackgroundImage = global::SampleBrowser.Properties.Resources.Refresh;
        }*/

        public void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "https://" + address;
            }
            try
            {
/*                if (isRun)
                {
                    exWebBrowser1.Stop();
                    isRun = false;
                }*/

                exWebBrowser1.Navigate(address);
            }
            catch (UriFormatException)
            {
                
            }
        }

        public void FocusAddressInput()
        {
            BeginInvoke((Action)delegate
            {
                tb_address.Focus();
            });

        }

        public object GetActiveXInstance()
        {
            return exWebBrowser1.ActiveXInstance;
        }

/*        public void Close()
        {
            isAppExit = true;
        }*/

        #endregion

        private void exWebBrowser1_BeforeNavigate2(object sender, ExControls.ComponentModel.ExWebBrowserBeforeNavigate2EventArgs e)
        {
            string address = e.URL.ToString();
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;

            btn_refresh.BackgroundImage = Properties.Resources.Stop;
            btn_refresh.Tag = true;
            /*if (!isRun)
            {
                isRun = true;
                btn_refresh.BackgroundImage = Properties.Resources.Stop;

                BeginInvoke((Action)delegate
                {
                    WaitWebResult();
                });
            }*/
        }

        private void exWebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            UpdateAddressText();
            btn_refresh.BackgroundImage = Properties.Resources.Refresh;
            btn_refresh.Tag = false;
        }

        private void exWebBrowser1_NewWindow3(object sender, ExControls.ComponentModel.ExWebBrowserNewWindow3EventArgs e)
        {
            if (e == null)
                throw new ArgumentNullException("e");

            WebPageNewPageEventArgs args = new WebPageNewPageEventArgs(e.ActiveXInstance);
            NewPage?.Invoke(this, args);
            e.ActiveXInstance = args.ActiveXInstance;
            e.Cancel = args.Cancel;
        }

        private void exWebBrowser1_Quit(object sender, EventArgs e)
        {
            /*isAppExit = true;*/
        }

        private void exWebBrowser1_StatusTextChange(object sender, ExControls.ComponentModel.ExWebBrowserStatusTextChangeEventArgs e)
        {
            if (e == null)
                throw new ArgumentNullException("e");

            StatusTextChange?.Invoke(this, new WebPageStatusTextChangeEventArgs(e.Text));
        }

        private void exWebBrowser1_TitleChange(object sender, ExControls.ComponentModel.ExWebBrowserTitleChangeEventArgs e)
        {
            if (e == null)
                throw new ArgumentNullException("e");

            TitleChange?.Invoke(this, new WebPageTitleChangeEventArgs(e.Title));
        }

       

        private void tb_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(tb_address.Text);
            }
        }

        private void tb_address_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                (sender as TextBox).SelectAll();
            });
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            exWebBrowser1.GoForward();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            exWebBrowser1.GoBack();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            /*if (isRun)
            {
                exWebBrowser1.Stop();
                isRun = false;
            }
            else
            {
                if (exWebBrowser1.Url != null)
                    Navigate(exWebBrowser1.Url.ToString());
            }*/
            if ((bool)btn_refresh.Tag)
            {
                exWebBrowser1.Stop();
                btn_refresh.BackgroundImage = Properties.Resources.Refresh;
                btn_refresh.Tag = false;
            }    
            else
            {
                exWebBrowser1.Refresh();
                //btn_refresh.BackgroundImage = Properties.Resources.Stop;
                //btn_refresh.Tag = true;
            } 
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            exWebBrowser1.GoHome();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            Navigate(tb_address.Text);
        }
    }
}
