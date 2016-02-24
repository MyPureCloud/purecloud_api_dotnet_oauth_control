using ININ.PureCloud.OAuthControl;

namespace OAuth_Example
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAuthCodeGrant = new System.Windows.Forms.Button();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImplicitGrant = new System.Windows.Forms.Button();
            this.oAuthWebBrowser1 = new OAuthWebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token:";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToken.Enabled = false;
            this.txtToken.Location = new System.Drawing.Point(88, 629);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(644, 20);
            this.txtToken.TabIndex = 2;
            // 
            // txtClientId
            // 
            this.txtClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientId.Location = new System.Drawing.Point(88, 575);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(491, 20);
            this.txtClientId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client ID:";
            // 
            // btnAuthCodeGrant
            // 
            this.btnAuthCodeGrant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuthCodeGrant.Location = new System.Drawing.Point(585, 603);
            this.btnAuthCodeGrant.Name = "btnAuthCodeGrant";
            this.btnAuthCodeGrant.Size = new System.Drawing.Size(147, 20);
            this.btnAuthCodeGrant.TabIndex = 5;
            this.btnAuthCodeGrant.Text = "Start Auth Code Grant";
            this.btnAuthCodeGrant.UseVisualStyleBackColor = true;
            this.btnAuthCodeGrant.Click += new System.EventHandler(this.btnAuthCodeGrant_Click);
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientSecret.Location = new System.Drawing.Point(88, 603);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(491, 20);
            this.txtClientSecret.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Secret:";
            // 
            // btnImplicitGrant
            // 
            this.btnImplicitGrant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImplicitGrant.Location = new System.Drawing.Point(585, 575);
            this.btnImplicitGrant.Name = "btnImplicitGrant";
            this.btnImplicitGrant.Size = new System.Drawing.Size(147, 20);
            this.btnImplicitGrant.TabIndex = 8;
            this.btnImplicitGrant.Text = "Start Implicit Grant";
            this.btnImplicitGrant.UseVisualStyleBackColor = true;
            this.btnImplicitGrant.Click += new System.EventHandler(this.btnImplicitGrant_Click);
            // 
            // oAuthWebBrowser1
            // 
            this.oAuthWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oAuthWebBrowser1.ClientId = null;
            this.oAuthWebBrowser1.ClientSecret = null;
            this.oAuthWebBrowser1.Environment = "mypurecloud";
            this.oAuthWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.oAuthWebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.oAuthWebBrowser1.Name = "oAuthWebBrowser1";
            this.oAuthWebBrowser1.RedirectUri = null;
            this.oAuthWebBrowser1.RedirectUriIsFake = true;
            this.oAuthWebBrowser1.Size = new System.Drawing.Size(744, 514);
            this.oAuthWebBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 661);
            this.Controls.Add(this.btnImplicitGrant);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAuthCodeGrant);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oAuthWebBrowser1);
            this.Name = "Form1";
            this.Text = "OAuth Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OAuthWebBrowser oAuthWebBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuthCodeGrant;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImplicitGrant;
    }
}

