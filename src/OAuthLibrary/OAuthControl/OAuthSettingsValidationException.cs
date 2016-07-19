using System;

namespace ININ.PureCloud.OAuthControl
{
    public class OAuthSettingsValidationException : Exception
    {
        public OAuthSettingsValidationException()
        {

        }

        public OAuthSettingsValidationException(string property) : base($"Invalid value: {property}")
        {

        }
    }
}