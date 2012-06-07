using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace WcfUserAgent
{
    /// <summary>
    /// based on: http://msmvps.com/blogs/paulomorgado/archive/2007/04/27/wcf-building-an-http-user-agent-message-inspector.aspx
    /// </summary>
    public class HttpUserAgentMessageInspector : IClientMessageInspector
    {
        private readonly string _userAgent;

        public HttpUserAgentMessageInspector(string userAgent)
        {
            _userAgent = userAgent;
        }

        #region IClientMessageInspector Members

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            HttpRequestMessageProperty httpRequestMessage;
            object httpRequestMessageObject;
            if (request.Properties.TryGetValue(HttpRequestMessageProperty.Name, out httpRequestMessageObject))
            {
                httpRequestMessage = httpRequestMessageObject as HttpRequestMessageProperty;

                if (httpRequestMessage != null && string.IsNullOrEmpty(httpRequestMessage.Headers["user-agent"]))
                {
                    httpRequestMessage.Headers["user-agent"] = _userAgent;
                }
            }
            else
            {
                httpRequestMessage = new HttpRequestMessageProperty();
                httpRequestMessage.Headers.Add("user-agent", _userAgent);
                request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessage);
            }


            return null;
        }

        #endregion
    }
}