using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ININ.PureCloud.OAuthControl;

namespace OAuth_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Handle events
            oAuthWebBrowser1.ExceptionEncountered +=
                (source, exception) =>
                {
                    Console.WriteLine($"[ERROR] {source} => {exception.Message}");
                    Console.WriteLine(exception);
                };
            oAuthWebBrowser1.Authenticated += token =>
            {
                if (!string.IsNullOrEmpty(token)) Console.WriteLine($"Token => {token}");
                txtToken.Text = token;
            };

            // Set browser settings
            oAuthWebBrowser1.RedirectUri = "http://invaliduri/";
        }

        private void btnImplicitGrant_Click(object sender, EventArgs e)
        {
            oAuthWebBrowser1.ClientId = txtClientId.Text.Trim();
            oAuthWebBrowser1.ClientSecret = "";
            oAuthWebBrowser1.BeginImplicitGrant();
        }
    }
}
