using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using ININ.PureCloud.OAuthControl;
using OAuth_Example_WPF.Annotations;

namespace OAuth_Example_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private OAuthWebBrowser _browser;
        private string _clientId = "";
        private string _clientSecret = "";
        private string _authToken = "";


        public string ClientId
        {
            get { return _clientId; }
            set
            {
                if (value == _clientId) return;
                _clientId = value;
                OnPropertyChanged();
            }
        }

        public string ClientSecret
        {
            get { return _clientSecret; }
            set
            {
                if (value == _clientSecret) return;
                _clientSecret = value;
                OnPropertyChanged();
            }
        }

        public string AuthToken
        {
            get { return _authToken; }
            set
            {
                if (value == _authToken) return;
                _authToken = value;
                OnPropertyChanged();
            }
        }


        public MainWindow()
        {
            InitializeComponent();

            // Set up browser
            _browser = new OAuthWebBrowser
            {
                Dock = DockStyle.Fill,
                RedirectUri = "http://invaliduri/"
            };
            _browser.Authenticated += token =>
            {
                if (!string.IsNullOrEmpty(token)) Console.WriteLine($"Token => {token}");
                AuthToken = token;
            };
            _browser.ExceptionEncountered += (source, exception) =>
            {
                Console.WriteLine($"[ERROR] {source} => {exception.Message}");
                Console.WriteLine(exception);
            };

            // Add to UI
            var panel = new System.Windows.Forms.Panel {Dock = DockStyle.Fill};
            panel.Controls.Add(_browser);
            BrowserHost.Child = panel;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void StartImplicitGrant_Click(object sender, RoutedEventArgs e)
        {
            _browser.ClientId = ClientId.Trim();
            _browser.ClientSecret = "";
            _browser.BeginImplicitGrant();
        }

        private void StartAuthCodeGrant_Click(object sender, RoutedEventArgs e)
        {
            _browser.ClientId = ClientId.Trim();
            _browser.ClientSecret = ClientSecret.Trim();
            _browser.BeginAuthorizationCodeGrant();
        }
    }
}
