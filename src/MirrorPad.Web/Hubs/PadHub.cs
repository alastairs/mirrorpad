using SignalR.Hubs;

namespace MirrorPad.Web.Hubs
{
    [HubName("pad")]
    public class PadHub : Hub
    {
        public string Send(string text)
        {
            return text;
        }
    }
}