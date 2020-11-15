using DiscordREQ.Backend;
using System.Threading;

namespace DiscordREQ
{
    public class ReqClient
    {
        public ReqClient(string token, string proxy = "", int timeout = 3500, string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36")
        {
            Cache.Token = token;
            Cache.Proxy = proxy;
            Cache.Timeout = timeout;
            Cache.UserAgent = userAgent;
        }
        
        public void ThreadedJoin(string Invite)
        {
            Thread T = new Thread(() => Modules.Guild.JoinServer(Invite));
            T.Start();
        }

        public void ThreadedLeave(string ServerID)
        {
            Thread T = new Thread(() => Modules.Guild.LeaveServer(ServerID));
            T.Start();
        }

        public void ThreadedAddUserToGroup(string UserID, string GroupID)
        {
            Thread T = new Thread(() => Modules.Group.AddUserFromGroup(UserID, GroupID));
            T.Start();
        }

        public void ThreadedKickUserToGroup(string UserID, string GroupID)
        {
            Thread T = new Thread(() => Modules.Group.KickUserFromGroup(UserID, GroupID));
            T.Start();
        }

        public void ThreadedSendMessage(string Message, string ChannelID, bool tts = false)
        {
            Thread T = new Thread(() => Modules.Message.SendMessage(Message, ChannelID, tts));
            T.Start();
        }

        public void ThreadedRemoveSendMessage(string MessageID, string ChannelID)
        {
            Thread T = new Thread(() => Modules.Message.DeleteMessage(MessageID, ChannelID));
            T.Start();
        }
    }
}
