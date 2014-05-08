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
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.webBrowser_main = new System.Windows.Forms.WebBrowser();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_monitor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_url
            // 
            this.textBox_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_url.Location = new System.Drawing.Point(12, 751);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(1057, 19);
            this.textBox_url.TabIndex = 1;
            this.textBox_url.Text = "http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/";
            // 
            // webBrowser_main
            // 
            this.webBrowser_main.Location = new System.Drawing.Point(92, 82);
            this.webBrowser_main.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_main.Name = "webBrowser_main";
            this.webBrowser_main.ScrollBarsEnabled = false;
            this.webBrowser_main.Size = new System.Drawing.Size(800, 480);
            this.webBrowser_main.TabIndex = 0;
            this.webBrowser_main.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_main_DocumentCompleted);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(58, 663);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "状態更新";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_monitor
            // 
            this.textBox_monitor.Location = new System.Drawing.Point(366, 604);
            this.textBox_monitor.Multiline = true;
            this.textBox_monitor.Name = "textBox_monitor";
            this.textBox_monitor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_monitor.Size = new System.Drawing.Size(703, 141);
            this.textBox_monitor.TabIndex = 3;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 782);
            this.Controls.Add(this.textBox_monitor);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.webBrowser_main);
            this.Controls.Add(this.textBox_url);
            this.Name = "Form_main";
            this.Text = "づほと川内ちゃんを愛でるための専用ブラウザ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.WebBrowser webBrowser_main;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_monitor;
    }
}

