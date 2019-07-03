using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Interoperability;

namespace Server.Ghost
{
    public static class LoginPacket
    {
        /* NetCafe
         * 會員於特約網咖連線
         */
        public static void Login_Ack(Client c, ServerState.LoginState state, short encryptKey = 0, bool netCafe = false)
        {
            using (var plew = new OutPacket(LoginServerOpcode.LOGIN_ACK))
            {
                //var awal = new int[4] { 0x00, 0x00, 0x00, 0x00 };
                //plew.WriteByte((byte)awal);

                for (int i = 0; i < 3; i++)
                {
                    plew.WriteByte(0x00);
                }
                plew.WriteByte((byte)state);
                //plew.WriteBool(netCafe);
                //plew.WriteBool(true);
                plew.WriteShort(encryptKey);

                c.Send(plew);
            }
        }

        public static void ServerList_Ack(Client c)
        {
            using (var plew = new OutPacket(LoginServerOpcode.SERVERLIST_ACK))
            {
                for (int i = 0; i < 13; i++)
                {
                    plew.WriteByte(0xFF);
                }
                plew.WriteInt(LoginServer.Worlds.Count); // 伺服器數量 Number of servers
                Log.Inform("Number of servers LoginServer.Worlds.Count : {0}", LoginServer.Worlds.Count);
                foreach (World world in LoginServer.Worlds) 
                {
                    Log.Inform("Server order world.ID : {0}", world.ID);
                    Log.Inform("Number of channels world.Channel : {0}", world.Channel);
                    plew.WriteShort(world.ID); // 伺服器順序 Server order
                    plew.WriteInt(world.Channel); // 頻道數量 Number of channels

                    for (int i = 0; i < 18; i++)
                    {
                        plew.WriteShort(i + 1);
                        plew.WriteShort(i + 1);
                        plew.WriteString(ServerConstants.SERVER_IP);
                        plew.WriteInt(15101 + i);
                        plew.WriteInt(i < world.Count ? world[i].LoadProportion : 0); // Number of players
                        plew.WriteInt(ServerConstants.CHANNEL_LOAD); // Maximum number of channels
                        plew.WriteInt(12); // 標章類型 Stamp type
                        plew.WriteInt(0);
                        plew.WriteByte(i < world.Count ? 1 : 2);
                        plew.WriteInt(15199);
                    }
                }

                c.Send(plew);
            }
        }

        public static void Game_Ack(Client c, ServerState.ChannelState state)
        {
            using (var plew = new OutPacket(LoginServerOpcode.GAME_ACK))
            {
                plew.WriteByte((byte)state);
                plew.WriteString(ServerConstants.SERVER_IP);
                plew.WriteInt(15101 + c.World.ID);
                plew.WriteInt(15199);

                c.Send(plew);
            }
        }

        public static void Char_Ack(Client c, ServerState.ChannelState state)
        {
            using (var plew = new OutPacket(LoginServerOpcode.CHAR_ACK))
            {
                //plew.WriteByte((byte)state);
                plew.WriteString(ServerConstants.SERVER_IP);
                /*plew.WriteByte(0x05);
                plew.WriteByte(0x00);*/
                plew.WriteString("15010");
                plew.WriteString(ServerConstants.SERVER_IP);
                plew.WriteString("15111");


                c.Send(plew);
            }
        }
    }
}
