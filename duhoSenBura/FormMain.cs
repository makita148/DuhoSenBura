using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duhoSenBura
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();

            this.Init();
        }

        private void Init()
        {
            this.LoadBrowserInfo();

            return;
        }

        private void LoadBrowserInfo()
        {
            var url = textBox_url.Text;
            webBrowser_main.Navigate( url);

            return;
        }

        private void webBrowser_main_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_main.Document.Window.ScrollTo(new Point(74, 74));
            webBrowser_main.Document.Body.Style = "overflow-x:hidden;overflow-y:hidden";

            return;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var rowData = webBrowser_main.Document.Body.ScrollLeft.ToString();
            this.DispOnMonitor( rowData);

            return;
        }

        private void DispOnMonitor(string aVal)
        {
            textBox_monitor.Text += Environment.NewLine + aVal;

            return;
        }
    }
}
