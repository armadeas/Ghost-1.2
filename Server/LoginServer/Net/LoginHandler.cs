﻿using Server.Accounts;
using Server.Common;
using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Security;
using System;

namespace Server.Ghost
{
    public static class LoginHandler
    {
        public static void Login_Req(InPacket lea, Client c)
        {
            string username = lea.ReadString();
            string password = lea.ReadString();
            /*string deas = lea.ReadString();*/
            /*string ganteng = lea.ReadString();*/
            short encryptKey = lea.ReadShort();
            Log.Inform("Username {0}", username);
            Log.Inform("Password_enc {0}", password);
            Log.Inform("EncKey {0}", encryptKey);

            if (username.IsAlphaNumeric() == false)
            {
                LoginPacket.Login_Ack(c, ServerState.LoginState.NO_USERNAME);
                return;
            }

            c.SetAccount(new Account(c));

            try
            {
                c.Account.Load(username);
                var pe = new PasswordEncrypt(encryptKey);
                string encryptPassword = pe.encrypt(c.Account.Password, c.RetryLoginCount > 0 ? password.ToCharArray() : null);
                //Log.Inform("Password : {0}", encryptPassword);

                if (password.Equals(c.Account.Password))
                {
                    LoginPacket.Login_Ack(c, ServerState.LoginState.PASSWORD_ERROR);
                    Log.Error("Login Fail!");
                    c.RetryLoginCount += 1;
                }
                else if (c.Account.Banned == 1)
                {
                    LoginPacket.Login_Ack(c, ServerState.LoginState.USER_LOCK);
                }
                else
                {
                    LoginPacket.Login_Ack(c, ServerState.LoginState.OK, encryptKey, c.Account.Master > 0 ? true : false);
                    c.Account.LoggedIn = 1;
                    Log.Success("Login Success!");
                }
                Log.Inform("Password = {0}", password);
                Log.Inform("encryptKey = {0}", encryptKey);
                Log.Inform("encryptPassword = {0}", encryptPassword);
            }
            catch (NoAccountException)
            {
                if (ServerConstants.AUTO_REGISTRATION == true)
                {
                    if (username.Length < 5 || password.Length < 5)
                        LoginPacket.Login_Ack(c, ServerState.LoginState.NO_USERNAME);

                    Account account = new Account(c);
                    account.Username = username.ToLower();
                    account.Password = password;
                    account.Creation = DateTime.Now;
                    account.LoggedIn = 0;
                    account.Banned = 0;
                    account.Master = 0;
                    account.GamePoints = 0;
                    account.GiftPoints = 0;
                    account.BonusPoints = 0;
                    account.Save();
                    LoginPacket.Login_Ack(c, ServerState.LoginState.USER_LOCK);
                    return;
                }
                    LoginPacket.Login_Ack(c, ServerState.LoginState.NO_USERNAME);
                }
            }

        public static void ServerList_Req(InPacket lea, Client c)
        {
            LoginPacket.ServerList_Ack(c);
        }

        public static void Game_Req(InPacket lea, Client c)
        {
            LoginPacket.Game_Ack(c, ServerState.ChannelState.OK);
        }

        public static void Char_Req(InPacket lea, Client c)
        {
            LoginPacket.Char_Ack(c, ServerState.ChannelState.OK);
        }
    }
}
