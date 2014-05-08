using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codeplex.Data;

namespace duhoSenBura
{
    public partial class Form_main : Form
    {
        private duhoSenBura.Data.DuhoSenEntities entDSB = new Data.DuhoSenEntities();

        public Form_main()
        {
            InitializeComponent();

            

            this.Init();
        }

        private void Init()
        {
            this.LoadBrowserInfo();
            this.InitFiddlerCore();

            return;
        }

        private void InitFiddlerCore()
        {
            /// クライアントへレスポンスを返した後に呼ばれるイベント
            Fiddler.FiddlerApplication.AfterSessionComplete
                        += new Fiddler.SessionStateHandler(FiddlerApplication_AfterSessionComplete);

            /// Fiddlerを開始。ポートは自動選択
            Fiddler.FiddlerApplication.Startup(0, Fiddler.FiddlerCoreStartupFlags.ChainToUpstreamGateway);

            /// 当該プロセスのプロキシを設定する。WebBroweserコントロールはこの設定を参照
            Fiddler.URLMonInterop.SetProxyInProcess(
                string.Format("127.0.0.1:{0}", Fiddler.FiddlerApplication.oProxy.ListenPort), 
                "<local>");

            return;
        }

        void FiddlerApplication_AfterSessionComplete(Fiddler.Session aSession)
        {
            var resp = aSession.oResponse;
            var sessionData = string.Format("{4} :Session {0}({3}):HTTP {1} for {2}",
                    aSession.id, aSession.responseCode, aSession.fullUrl, resp.MIMEType, DateTime.Now.ToString());

            switch (resp.MIMEType)
            {
                case "text/plain":
                    if (!aSession.fullUrl.EndsWith("api_start2"))
                    {
                        try
                        {
                            var requestBody = Encoding.UTF8.GetString(aSession.responseBodyBytes);
                            var jsonSrc = requestBody.Substring(requestBody.IndexOf('=') + 1);
                            var json = DynamicJson.Parse(jsonSrc);

                            var kvData = new List<String>();

                            foreach (KeyValuePair<String, dynamic> item in json)
                            {
                                kvData.Add(item.Key + ":" + item.Value.ToString());
                            }

                            this.DispOnMonitor(sessionData + Environment.NewLine +
                                String.Join(Environment.NewLine, kvData.ToArray()));
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }

                    break;

                default:
                    break;
            }

            try
            {
                textBox_fiddler_raw.Text = sessionData + Environment.NewLine + textBox_fiddler_raw.Text;
            }
            catch (Exception)
            {
                throw;
            }

            return;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            /// プロキシ設定を外す
            Fiddler.URLMonInterop.ResetProxyInProcessToDefault();

            /// Fiddlerを終了させる
            Fiddler.FiddlerApplication.Shutdown();
        }

        private void LoadBrowserInfo()
        {
            var url = textBox_url.Text;
            webBrowser_main.Navigate( url);

            return;
        }

        private void webBrowser_main_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_main.Document.Window.ScrollTo( duhoSenBura.Properties.Settings.Default.MainWindowOffset);
            webBrowser_main.Document.Body.Style = "overflow-x:hidden;overflow-y:hidden";

            return;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception)
            {
                
                throw;
            }

            return;
        }

        private void DispSDFTest()
        {
            try
            {
                var rankList = entDSB.MRank;
                var rowData = String.Join(Environment.NewLine,
                    rankList.Select(q =>
                    q.code + "/" + q.value).ToArray());

                this.DispOnMonitor(rowData);
            }
            catch (Exception)
            {
                
                throw;
            }

            return;
        }

        private void DispOnMonitor(string aVal)
        {
            textBox_monitor.Text =  aVal + Environment.NewLine + textBox_monitor.Text;

            return;
        }
    }
}
