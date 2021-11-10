using System;

namespace ININ.PureCloud.OAuthControl
{
    public class Options
    {
        private string state;
        private string org;
        private string provider;
        public Options(string state, string org, string provider)
        {
            this.state = state;
            this.org = org;
            this.provider = provider;
        }

    }
}