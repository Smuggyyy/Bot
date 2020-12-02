/*
 * Class : ReqClient
 * Desc. : Classe principale
 * Author: Zenrox, Monstered
 * Date  : 02/12/2020 - 21h
 * Ajout : Thread, Grosse optimisation, groupbuilder remiser, Proxy type & fingerprint personalisé
*/

using static DiscordREQ.Modules.RelationShip;
using static DiscordREQ.Modules.UserSettings;
using static DiscordREQ.Modules.Message;
using static DiscordREQ.Modules.Group;
using static DiscordREQ.Modules.Guild;
using DiscordREQ.Backend;

namespace DiscordREQ
{
    public class ReqClient
    {
        public ReqClient(string token, string proxy = "", string ProxyType = "", int timeout = 3500, bool Threaded = false, string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36", string XFingerPrint = "622832459796709396.no-ggtFhW5yweBngUZhaXThqlKk")
        {
            Cache.XFingerPrint = XFingerPrint;
            Cache.ProxyType = ProxyType;
            Cache.Token = token;
            Cache.Proxy = proxy;
            Cache.Timeout = timeout;
            Cache.Threaded = Threaded;
            Cache.UserAgent = userAgent;
        }

        public class RelationShip
        {
            public class Friend
            {
                public static void Add(string UserID) => AddFriend(UserID);
                public static void Remove(string UserID) => DelFriend(UserID);
            }

            public class User
            {
                public static void Block(string UserID) => BlockUser(UserID);
                public static void UnBlock(string UserID) => UnBlockUser(UserID);
                public static void SetNote(string Text, string UserID) => SetNote(UserID, Text);
            }
        }

        public class Channel
        {
            public static void StartTyping(string ChannelID) => Typing(ChannelID);
        }

        public class Message
        {
            public class Reaction
            {
                public static void Add(string MessageID, string ChannelID, string EncodedEmoji) => SetReaction(MessageID, ChannelID, EncodedEmoji);
                public static void Remove(string MessageID, string ChannelID, string EncodedEmoji) => RemoveReaction(MessageID, ChannelID, EncodedEmoji);
            }

            public static void Edit(string NewMessage, string MessageID, string ChannelID) => EditMessage(NewMessage, MessageID, ChannelID);
            public static void Send(string Message, string ChannelID, bool tts = false) => SendMessage(Message, ChannelID, tts);
            public static void Delete(string MessageID, string ChannelID) => DeleteMessage(MessageID, ChannelID);
            public static void Pin(string MessageID, string ChannelID) => PinsMessage(MessageID, ChannelID);
            public static void UnPin(string MessageID, string ChannelID) => UnPinsMessage(MessageID, ChannelID);
        }

        public class Group
        {
            public class User
            {
                public static void Add(string UserID, string GroupID) => AddUserFromGroup(UserID, GroupID);
                public static void Kick(string UserID, string GroupID) => KickUserFromGroup(UserID, GroupID);
            }

            public static void Create(string UserID, string DmID) => CreateGroup(DmID, UserID);
            public static void Rename(string NewName, string GroupID) => RenameGroup(NewName, GroupID);
        }

        public class Guild
        {
            public class Emoji
            {
                public static void Delete(string ServerID, string Emoji) => DeleteEmoji(ServerID, Emoji);
            }
            public class Template
            {
                public static void Create(string ServerID, string Name, string Description) => CreateTemplate(ServerID, Name, Description);
                public static void Delete(string ServerID, string TemplateCode) => DeleteTemplate(ServerID, TemplateCode);
                public static void Use(string TemplateCode, string Name, string Icon = "") => UseTemplate(TemplateCode, Name, Icon);
            }
            public class Member
            {
                public class Role
                {
                    public static void Add(string ServerID, string UserID, string RoleID) => AddRole(ServerID, UserID, RoleID);
                    public static void Remove(string ServerID, string UserID) => RemoveRole(ServerID, UserID);
                }

                public static void Kick(string Reason, string ServerID, string UserID) => KickUser(ServerID, UserID, Reason);
                public static void Ban(string Reason, string ServerID, string UserID, string DeleteMessageAfterDay) => BanUser(ServerID, UserID, DeleteMessageAfterDay, Reason);
                public static void UnBan(string ServerID, string UserID) => UnBanUser(ServerID, UserID);
            }
            public class Role
            {
                public class Settings
                {
                    public static void SetRoleName(string Name, string RoleID, string ServerID) => SetRoleName(ServerID, RoleID, Name);
                    public static void SetRolePerm(string Perm, string RoleID, string ServerID) => SetRolePerm(ServerID, RoleID, Perm);
                    public static void SetRoleColor(string Color, string RoleID, string ServerID) => SetRoleColor(ServerID, RoleID, Color);
                    public static void SetRoleHoist(bool Hoist, string RoleID, string ServerID) => SetRoleHoist(Hoist, RoleID, ServerID);
                    public static void SetRolePing(bool Pingable, string RoleID, string ServerID) => SetRoleping(ServerID, RoleID, Pingable);
                }

                public static void Create(string Name, string ServerID) => CreateRole(ServerID, Name);
                public static void Delete(string ServerID, string RoleID) => DeleteRole(ServerID, RoleID);
                public static void Edit(string ServerID, string RoleID, string Name = "", string Permission = "", string Color = "", bool ping = false, bool hoist = false) => EditRole(ServerID, RoleID, Name, Permission, Color, ping, hoist);

            }
            public class Settings
            {
                public static void SetName(string Name, string ServerID) => SetName(ServerID, Name);
                public static void SetDescription(string Description, string ServerID) => SetDescription(ServerID, Description);
                public static void SetIcon(string Icon, string ServerID) => SetIcon(ServerID, Icon);
                public static void SetSplash(string Splash, string ServerID) => SetSplash(ServerID, Splash);
                public static void SetBanner(string Banner, string ServerID) => SetBanner(ServerID, Banner);
                public static void SetRegion(string Region, string ServerID) => SetRegion(ServerID, Region);
                public static void SetFeatures(string Features, string ServerID) => SetDescription(ServerID, Features);
                public static void SetAfkChannel(string AfkChannelID, string ServerID) => SetAfkChannel(ServerID, AfkChannelID);
                public static void SetAfkTime(string AfkTimeout, string ServerID) => SetAfkTime(ServerID, AfkTimeout);
                public static void VerificationLevel(string Level, string ServerID) => VerificationLevel(ServerID, Level);
                public static void SetMessNotif(string Noctification, string ServerID) => SetMessNotif(ServerID, Noctification);
                public static void SetContentFilter(string Filter, string ServerID) => SetContentFilter(ServerID, Filter);
            }
            public static void Join(string Invite) => JoinServer(Invite);
            public static void Leave(string ServerID) => LeaveServer(ServerID);
            public static void Delete(string ServerID) => DeleteServer(ServerID);
        }
    
        public class User
        {
            public class Setting
            {
                public static void Set_status(string Status) => SetStatus(Status);
                public static void Set_CustomStatus(string Text, string Expire) => SetCustomStatus(Text, Expire);
                public static void Set_Theme(string Theme) => SetTheme(Theme);
                public static void Set_DevMode(bool DevMode) => SetDevMode(DevMode);
                public static void Set_Username(string Name, string Pwd) => SetUsername(Name, Pwd);
                public static void Set_Language(string Langue) => SetLanguage(Langue);
                public static void Set_DisplayCompact(bool Display) => SetDisplayCompact(Display);
                public static void Set_AnimateStickers(string Choice) => SetAnimateStickers(Choice);
                public static void Set_ContentFilter(string Filter) => SetContentFilter(Filter);
                public static void Disable_Account(string Password) => DisableAccount(Password);
                public static void Delete_Account(string Password) => DeleteAccount(Password);
            }
        }
    }
}
