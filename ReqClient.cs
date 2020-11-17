/*
 * Class : ReqClient
 * Desc. : Classe principale
 * Author: Zenrox, Monstered
 * Date  : 17/11/2020 - 21h
*/

using DiscordREQ.Backend;
using System.Collections.Generic;
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

        public class RelationShip
        {
            public class Friend
            {
                public static void Add(string UserID)
                {
                    Thread T = new Thread(() => Modules.RelationShip.AddFriend(UserID));
                    T.Start();
                }

                public static void Remove(string UserID)
                {
                    Thread T = new Thread(() => Modules.RelationShip.DelFriend(UserID));
                    T.Start();
                }
            }

            public class User
            {
                public static void Block(string UserID)
                {
                    Thread T = new Thread(() => Modules.RelationShip.BlockUser(UserID));
                    T.Start();
                }

                public static void UnBlock(string UserID)
                {
                    Thread T = new Thread(() => Modules.RelationShip.UnBlockUser(UserID));
                    T.Start();
                }

                public static void SetNote(string Text, string UserID)
                {
                    Thread T = new Thread(() => Modules.RelationShip.SetNote(UserID, Text));
                    T.Start();
                }
            }
        }
        
        public class Channel
        {
            public static void StartTyping(string ChannelID)
            {
                Thread T = new Thread(() => Modules.Message.Typing(ChannelID));
                T.Start();
            }
        }

        public class Message
        {
            public class Reaction
            {
                public static void Add(string MessageID, string ChannelID, string EncodedEmoji)
                {
                    Thread T = new Thread(() => Modules.Message.SetReaction(MessageID, ChannelID, EncodedEmoji));
                    T.Start();
                }
                public static void Remove(string MessageID, string ChannelID, string EncodedEmoji)
                {
                    Thread T = new Thread(() => Modules.Message.RemoveReaction(MessageID, ChannelID, EncodedEmoji));
                    T.Start();
                }

            }

            public static void Edit(string NewMessage, string MessageID, string ChannelID)
            {
                Thread T = new Thread(() => Modules.Message.EditMessage(NewMessage, MessageID, ChannelID));
                T.Start();
            }
            public static void Send(string Message, string ChannelID, bool tts = false)
            {
                Thread T = new Thread(() => Modules.Message.SendMessage(Message, ChannelID, tts));
                T.Start();
            }
            public static void Delete(string MessageID, string ChannelID)
            {
                Thread T = new Thread(() => Modules.Message.DeleteMessage(MessageID, ChannelID));
                T.Start();
            }
            public static void Pin(string MessageID, string ChannelID)
            {
                Thread T = new Thread(() => Modules.Message.PinsMessage(MessageID, ChannelID));
                T.Start();
            }
            public static void UnPin(string MessageID, string ChannelID)
            {
                Thread T = new Thread(() => Modules.Message.UnPinsMessage(MessageID, ChannelID));
                T.Start();
            }
        }

        public class Group
        {
            public class GroupBuilder
            {
                public GroupBuilder(string DmID, List<string> Users, string Name = "DiscordREQ", string Icon = "")
                {
                    Cache.GroupUser = Users;
                    Cache.GroupName = Name;
                    Cache.GroupIcon = Icon;
                    Cache.GroupDmID = DmID;
                }

                public void Build()
                {
                    Group.Create(Cache.GroupDmID, Cache.GroupUser[0]);

                    Group.Rename(Cache.GroupName, Cache.LastedGroupId);

                    foreach (string User in Cache.GroupUser)
                    {
                        Group.User.Add(User, Cache.LastedGroupId);
                    }
                }
            }
            public class User
            {
                public static void Add(string UserID, string GroupID)
                {
                    Thread T = new Thread(() => Modules.Group.AddUserFromGroup(UserID, GroupID));
                    T.Start();
                }
                public static void Kick(string UserID, string GroupID)
                {
                    Thread T = new Thread(() => Modules.Group.KickUserFromGroup(UserID, GroupID));
                    T.Start();
                }
            }

            public static void Create(string UserID, string DmID)
            {
                Thread T = new Thread(() => Modules.Group.CreateGroup(DmID, UserID));
                T.Start();
            }
            public static void Rename(string NewName, string GroupID)
            {
                Thread T = new Thread(() => Modules.Group.RenameGroup(NewName, GroupID));
                T.Start();
            }
        }

        public class Guild
        {
            public class Emoji
            {
                public static void Delete(string ServerID, string Emoji)
                {
                    Thread T = new Thread(() => Modules.Guild.DeleteEmoji(ServerID, Emoji));
                    T.Start();
                }
            }
            public class Template
            {
                public static void Create(string ServerID, string Name, string Description)
                {
                    Thread T = new Thread(() => Modules.Guild.CreateTemplate(ServerID, Name, Description));
                    T.Start();
                }
                public static void Delete(string ServerID, string TemplateCode)
                {
                    Thread T = new Thread(() => Modules.Guild.DeleteTemplate(ServerID, TemplateCode));
                    T.Start();
                }
                public static void Use(string TemplateCode, string Name, string Icon = "")
                {
                    Thread T = new Thread(() => Modules.Guild.UseTemplate(TemplateCode, Name, Icon));
                    T.Start();
                }
            }
            public class Member
            {
                public class Role
                {
                    public static void Add(string ServerID, string UserID, string RoleID)
                    {
                        Thread T = new Thread(() => Modules.Guild.AddRole(ServerID, UserID, RoleID));
                        T.Start();
                    }
                    public static void Remove(string ServerID, string UserID)
                    {
                        Thread T = new Thread(() => Modules.Guild.RemoveRole(ServerID, UserID));
                        T.Start();
                    }
                }

                public static void Kick(string Reason, string ServerID, string UserID)
                {
                    Thread T = new Thread(() => Modules.Guild.KickUser(ServerID, UserID, Reason));
                    T.Start();
                }
                public static void Ban(string Reason, string ServerID, string UserID, string DeleteMessageAfterDay)
                {
                    Thread T = new Thread(() => Modules.Guild.BanUser(ServerID, UserID, DeleteMessageAfterDay, Reason));
                    T.Start();
                }
                public static void UnBan(string ServerID, string UserID)
                {
                    Thread T = new Thread(() => Modules.Guild.UnBanUser(ServerID, UserID));
                    T.Start();
                }
            }
            public class Role
            {
                public class Settings
                {
                    public static void SetRoleName(string Name, string RoleID, string ServerID)
                    {
                        Thread T = new Thread(() => Modules.Guild.SetRoleName(ServerID, RoleID, Name));
                        T.Start();
                    }
                    public static void SetRolePerm(string Perm, string RoleID, string ServerID)
                    {
                        Thread T = new Thread(() => Modules.Guild.SetRolePerm(ServerID, RoleID, Perm));
                        T.Start();
                    }
                    public static void SetRoleColor(string Color, string RoleID, string ServerID)
                    {
                        Thread T = new Thread(() => Modules.Guild.SetRoleColor(ServerID, RoleID, Color));
                        T.Start();
                    }
                    public static void SetRoleHoist(bool Hoist, string RoleID, string ServerID)
                    {
                        Thread T = new Thread(() => Modules.Guild.SetRoleHoist(ServerID, RoleID, Hoist));
                        T.Start();
                    }
                    public static void SetRolePing(bool Pingable, string RoleID, string ServerID)
                    {
                        Thread T = new Thread(() => Modules.Guild.SetRoleping(ServerID, RoleID, Pingable));
                        T.Start();
                    }
                }

                public static void Create(string Name, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.CreateRole(ServerID, Name));
                    T.Start();
                }
                public static void Delete(string ServerID, string RoleID)
                {
                    Thread T = new Thread(() => Modules.Guild.DeleteRole(ServerID, RoleID));
                    T.Start();
                }
                public static void Edit(string ServerID, string RoleID, string Name = "", string Permission = "", string Color = "", bool ping = false, bool hoist = false)
                {
                    Thread T = new Thread(() => Modules.Guild.EditRole(ServerID, RoleID, Name, Permission, Color, ping, hoist));
                    T.Start();
                }

            }
            public class Settings
            {
                public static void SetName(string Name, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetName(ServerID, Name));
                    T.Start();
                }
                public static void SetDescription(string Description, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetDescription(ServerID, Description));
                    T.Start();
                }
                public static void SetIcon(string Icon, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetIcon(ServerID, Icon));
                    T.Start();
                }
                public static void SetSplash(string Splash, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetSplash(ServerID, Splash));
                    T.Start();
                }
                public static void SetBanner(string Banner, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetBanner(ServerID, Banner));
                    T.Start();
                }
                public static void SetRegion(string Region, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetRegion(ServerID, Region));
                    T.Start();
                }
                public static void SetFeatures(string Features, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetDescription(ServerID, Features));
                    T.Start();
                }
                public static void SetAfkChannel(string AfkChannelID, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetAfkChannel(ServerID, AfkChannelID));
                    T.Start();
                }
                public static void SetAfkTime(string AfkTimeout, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetAfkTime(ServerID, AfkTimeout));
                    T.Start();
                }
                public static void VerificationLevel(string Level, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.VerificationLevel(ServerID, Level));
                    T.Start();
                }
                public static void SetMessNotif(string Noctification, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetMessNotif(ServerID, Noctification));
                    T.Start();
                }
                public static void SetContentFilter(string Filter, string ServerID)
                {
                    Thread T = new Thread(() => Modules.Guild.SetContentFilter(ServerID, Filter));
                    T.Start();
                }
            }

            public static void Join(string Invite)
            {
                Thread T = new Thread(() => Modules.Guild.JoinServer(Invite));
                T.Start();
            }
            public static void Leave(string ServerID)
            {
                Thread T = new Thread(() => Modules.Guild.LeaveServer(ServerID));
                T.Start();
            }
            public static void Delete(string ServerID)
            {
                Thread T = new Thread(() => Modules.Guild.DeleteServer(ServerID));
                T.Start();
            }
        }
    }
}