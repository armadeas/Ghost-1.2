﻿
namespace Server.Common.Net
{
    public enum InteroperabilityMessage : ushort
    {
        RegistrationRequest,
        RegistrationResponse,

        LoadProportionRequest,
        LoadProportionResponse,

        CharacterEntriesRequest,
        CharacterEntriesResponse,

        CharacterNameCheckRequest,
        CharacterNameCheckResponse,

        CharacterCreationRequest,
        CharacterCreationResponse,

        CharacterDeletionRequest,
        CharacterDeletionResponse,

        CharPortRequest,
        CharPortResponse,

        GamePortRequest,
        GamePortResponse,

        MessagePortRequest,
        MessagePortResponse,

        ShopPortRequest,
        ShopPortResposne,

        WhisperFindRequest,
        WhisperFindResult
    }

    public enum LoginClientOpcode : byte
    {
        LOGIN_REQ = 0x30,
        SERVERLIST_REQ = 0x32,
        GAME_REQ = 0x34,
        CHAR_REQ = 0x3B,
    }

    public enum ClientOpcode : ushort
    {
        LOGIN_SERVER = 0x55AA,
        //SERVER = 0x4D,
        SERVER = 0x0105,

        // CharServer
        MYCHAR_INFO_REQ = 0x8,
        CREATE_MYCHAR_REQ = 0xA,
        CHECK_SAMENAME_REQ = 0xC,
        DELETE_MYCHAR_REQ = 0xE,

        // GameServer
        COMMAND_REQ = 0x10,
        CHAT_REQ = 0x17,
        GAMELOG_REQ = 0x18,
        ENTER_WARP_ACK_REQ = 0x1D,
        NPC_SHOP_BUY_REQ = 0x22,
        NPC_SHOP_SELL_REQ = 0x23,
        P_WARP_C = 0x24,
        P_MOVE_C = 0x27,
        P_SPEED_C = 0x29,
        P_JUMP_C = 0x2A,
        P_ATTACK_C = 0x2B,
        P_DEFENCE_C = 0x2C,
        P_DAMAGE_C = 0x2D,
        P_SPELL_C = 0x2E,
        P_DEAD_C = 0x2F,
        P_SKILL_C = 0x31,
        ATTACK_MONSTER_REQ = 0x45,
        CHAR_DAMAGE_REQ = 0x46,
        CHAR_DEAD_REQ = 0x47,
        PICKUP_ITEM = 0x4C,
        CHAR_STATUP_REQ = 0x5F,
        CHAR_FURY = 0x62,
        MOVE_ITEM_REQ = 0x6C,
        INVEN_SELECTSLOT_REQ = 0x6D,
        USE_SPEND_REQ = 0x6F,
        INVEN_USESPEND_REQ = 0x70,
        SKILL_LEVELUP_REQ = 0x74,
        USE_SKILL_REQ = 0x76,
        //
        QUEST_ALL_REQ = 0x7A,
        QUEST_GIVEUP_REQ = 0x7B,
        QUEST_DONE_REQ = 0x7C,
        QUEST_RETURN_REQ = 0x7D,
        QUEST_DONE2_REQ = 0x7E,
        QUEST_UPDATE_REQ = 0x7F,
        //
        SPIRIT_MOVE_REQ = 0x82,
        EQUIPMENT_COMPOUND_REQ = 0x83,
        //
        CAN_WARP_ACK_REQ = 0x85,
        //
        TRADE_INVITE_REQ = 0x92,
        TRADE_INVITE_RESPONSE_REQ = 0x93,
        TRADE_READY_REQ = 0x94,
        TRADE_CONFIRM_REQ = 0x95,
        TRADE_CANCEL_REQ = 0x96,
        TRADE_PUT_REQ = 0x99,
        //
        PARTY_INVITE_REQ = 0x9B,
        PARTY_INVITE_RESPONSES_REQ = 0x9C,
        PARTY_LEAVE = 0x9F,
        // 0xA0 驅逐隊員
        //
        PVP_REQ = 0xA4,
        PVP_ACK_REQ = 0xA5,
        //
        QUICK_SLOT_REQ = 0xA8,
        //
        MOVE_ITEM_STORAGE_REQ = 0xAC,
        MOVE_ITEM_TO_BAG_REQ = 0xAD,
        SAVE_MONEY_REQ = 0xAE,
        GIVE_MONEY_REQ = 0xAF,
        //
        PSHOP_OPEN_REQ = 0xCD,
        PSHOP_SELLSTART_REQ = 0xCF,
        PSHOP_SELLEND_REQ = 0xD1,
        PSHOP_INFO_REQ = 0xD3,
        PSHOP_BUYACK_REQ = 0xD5,

        EVENTITEM_ACK = 0xD8,
        //
        P_MOVE_C_2 = 0xDD,
        //
        FISH_REQ = 0xE0,
        //
        CASHSHOP_LIST_REQ = 0xE4,
        CASH_MGAMECASH_REQ = 0xE5,
        CASH_BUY_REQ = 0xE7,
        CASH_GIFT_REQ = 0xE9,
        CASH_TO_INVEN_REQ = 0xEF,
        CASH_CHECKCHARNAME_REQ = 0xFC,
        ABILITY_RECOVER_REQ = 0xF8,
        INVEN_USESPEND_SHOUT_REQ = 0xFA,
        //
        PET_NAME_REQ = 0x101,
        PET_MOVE_C = 0x10B,
        PET_MOVETO_C = 0x10C,
        PET_MOVEBIRD_C = 0x10D,
        PET_MOVEBIRDTO_C = 0x10E,
        PET_JUMP_C = 0x110,
        PET_ATTACK_C = 0x111,
        PET_DEFENCE_C = 0x112,
        PET_DAMAGE_C = 0x113,
        PET_SPELL_C = 0x114,
        PET_DEAD_C = 0x115,
        PET_SKILL_C = 0x116,
        PET_WARP_C = 0x117,
        PET_SAY_C = 0x118,
        //
        CASH_SN = 0x11D,

        DISMANTLE_REQ = 0x140,

        //
        INVEN_USESPEND_SHOUT_ALL_REQ = 0x16B,
        //
        SP_SPEED_C = 0x18D,
        SP_MOVE_C = 0x18E,
        SP_JUMP_C = 0x18F,
        SP_ATTACK_C = 0x190,
        SP_SKILL_C = 0x191,
        SP_SPELL_C = 0x192,
        SP_WARP_C = 0x193,
    }

    public enum LoginServerOpcode : byte
    {
        // LoginServer
        LOGIN_ACK = 0x31,
        SERVERLIST_ACK = 0x33,
        GAME_ACK = 0x35,
        CHAR_ACK = 0x3C,
    }

    public enum ServerOpcode : ushort
    {
        // CharServer
        MYCHAR_INFO_ACK = 0x9,
        CREATE_MYCHAR_ACK = 0xB,
        CHECK_SAMENAME_ACK = 0xD,
        DELETE_MYCHAR_ACK = 0xF,

        // GameServer
        NOTICE = 0x12,
        // 0x13
        GAMELOG = 0x14,

        USER_INFO = 0x16,
        CHAT = 0x17,

        ENTER_FIELD_ACK = 0x19,

        ENTER_MAP_START = 0x1C,
        //ENTER_MAP_END = 0x1C,

        ENTER_WARP_ACK = 0x1E,
        //WARP_ACK = 0x1E,
        LEAVE_WARP_ACK = 0x1F,
        BADUSER = 0x20,

        NPC_SHOP_ACK = 0x23,

        UDPLOG_ACK = 0x25,

        MON_SPAWN = 0x38, // 2015/10/31

        MON_REGEN = 0x3F,

        MON_ALLCREATE = 0x42,
        MON_HPDOWN = 0x43,
        USER_CREATE = 0x44,

        PLAYER_DEAD_ACK = 0x48,
        MON_DROP_ITEM = 0x4A,
        // 0x4B

        CLEAR_DROP_ITEM = 0x4D,
        CHAR_DROP_ITEM = 0x4E,
        ITEM_ALLCREATE = 0x4F,
        CHAR_ALL = 0x50,
        CHAR_HPSP = 0x51,
        CHAR_MAXHPPLUS = 0x52,
        CHAR_MAXSPPLUS = 0x53,
        CHAR_ASPPLUS = 0x54,
        CHAR_SPDPLUS = 0x55,
        CHAR_LJUMPPLUS = 0x56,
        CHAR_PAPLUS = 0x57,
        CHAR_MAPLUS = 0x58,
        CHAR_DEFPLUS = 0x59,
        CHAR_DEFPLUS_SKILL = 0x5A,
        CHAR_LVEXP = 0x5B,
        CHAR_SET_AVATAR = 0x5C,
        CHAR_LEVELUP = 0x5D,
        CHAR_FAME = 0x5E,

        CHAR_STATUP_ACK = 0x60,
        CHAR_HIDE = 0x61,

        CHAR_USERSP_ACK = 0x63,
        INVEN_ALL = 0x64,   // 全部
        INVEN_EQUIP = 0x65, // 裝備
        INVEN_EQUIP1 = 0x66,// 裝備(1)
        INVEN_EQUIP2 = 0x67,// 封印物(2)
        INVEN_SPEND3 = 0x68,// 消耗(3)
        INVEN_OTHER4 = 0x69,// 其他(4)
        INVEN_PET5 = 0x6A,  // 寵物(5)
        INVEN_MONEY = 0x6B, // 錢

        INVEN_SELECTSLOT_ACK = 0x6E,

        INVEN_USESPEND_START = 0x71,
        INVEN_USESPEND_END = 0x72,
        SKILL_ALL = 0x73,

        SKILL_LEVELUP_ACK = 0x75,

        // 0x77,
        // 0x78
        QUEST_ALL = 0x79,
        QUEST_UPDATE = 0x80,

        MESSAGE = 0x84,

        CAN_WARP_ACK = 0x86,
        // 0x87
        CONDITION_CLEAR = 0x88,

        // 0x92
        TRADE_INVITE = 0x92,
        TRADE_INVITE_RESPONSES = 0x93,
        TRADE_READY = 0x94,
        TRADE_CONFIRM = 0x95,
        TRADE_CANCEL = 0x96,
        TRADE_FAIL = 0x97,
        TRADE_SUCCESS = 0x98,
        TRADE_PUT = 0x9A,
        PARTY_INVITE = 0x9B,
        PARTY_INVITE_RESPONSES = 0x9C,
        PARTY_UPDATE = 0x9D,

        // 0xA0 // 離開隊伍
        PARTY_HP_UPDATE= 0xA1,
        PARTY_DISMISS = 0xA2,

        PVP_REQ = 0xA4,
        PVP_ACK = 0xA5,
        PVP_START = 0xA6,
        PVP_END = 0xA7,

        QUICKSLOTALL = 0xA9,
        STORE_INFO = 0xAA,
        STORE_MONEYINFO = 0xAB,
        // 0xAC
        // 0xAD

        // 0xB0
        // 0xB1
        // 0xB2

        // 0xB4
        // 0xB5

        LOGOUT_ACK = 0xC9,

        PSHOP_OPENACK = 0xCE,

        PSHOP_SELLSTARTACK = 0xD0,
        PSHOP_SELLEND = 0xD1,
        PSHOP_SELLINFO = 0xD2,

        PSHOP_INFOACK = 0xD4,

        PSHOP_BUYACK = 0xD6,

        EVENTITEM_ACK = 0xD9,

        ALIVE_CHECK = 0xDE,

        FISH_ACK = 0xE1,

        TAROT_ACK = 0xE3,

        INVEN_CASH = 0xE6,

        CASH_BUY_ACK = 0xE8,

        CASH_GIFT_ACK = 0xEA,

        CASH_TO_INVEN_ACK = 0xF0,

        CASH_GUIHONCASH = 0xF2,
        CASH_MGAMECASH_ACK = 0xF3,

        CASH_INVENTOCASHSTORE_ACK = 0xF5,

        INVEN_USESPEND_SHOUT_ACK = 0xFB,

        CASH_CHECKCHARNAME_ACK = 0xFD,

        // 0xFF // 物品賣出
        SERVER_CHAR_SHOWINFO = 0x100,

        PET_NAME_ACK = 0x102,
        PET_LEVUP = 0x103,

        PET_DIE = 0x105,
        PET_HP = 0x106,
        PET_LIFE = 0x107,
        PET_LIFE_END = 0x108,

        BOPEA_ACK = 0x11B,
        T_CHAT = 0x11C,

        // 0x11E
        CASHSHOPLIST1_ACK = 0x11F,
        CASHSHOPLIST2_ACK = 0x120,
        CASHSHOPLIST3_ACK = 0x121,
        CASHSHOPLIST4_ACK = 0x122,
        CASHSHOPLIST5_ACK = 0x123,
        CASHSHOPLIST6_ACK = 0x124,
        CASHSHOPLIST7_ACK = 0x125,
        CASHSHOPLIST8_ACK = 0x126,
        CASHSHOPLIST9_ACK = 0x127,

        PET_SELL_ACK = 0x12A,

        GIFT_STORE = 0x12C,

        // 0x12E,

        // 0x130

        // 0x132

        // 0x134

        // 0x138
        // 0x139

        MINING_ACK = 0x13B,

        MINE_CHANGE_ACK = 0x13D,

        UPGRADE_ITEM_ACK = 0x13F,

        // 0x142

        PETRIDE_ACK = 0x144,
        // 0x145

        UPGRADE_ACCITEM_ACK = 0x147,

        // 0x149
        // 0x14A
        // 0x14B
        // 0x14C
        // 0x14D

        // 0x14F,

        // 0x151,

        // 0x153,

        ENTRY_FW_ACK = 0x158,

        ENTRY_FWINSERT_ACK = 0x15A,

        ENTRY_FWDELETE_ACK = 0x15C,

        ENTER_FW_ACK = 0x15E,
        FW_MANAGER = 0x15F,
        FW_START = 0x160,
        FW_END = 0x161,
        FW_POINTUP = 0x162,
        FW_RESULT = 0x163,
        FW_DISCOUNTFACTION = 0x164,
        FW_SERVERTIME = 0x165,
        FW_MYSTATE = 0x166,
        FW_USERSTATE = 0x167,

        CHANGE_CHARNAME_ACK = 0x169,

        // 0x16D
        // 0x16E

        CHAR_REFLECTION = 0x170,

        // 0x173

        // 0x175
        // 0x176

        MOB_REFLECT = 0x178,

        // 0x17A
        // 0x17B
        CHAR_SKILL_10110 = 0x17C,
        CHAR_SKILL_10408 = 0x17D,
        CHAR_SKILL_10409 = 0x17E,
        CHAR_SKILL_10410 = 0x17F,
        CHAR_SKILL_31402 = 0x180,
        CHAR_SKILL_32402 = 0x181,

        PUZZLE = 0x183,
        PUZZLE_UPDATE = 0x184,
        // 0x185
        // 0x186
        // 0x187
        // 0x188

        CHAR_GOD = 0x18B,
        CHAR_HEALING = 0x18C,

        CHAR_SHADOW = 0x194,

        // 0x197
        COMMITSHOP = 0x198,

        COMMITSHOP_OPEN_ACK = 0x19D,

        COMMITSHOP_SELLSTART_ACK = 0x19F,

        COMMITSHOP_SELLEND = 0x1A0,
        COMMITSHOP_SELL_INFO_ACK = 0x1A1,

        COMMITSHOP_INFO_ACK = 0x1A3,

        COMMITSHOP_BUY_ACK = 0x1A5,

        CHAR_MAX_SPHP_PLUS = 0x1A7,
        CW_PLAYSTATE = 0x1A8,
        PW_PLAYSTATE = 0x1A9,

        // 0x1AA

        IDENTIFY_ACK = 0x1AD,
        FREE_WARPLIST = 0x1AE,

        BADUSERCHECKSTATE = 0x1B0,
        TOY_LEVUP = 0x1B1,

        TOY_LIFE = 0x1BA,
        TOY_LIFE_END = 0x1BB,
        // 0x1BC
        // 0x1BD

        EXCHANGE_ACK = 0x1C0,

        // 0x1C2

        // 0x1C5

        // 0x1C7

        // 0x1C9

        // 0x1CB
        // 0x1CC
        // 0x1CD,

        OXSYSTEM_MANAGER = 0x1CF,

        OXSYSTEM_QUESTION_ACK = 0x1D1,
        OXSYSTEM_ANSWER = 0x1D2,
        OXSYSTEM_RESULT = 0x1D3,

        // 0x1D6
        CHAR_SKILL_餌熱 = 0x1D7,
        // 0x1D9

        // 0x1DA
        stInDunMessage = 0x1DB,
        stInDunStageEffect = 0x1DC,
        stInDunTimer = 0x1DD,
        stIndunEnterAck = 0x1DF,

        JERYUNG_BIGHIT = 0x1E1,

        // 0x1E4

        // 0x1E6

        // 0x1E8

        // 0x1EA

        // 0x1EC

        // 0x1EE

        // 0x1F0
        // 0x1F1

        // 0x1F3
        COUPLE_EFEECT_ENTERWARP = 0x1F4,
        COUPLE_EFEECT_ALLUSER = 0x1F5,

        // 0x1F7
        // 0x1F8
        // 0x1F9
        EX_USER_CREATE = 0x1FA,

        NOTICE_BOARD_STATE = 0x1FC,

        SOULSTACKWAR_CREATE_ROOM_ACK = 0x201,
        SOULSTACKWAR_REQUEST = 0x202,

        SOULSTACKWAR_CREATE_CHALLENGE_ACK = 0x204,

        SOULSTACKWAR_STATE = 0x206,

        SOULSTACKWAR_TIME = 0x207,

        SOULSTACKWAR_ITEM_USE_ACK = 0x209,
        SOULSTACKWAR_FINISH = 0x20A,

        SOULSTACKWAR_RANKING_ACK = 0x20C,

        SOULSTACKWAR_READY = 0x212,
    }

    public enum MessengerServerOpcode : ushort
    {
        MSG_GAMELOG = 0x0B,
        FRIEND_LIST = 0x49,
        FRIEND_ADD = 0x4C,
        FRIEND_ONLINE = 0x4F,
    }
}