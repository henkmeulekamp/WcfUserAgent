using System;
using System.Configuration;
using System.ServiceModel.Configuration;

namespace WcfUserAgent
{
    public class HttpUserAgentBehaviorExtensionElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof (HttpUserAgentEndpointBehavior); }
        }

        [ConfigurationProperty("userAgent", IsRequired = true)]
        public string UserAgent
        {
            get { return (string) base["userAgent"]; }
            set { base["userAgent"] = value; }
        }

        protected override object CreateBehavior()
        {
            return new HttpUserAgentEndpointBehavior(UserAgent);
        }
    }
}