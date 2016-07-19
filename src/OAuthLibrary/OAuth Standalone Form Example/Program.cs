using System;
using ININ.PureCloud.OAuthControl;

namespace OAuth_Standalone_Form_Example
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                // Create form
                var form = new OAuthWebBrowserForm();

                // Set settings
                form.oAuthWebBrowser1.ClientId = "babbc081-0761-4f16-8f56-071aa402ebcb";
                form.oAuthWebBrowser1.RedirectUriIsFake = true;
                form.oAuthWebBrowser1.RedirectUri = "http://localhost:8080";

                // Open it
                var result = form.ShowDialog();

                Console.WriteLine($"Result: {result}");
                Console.WriteLine($"AccessToken: {form.oAuthWebBrowser1.AccessToken}");

                Console.WriteLine("Application complete.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
