namespace ININ.PureCloud.OAuthControl
{
    partial class OAuthWebBrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oAuthWebBrowser1 = new ININ.PureCloud.OAuthControl.OAuthWebBrowser();
            this.SuspendLayout();
            // 
            // oAuthWebBrowser1
            // 
            this.oAuthWebBrowser1.ClientId = null;
            this.oAuthWebBrowser1.ClientSecret = null;
            this.oAuthWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oAuthWebBrowser1.Environment = "mypurecloud";
            this.oAuthWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.oAuthWebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.oAuthWebBrowser1.Name = "oAuthWebBrowser1";
            this.oAuthWebBrowser1.RedirectUri = null;
            this.oAuthWebBrowser1.RedirectUriIsFake = false;
            this.oAuthWebBrowser1.Size = new System.Drawing.Size(534, 561);
            this.oAuthWebBrowser1.TabIndex = 0;
            // 
            // OAuthWebBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.oAuthWebBrowser1);
            this.Name = "OAuthWebBrowserForm";
            this.Text = "PureCloud Login";
            this.ResumeLayout(false);

        }

        #endregion

        public OAuthWebBrowser oAuthWebBrowser1;
    }
}