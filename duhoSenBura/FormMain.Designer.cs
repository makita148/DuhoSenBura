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
            this.panel_browser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_browser
            // 
            this.panel_browser.Controls.Add(this.webBrowser_main);
            this.panel_browser.Location = new System.Drawing.Point(113, 206);
            this.panel_browser.Name = "panel_browser";
            this.panel_browser.Size = new System.Drawing.Size(200, 100);
            this.panel_browser.TabIndex = 0;
            // 
            // webBrowser_main
            // 
            this.webBrowser_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_main.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_main.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_main.Name = "webBrowser_main";
            this.webBrowser_main.Size = new System.Drawing.Size(200, 100);
            this.webBrowser_main.TabIndex = 0;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 689);
            this.Controls.Add(this.panel_browser);
            this.Name = "Form_main";
            this.Text = "づほと川内ちゃんを愛でるための専用ブラウザ";
            this.panel_browser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_browser;
        private System.Windows.Forms.WebBrowser webBrowser_main;
    }
}

