#region

using System;
using System.Diagnostics;
using System.Windows.Forms;
using AddinExpress.OL;
using chnls.Forms;
using chnls.Properties;
using chnls.Service;
using chnls.Services;
using chnls.Utils;
using WebBrowserCom = SHDocVw.WebBrowser;

#endregion

namespace chnls.ADXForms
{
    // ReSharper disable once InconsistentNaming
    public partial class ADXOlFormExplorerSidebar : ADXOlForm
    {
        public ADXOlFormExplorerSidebar()
        {
            PropertiesService.Instance.Connected = false;
            InitializeComponent();

            webBrowserMain.Url = new Uri("about:blank");
            var wbCoMmain = (WebBrowserCom) webBrowserMain.ActiveXInstance;
            wbCoMmain.NewWindow3 += wbCOMmain_NewWindow3;

            Text = "@Channels";
            Icon = Resources.favIcon;

            debugBar.Browser = this;
            debugBar.Visible = PropertiesService.Instance.DebugPanelVisible;
            PropertiesService.Instance.DebugVisibleChanged +=
                (sender, e) => { debugBar.Visible = PropertiesService.Instance.DebugPanelVisible; };
            UpdateService.Instance.UpdateAvailable += (s, e) => { upgradePanel.Visible = true; };
            upgradePanel.Visible = UpdateService.Instance.IsUpdateAvailable;
        }

        private void ADXOlFormExplorerSidebar_Load(object sender, EventArgs e)
        {
            InitializeConnection();
            InitializeChnlsNavigation();
        }


        private void wbCOMmain_NewWindow3(ref object ppDisp, ref bool Cancel, uint dwFlags, string bstrUrlContext,
            string bstrUrl)
        {
            var Url = new Uri(bstrUrl);
            if (bstrUrl == "about:blank" || IsNotCurrentLoadIteration())
            {
                Cancel = true;
                return;
            }
            var description = "Navigating new window: " + Url;
            LoggingService.Debug(description);
            if (IsOauth(Url))
            {
                var pwf = new WebPopupWindowForm(webBrowserMain, url => GoogleOAuthReturn(url.Fragment))
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                ppDisp = pwf.WebBrowserAx;

                Scheduler.Run(description, () =>
                {
                    if (IsNotCurrentLoadIteration())
                    {
                        // this isn't the current load itertion, ignore
                        return;
                    }
                    pwf.ShowDialog();
                }, 1);
            }
            else
            {
                Cancel = true;
                Scheduler.Run(description, () =>
                {
                    if (IsNotCurrentLoadIteration())
                    {
                        // this isn't the current load itertion, ignore
                        return;
                    }
                    if (IsHivePointUrl(Url))
                    {
                        HandleHivePointUrl(Url);
                    }
                    else
                    {
                        AuthorizeUrl(Url);
                    }
                }, 10);
            }
        }

        private void webBrowserMain_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            var description = "Navigating: " + e.Url;
            if (null != webBrowserMain.Document)
            {
                description += " [" + webBrowserMain.Document.Cookie + "]";
            }
            Debug.WriteLine(description);
            LoggingService.Debug(description);

            if (IsHivePointUrl(e.Url))
            {
                Scheduler.Run(description,
                    () =>
                    {
                        if (IsNotCurrentLoadIteration())
                        {
                            // this isn't the current load itertion, ignore
                            return;
                        }
                        HandleHivePointUrl(e.Url);
                    }, 10);
                e.Cancel = true;
            }
            else if (IsIEErrorUrl(e.Url))
            {
                HandleInvalidIEVersion(e.Url);
            }
        }

        private static bool IsOauth(Uri url)
        {
            return url.PathAndQuery.ToLower().Contains("/r/svc/google_oauth");
        }

        private void HandleInvalidIEVersion(Uri uri)
        {
            LoggingService.Debug("Invalide IE Version");
            statusToast.Show("Invalid IE version", null, 15);
        }

        private bool IsIEErrorUrl(Uri uri)
        {
            return uri.ToString().ToLower().Contains(Constants.UrlIeVersionProblemString);
        }

    }
}