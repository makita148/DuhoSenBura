namespace duhoSenBura
{
    partial class Form_main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_browser = new System.Windows.Forms.Panel();
            this.webBrowser_main = new System.Windows.Forms.WebBrowser();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.panel_browser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_browser
            // 
            this.panel_browser.Controls.Add(this.webBrowser_main);
            this.panel_browser.Location = new System.Drawing.Point(12, 12);
            this.panel_browser.Name = "panel_browser";
            this.panel_browser.Size = new System.Drawing.Size(800, 480);
            this.panel_browser.TabIndex = 0;
            // 
            // webBrowser_main
            // 
            this.webBrowser_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_main.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_main.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_main.Name = "webBrowser_main";
            this.webBrowser_main.Size = new System.Drawing.Size(800, 480);
            this.webBrowser_main.TabIndex = 0;
            this.webBrowser_main.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_main_DocumentCompleted);
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(12, 587);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(799, 19);
            this.textBox_url.TabIndex = 1;
            this.textBox_url.Text = "http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 618);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.panel_browser);
            this.Name = "Form_main";
            this.Text = "づほと川内ちゃんを愛でるための専用ブラウザ";
            this.panel_browser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_browser;
        private System.Windows.Forms.WebBrowser webBrowser_main;
        private System.Windows.Forms.TextBox textBox_url;
    }
}

