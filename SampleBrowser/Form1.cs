using Microsoft.VisualStudio.OLE.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleBrowser
{
    public partial class Form1 : Form, IOleClientSite
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region The Implementation of IOleClientSite
        public void SaveObject()
        {

        }

        public void GetMoniker(uint dwAssign, uint dwWhichMoniker, out IMoniker ppmk)
        {
            ppmk = (IMoniker)this;
        }

        public void GetContainer(out IOleContainer ppContainer)
        {
            ppContainer = (IOleContainer)this;
        }

        public void ShowObject()
        {

        }

        public void OnShowWindow(int fShow)
        {

        }

        public void RequestNewObjectLayout()
        {

        }

        #endregion


        private object CreateNewWebPage(string url)
        {
            TabPage tabPage = new TabPage("新标签页");
            tabPage.Name = "tabPage" + (tabControl1.TabPages.Count + 1);

            WebPage webPage = new WebPage();

            webPage.Dock = DockStyle.Fill;
            webPage.Tag = tabPage;
            webPage.NewPage += WebPage_NewPage;
            webPage.StatusTextChange += WebPage_StatusTextChange;
            webPage.TitleChange += WebPage_TitleChange;
            IOleObject obj = (IOleObject)webPage.GetActiveXInstance();
            obj.SetClientSite(this);

            tabPage.Controls.Add(webPage);
            tabControl1.TabPages.Add(tabPage);
            tabControl1.SelectedTab = tabPage;

            if (url != null && url.Length > 0)
            {
                webPage.Navigate(url);
            }
            else
            {
                webPage.FocusAddressInput();
            }

            return webPage.GetActiveXInstance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateNewWebPage(null);
        }

        private void WebPage_TitleChange(object sender, ComponentModel.WebPageTitleChangeEventArgs e)
        {
            TabPage tabPage = (sender as WebPage).Tag as TabPage;
            tabPage.Text = e.Title;
            tabControl1.Refresh();
        }

        private void WebPage_StatusTextChange(object sender, ComponentModel.WebPageStatusTextChangeEventArgs e)
        {
            statusTextLabel.Text = e.Text;
        }

        private void WebPage_NewPage(object sender, ComponentModel.WebPageNewPageEventArgs e)
        {
            e.ActiveXInstance = CreateNewWebPage(null);
        }

        
        private void tsmi_tabPage_close_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab != null)
            {
                TabPage tabPage = tabControl1.SelectedTab;
                tabPage.Controls.Clear();
                tabControl1.TabPages.Remove(tabPage);

                if(tabControl1.TabPages.Count == 0)
                {
                    Close();
                }
            }
        }

        private void tsmi_new_page_Click(object sender, EventArgs e)
        {
            CreateNewWebPage(null);
        }
    }
}
