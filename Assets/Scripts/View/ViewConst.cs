﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewConst {
    public const string Click_Pass = "Click_Pass";
    public const string Click_Tip = "Click_Tip";
    public const string Click_Reset = "Click_Reset";
    public const string Click_Discard = "Click_Discard";
    public const string Click_CallLandlord = "Click_CallLandlord";
    public const string Click_NotCall = "Click_NotCall";
    public const string Click_Claim = "Click_Claim";
    public const string Click_NotClaim = "Click_NotClaim";
    public const string Click_StartGame = "Click_StartGame";
    public const string Click_Match = "Click_Match";
    public const string Click_Quit = "Click_Quit";
    public const string Click_PVE = "Click_PVE";
    public const string Click_ViewResult = "Click_ViewResult";
    public const string Click_CancelMatch = "Click_CancelMatch";
    public const string Click_UpdateRoomList = "Click_UpdateRoomList";
    public const string Click_CreateRoom = "Click_CreateRoom";
    public const string Click_JoinRoom = "Click_JoinRoom";
    public const string Click_LeaveRoom = "Click_LeaveRoom";
    public const string Click_ReturnLobby = "Click_ReturnLobby";
    public const string Click_ContinueGame = "Click_ContinueGame";
    public const string Click_Login = "Click_Login";
    public const string Click_RegisterOK = "Click_RegisterOK";
    public const string TimeOut = "TimeOut";
    public const string RemoveAllDiscards = "RemoveAllDiscards";
    public const string Click_DisSelectCard = "Click_DisSelectCard";
    public const string Click_SelectCard = "Click_SelectCard";
    public const string ShowDiscards = "ShowDiscards";
    public const string ShowPlayer2Msg = "ShowPlayer2Msg";
    public const string ShowPlayer3Msg = "ShowPlayer3Msg";
    public const string ShowPlayer4Msg = "ShowPlayer4Msg";
    public const string UpdatePlayer2Cards = "UpdatePlayer2Cards";
    public const string UpdatePlayer3Cards = "UpdatePlayer3Cards";
    public const string UpdatePlayer4Cards = "UpdatePlayer4Cards";
    public const string ShowBaseCards_Back = "ShowBaseCards_Back";
    public const string ShowBaseCards_Value = "ShowBaseCards_Value";
    public const string ShowBaseCards_Chong = "ShowBaseCards_Chong";
    public const string ShowDiscardMsg = "ShowDiscardMsg";
    public const string DiscardSuccess = "DiscardSuccess";
    public const string ShowHandCards = "ShowHandCards";
    public const string DiscardFail = "DiscardFail";
    public const string ChangeOptionMenuMode = "ChangeOptionMenuMode";
    public const string UpdateStatus_Base = "UpdateStatus_Base";
    public const string Update_Message = "Update_Message";
    public const string UpdateStatus_Mutiple = "UpdateStatus_Mutiple";
    public const string UpdateStatus_SeYangTip = "UpdateStatus_SeYangTip";
    public const string UpdateStatus_TitleTip = "UpdateStatus_TitleTip";
    public const string UpdateStatus_OpenDoors = "UpdateStatus_OpenDoors"; 
    public const string UpdateCount_MatchPlayers = "UpdateCount_MatchPlayers";
    public const string SwitchTimer_Player1 = "SwitchTimer_Player1";
    public const string SwitchTimer_Player2 = "SwitchTimer_Player2";
    public const string SwitchTimer_Player3 = "SwitchTimer_Player3";
    public const string SwitchTimer_Player4 = "SwitchTimer_Player4";
    public const string ShowMatchSuccessMsg = "ShowMatchSuccessMsg";
    public const string UpdatePlayerSelfName = "UpdatePlayerSelfName";
    public const string UpdatePlayerSelfIdentiy = "UpdatePlayerSelfIdentiy";
    public const string UpdatePlayer2Identiy = "UpdatePlayer2Identiy";
    public const string UpdatePlayer3Identiy = "UpdatePlayer3Identiy";
    public const string UpdatePlayer4Identiy = "UpdatePlayer4Identiy";
    public const string UpdatePlayer2Name = "UpdatePlayer2Name";
    public const string UpdatePlayer3Name = "UpdatePlayer3Name";
    public const string UpdatePlayer4Name = "UpdatePlayer4Name";
    public const string UpdatePlayerSelfIMG = "UpdatePlayerSelfIMG";
    public const string UpdatePlayer2IMG = "UpdatePlayer2IMG";
    public const string UpdatePlayer3IMG = "UpdatePlayer3IMG";
    public const string UpdatePlayer4IMG = "UpdatePlayer4IMG";
    public const string UpdatePlayerSelfGrade = "UpdatePlayerSelfGrade";
    public const string UpdateGameOverResult = "UpdateGameOverResult";
    public const string ShowTipsCards = "ShowTipsCards";
    public const string UpdateWinCards1 = "UpdateWinCards1";
    public const string UpdateWinCards2 = "ShowTipsCards2";
    public const string UpdateWinCards3 = "ShowTipsCards3";
    public const string UpdateWinCards4 = "ShowTipsCards4";
    public const string ShowChongCards1 = "ShowChongCards1";
    public const string ShowChongCards2 = "ShowChongCards2";
    public const string ShowChongCards3 = "ShowChongCards3";
    public const string ShowChongCards4 = "ShowChongCards4";
    public const float CardDelay = 0.3f;
    public const float MsgClearDelay = 3f;
}
public class StringJianConst
{
    public const string CallLandlord = "叫地主";
    public const string NotCall = "不叫";
    public const string Claim = "抢地主";
    public const string NotClaim = "不抢";
    public const string Pass = "要不起";
    public const string Matching = "匹配中...";
    public const string RegisterPlease = "请先注册再匹配...";
    public const string Replaying = "退出按[返回大厅]\r\n继续按[继续游戏],等待牌友返回...";
    public const string MatchSuccess = "游戏加载中...";
    public const string Win = "你赢了！";
    public const string Lose = "你输了！";
    public const string Computer1 = "马湘兰";
    public const string Computer2 = "陈圆圆";
    public const string Computer3 = "柳如是";
    public const string Guest = "云游道人";
    public const string LoginPwdError = "密码不正确,请确认并重新输入！";
    public const string LoginUserError = "该用户名不存在,请确认并重新输入！";
    public const string RegAlready = "该用户名已被注册,请重新输入用户名称！";
    public const string UserRegAlready = "该用户名已被注册,请重新输入用户名称！";
    public const string UserRegError = "用户名称及密码格式有误,请重新注册！";
    public const string RegUserNull= "该用户名已被注册,请重新输入用户名称！";
    public const string RegPwdNull = "该用户名已被注册,请重新输入用户名称！";
    public const string RegPwdError = "用户名称及密码格式有误,请重新注册！";
    public const string CatchErr = "閒家無紅萬千僧不能捉閒家牌\r\n 閒家捉閒家牌稱為掛立\r\n掛立后萬千不能首發提出!";
    public const string MieShiOrder = "灭牌时应优先灭去十字门青张!";
    public const string MieShengOrder = "灭牌时应优先灭去生门青张!";
    public const string Flower3Not = "萬千百三花落盡之前,十子為禁門,不能出";
    public const string WuShangGaoBai = "手上無賞無百老,不能先發十子";
    public const string LordFirst = "莊家已發牌後，不能發十告百";
    public const string TwoDoorOpen = "兩路正門已出牌後，不能發十告百 ";
    public const string TiJinWanQian = "紅萬千僧雙持，不能首發全提上桌";
    public const string DaoTiQianWan = "紅萬千僧雙持，不能先出千僧  ";
    public const string ChuangQian = "千僧必須留守捉牌，不能擅自首發";
    public const string TiWan5Zhuo = "第5桌不能出紅萬";
    public const string JiZhuoTiWan = "急捉立紅萬千僧之後不能再首發提出";
    public const string KaiSan = "閒家應優先出正門，需避免偷肩上趣時再開三門";
    public const string Zhuang = "(庄)";
    public const string Diao = "吊 ";
    public const string QiaoMen = "散家敲门:";
    public const string Zhu = "注  ";
    public const string ZhuHe = "注『贺』  ";
    public const string FoChiJiao = "百万 佛赤脚  -5贺";
    public const string TheWinner = "本局赢家：";
    public const string MultiWinner = "多人同筹 ";
    public const string LianZhuang = "连庄";
    public const string ThisJifen = "  本局得筹： ";
    public const string TotalJifen = "注  总筹：";
    public const string ConvertMadiao = "转换为马吊名称:";
    public const string GetSeyang = "赢得色样:";
    public const string Start = "开始";
    public const string Register = "注册";
    public const string Match = "玩家对战PVP";
    public const string PVE = "人机对战PVE";
    public const string Teach = "马吊游戏教学";
    public const string Setting = "设置";
    public const string Quit = "退出游戏";
    public const string NickName = "昵称:";
    public const string JifenName = "银两";
    public const string HeadPicName = "头像";
    public const string MsgIP = "服务器IP设置";
    public const string Port = "端口";
    public const string NameTitle = "用户名:";
    public const string PwdTitle =  "密  码:";
    public const string RepeatPwdTitle = "重复密码:";
    public const string InputName = "请输入用户名...";
    public const string InputPwd = "请输入密码...";
    public const string RepeatPwd = "再次输入密码...";
    public const string TipDiscard = "提示";
    public const string DiscardCard = "出牌";
    public const string ReturnLobby = "回大厅";
    public const string CountinueGame = "继续战";
    public const string MultiBase = "倍数:";
    public const string BaseGold = "银两:";
    public const string OpenDoors = "熟门:";
    public const string TipSeyang = "色样:";
    public const string TipQiShou = "起手:";
    public const string TipKanChong = "看冲:";
    public const string TipDiserror = "错误:";
}

public class MDNameJianConst { 
    public const string Wen9 = "九文";
    public const string Wen8 = "八文";
    public const string Wen7 = "七文";
    public const string Wen6 = "六文";
    public const string Wen5 = "五文";
    public const string Wen4 = "四文";
    public const string Wen3 = "三文";
    public const string Wen2 = "二文";
    public const string Wen1 = "一文";    
    public const string WenHua = "枝花";
    public const string WenKong = "空文";

    public const string Suo = "索";
    public const string Guan = "贯";
    public const string Nine = "九";
    public const string Eight = "八";
    public const string Seven = "七";
    public const string Six = "六";
    public const string Five = "五";
    public const string Four = "四";
    public const string Three = "三";
    public const string Two = "二";
    public const string One = "一";

    public const string WanWan = "万万";
    public const string QianWan = "千万";
    public const string BaiWan = "百万";
    public const string JiuShi = "九十万";
    public const string BaShi = "八十万";
    public const string QiShi = "七十万";
    public const string LiuShi = "六十万";
    public const string WuShi = "五十万";
    public const string SiShi = "四十万";
    public const string SanShi = "三十万";
    public const string ErShi = "二十万";

    public const string Shang = "赏 ";
    public const string Jian = "肩 ";
    public const string Ji = "极 ";
    public const string Fuji = "副极 ";
    public const string Zha = "杂";
    public const string SingleItem = "单项";
}

public class CardsTypeMdJian
{
    public const string Single = "单张";
    public const string Mussy = "杂牌";
    //public const string Straight = "顺子";
    //public const string DoubleStraight = "连对";
    //public const string TripleStraight = "飞机";
    //public const string Double = "对子";
    //public const string Triple = "三张";
    //public const string TriplePlusOne = "三带一";
    //public const string TriplePlusDouble = "三带一对";
    //public const string QuartePlusTwo = "四带二";
    //public const string QuartePlusDouble = "四带二对";
    //public const string PlanePlusWings = "飞机带翅膀";
    //public const string Bomb = "炸弹";
    //public const string Rocket = "火箭";//王炸
    public static int ISHUNFENGQI = 3;
    public static int IXIANGLUJIAO = 5;
    public static int IZHUOJI = 1;

    public static string FirstWin = "(首出)";
    public static string LastWin = "(尾出)";
    public static string Shang = "赏";
    public static string Jian = "肩";
    public static string Ji = "极";
    public static string Bai = "百";
    public static string Hong = "红";
    public static string Fujian = "副肩";
    public static string Fuji = "副极";

    public static string Citu = "雌突";
    public static string XiaoTu = "小突";
    public static string SiBai = "死突";
    public static string SiBaiTu = "死百突";
    public static string XiaoHuoBai = "小活百";
    public static string XiaoHuoBaiTu = "小活百突";
    public static string DaHuoBai = "大活百";
    public static string DaHuoBaiTu = "大活百突";
    public static string QuanTuDaHuo = "全突大活";

    public static string TianDiJiaoTai = "天地交泰";
    public static string RenJieDiLing = "人杰地灵";
    public static string TianRenHeYi = "天人合一";
    public static string JiQuanSehngTian = "鸡犬升天";
    public static string JinYuanYang = "锦鸳鸯";
    public static string AoYuanYang = "拗鸳鸯";
    public static string QiHongZuiYangFei = "七红醉杨妃";
    public static string Jjjin = "片片锦";
    public static string QiLingZhong = "麒麟种";
    public static string FengHuangChu = "凤凰雏";
    public static string XueZhongTan = "雪中炭";
    public static string LiuHong = "六红";
    public static string QiHong = "七红";
    public static string BaHong = "八红";
    public static string ShunFengLiuHong = "六红顺风旗";
    public static string ShunFengQiHong = "七红顺风旗";
    public static string ShunFengBaHong = "八红顺风旗";
    public static string QiShun = "七连同花顺";
    public static string BaShun = "八连同花顺";
    public static string QiTong = "七同";
    public static string BaTong = "八同";
    public static string BaDa = "八大";
    public static string BaXiao = "八小";
    public static string BaYao = "八幺";


    public static string HuangHuiTu = "皇会图";
    public static string QianJunZhu = "千钧柱";
    public static string HuaDuDou = "花肚兜";
    public static string HuaBiJian = "花比肩";
    public static string QiaoSiShang = "巧四赏";
    public static string QiaoSiJian = "巧四肩";
    public static string TianDiFen = "天地分";
    public static string XiaoTianDiFen = "小天地分";
    public static string JianTianDiFen = "肩天地分";
    public static string BaiChangJian = "百长肩";
    public static string BaiDuanJian = "百短肩";
    public static string JiChangJian = "极长肩";
    public static string JiDuanJian = "极短肩";
    public static string DuiJian = "对肩";
    public static string ChangJian = "长肩";
    public static string DuanJian = "短肩";
    public static string BaiJiSiJian = "百极四肩";
    public static string BaiJiSiShang = "百极四赏";
    public static string BaiJianSiJi = "百肩四极";
    public static string BaiShangBaiJi = "百赏百极";
    public static string JieJieGao = "节节高";
    public static string BaiJiYuBei = "百鲫鱼背";
    public static string JianJiYuBei = "肩鲫鱼背";
    public static string ShangJiYUBei = "赏鲫鱼背";
    public static string SanQingYuJi = "三清御极";
    public static string TongQiLianZhi = "义结金兰";

    //斗上杂色样
    public static string NeiShengWaiWang = "内聖外王";
    public static string TianRanQu = "天然趣";
    public static string FeiLaiQu = "飞来趣";
    public static string NvDiDengJi = "女帝登基";
    public static string SanDieQu = "三叠趣";
    public static string LongMenYue = "龙门跃";
    public static string FoDingZhu = "佛顶珠";
    public static string SanHuaTianNv = "散花天女";
    public static string TianNvSanHua = "天女散花";
    public static string ZhuoJiXianBai = "一枝花";
    public static string ZhuoJiXianJi = "捉极献极";
    public static string GongSunDuiZuo = "公孙对座";
    public static string FuZiTongDeng = "父子同登";
    public static string XiongDiQiXin = "兄弟齐心";
    public static string SanDaiRongFeng = "三代荣封";
    public static string ShunFengQi = "顺风旗";
    public static string XiangLuJiao = "香炉脚";
    public static string YuanyangDing = "鴛鴦鼎";    
    public static string YuwangDing = "禹王鼎";
    public static string WenwangDing = "文王鼎";    
    public static string ZhuShaDing = "朱砂鼎";
    public static string TieXiangLu = "铁香炉";
    public static string ShuangFeiQu = "双飞趣";
    public static string GuoQiaoLong = "过桥龙";
    public static string QuHouBai = "趣后百";
    public static string BaiHouQu = "百后趣";
    public static string ShuangQuHou = "双趣后";
    public static string ShuangBaiHou = "双百后";
    public static string DaoJuanLian = "倒卷帘";
    public static string JuanLianFei = "卷帘飞";
    public static string HuangDaoJuan = "美人卷帘";
    public static string BaQuan = "八全";
    public static string LiuDiao = "六桌吊";
    public static string QiDiao = "七桌吊";
    public static string JingZhongRen = "镜中人";
    public static string JieHuaXianFo = "借花献佛";
    public static string FuQiTuanYuan = "夫妻团圆";
    public static string RenMianTaoHua = "人面桃花";
    public static string MeiNvCanChan = "美女参禅";
    public static string XiaoCanChan = "小参禅";
    public static string ErFoTanJing = "二佛谈经";
    public static string TianXianSongZi = "天仙送子";
    public static string GongLingSun = "公领孙";
    public static string FuLuShouXi = "福禄寿喜";
    public static string FourJian = "四肩在手";
    public static string LianHuanSuo = "连环索";
    public static string DaLianHuanSuo = "五弦连环索";
    public static string QingBaiRenJia = "青云平步";


    //冲成色样
    public static string ShiHongJuHui = "十红聚会";
    public static string ShiHongZuiYangFei = "十红醉杨妃";
    public static string JiuHong = "九红";
    public static string QuanHongZuiYangFei = "全红醉杨妃";
    public static string JiuHongZuiYangFei = "九红醉杨妃";
    public static string BaHongZuiYangFei = "八红醉杨妃";
    public static string JiuTong = "九同";
    public static string ShiTong = "十同";
    public static string JiuLianHuan = "九连环";
    public static string ShiLianHuan = "顺天一统";
    public static string QianShiQuanMen = "钱十全门";
    public static string GuanSuoQuanMen = "贯索全门";
    public static string TaiJiTu = "太极图";
    public static string YuanYangQiTong = "鸳鸯七同";
    public static string LianHuanQiTong = "连环七同";
    public static string JinJueZang = "金掘藏";
    public static string YinJueZang = "银掘藏";
    public static string YiChuoLiu = "一戳六";
    public static string YiChuoQi = "一戳七";
    public static string YinHua = "印花";

    public static string ShangXJian = "赏冲肩";
    public static string ShangXQu = "赏冲趣";
    public static string ShangXQing = "赏冲青";
    public static string JianXShang = "肩冲赏";
    public static string QuXShang = "趣冲赏";
    public static string QuXFuqu = "趣冲副趣";
    public static string QuXQing = "趣冲青";
    public static string QuXJian = "趣冲肩";
    public static string XiongdiX = "兄弟冲";
    public static string JuanLianX = "卷帘冲";

}

public class StringFanConst
{
    public const string CallLandlord = "叫地主";
    public const string NotCall = "不叫";
    public const string Claim = "搶地主";
    public const string NotClaim = "不搶";
    public const string Pass = "要不起";
    public const string Matching = "匹配中...";
    public const string RegisterPlease = "請先注冊再匹配...";
    public const string Replaying = "退出按[返回大廳]\r\n繼續按[繼續遊戲],等待牌友返回...";
    public const string MatchSuccess = "遊戲加載中...";
    public const string Win = "你贏了！";
    public const string Lose = "你輸了！";
    public const string Computer1 = "馬湘蘭";
    public const string Computer2 = "陳圓圓";
    public const string Computer3 = "柳如是";
    public const string Guest = "雲遊道人";
    public const string LoginPwdError = "密碼不正確,請確認並重新輸入！";
    public const string LoginUserError = "該用戶名不存在,請確認並重新輸入！";
    public const string RegAlready = "該用戶名已被注冊,請重新輸入用戶名稱！";
    public const string UserRegAlready = "該用戶名已被注冊,請重新輸入用戶名稱！";
    public const string UserRegError = "用戶名稱及密碼格式有誤,請重新注冊！";
    public const string RegUserNull = "該用戶名已被注冊,請重新輸入用戶名稱！";
    public const string RegPwdNull = "該用戶名已被注冊,請重新輸入用戶名稱！";
    public const string RegPwdError = "用戶名稱及密碼格式有誤,請重新注冊！";
    public const string CatchErr= "當莊家已出牌,且由未正本閒家佔大時\r\n無紅萬千僧的另一閒家不能加捉,否則犯急捉\r\n 閒家有萬或千急捉稱為掛立\r\n掛立后萬千不能首發提出!";
    public const string MieShiOrder = "滅牌時應優先滅盡十字門青張(黑色)!\r\n滅牌次序為十子-生門-趣張-熟門\r\n馬弔玩法不作任何強制限制\r\n但有很多賠例,違反將包賠他人損失";
    public const string MieShiByShi = "發十時，有多張十子青張應滅十子\r\n只有一張十子應滅其他牌";
    public const string MieShengOrder = "應先滅生門青張(黑色),留一張防緑趣即可!\r\n生門指莊家首次首發的非十字門\r\n或閒家首發兩門牌以外的第三門\r\n即兩路正門以外的另一种非十字門";
    public const string MieShiOnlyOne = "發十時不要滅盡手上孤十\r\n 須提防下一牌二十萬上桌";
    public const string MieErrHave20 = "有二十萬在手，滅牌時不能留十子門青張";
    public const string MieErrLastShi = "千僧百老已現身，有十子須留下剋制大參禪 天女散花";
    public const string MieErrQian = "千僧為留守之員，百萬和二十萬未全部現身不能滅千\r\n 紅萬在千僧 百老現身前不能滅去\r\n 紅萬 千僧 百老 順風旗在手可以首發其二\r\n仍須提防二十萬上桌";
    public const string Flower3Not = "萬千百三花落盡之前,十子為禁門,不能首發打出\r\n 告百發十 關真鬥十 關賞鬥十 除外\r\n 告百發十 ——手上有百有賞、莊家未出新花色、閒家出過少於兩門花色\r\n 關賞鬥十——只剩十字門和另一門，且該門有賞無肩、有肩以下牌\r\n 關真鬥十——手上只有一張十字門以外的牌，且場上已無牌能大過此牌";
    public const string WuShangGaoBai = "手上無賞無百老,萬千百現身前不能首發十子\r\n三花落盡————萬萬 千萬 百萬全部現身 ";
    public const string LordFirst = "莊家發牌後，不能發十告百\r\n告百發十 關真鬥十 關賞鬥十 除外\r\n 告百發十 ——手上有百有賞、莊家未出花色、閒家出過少於兩門花色\r\n 關賞鬥十——只剩十字門和另一門，且該門有賞無肩、有肩以下牌\r\n 關真鬥十——手上只有一張十字門以外的牌，且場上已無牌能大過此牌";
    public const string TwoDoorOpen = "兩路正門已確定後，不能發十告百 \r\n告百發十 關真鬥十 關賞鬥十 除外\r\n 告百發十 ——手上有百有賞、莊家未出花色、閒家出過少於兩門花色\r\n 關賞鬥十——只剩十字門和另一門，且該門有賞無肩、有肩以下牌\r\n 關真鬥十——手上只有一張十字門以外的牌，且場上已無牌能大過此牌";
    public const string TiJinWanQian = "紅萬千僧雙持，不能首發全提上桌 \r\n 需提防二十萬 百萬上桌";
    public const string DaoTiQianWan = "紅萬千僧雙持，不能先出千僧\r\n會被誤認為報百";
    public const string ChuangQian = "千僧為留守之員，不能擅自首發\r\n千僧通常只能在第8桌發出\r\n紅萬現身,手上剩千僧和一張非十字牌,可第7桌出千";
    public const string TiWan5Zhuo = "第5桌不能首發紅萬，需提防大參禪、天女散花等色樣";
    public const string JiZhuoTiWan = "閒家捉閒家青張時，被視為手上有紅萬或千僧\r\n此舉稱為立萬掛千\r\n掛立之後紅萬千僧不能再首發提出";
    public const string KaiSan = "閒家應優先出正門，需避免偷肩上趣時再開三門\r\n 莊家首次發出的非十字門花色為莊門\r\n或閒家先發過牌的兩種花色為正門、熟門\r\n 莊門或正門以外的另外一種非十子花色都是生門\r\n出牌次序為正門 三門 十子";
    public const string LastOneSuit = "不能將原門發盡，本門極未現身前，有責任防範極上桌\r\n 閒家首次發出的正門為原門";
    public const string Zhu = "注  ";
    public const string Chong = "衝  ";
    public const string Zhuang = "『莊』";
    public const string Diao = "弔 ";
    public const string QiaoMen = "散家敲門:";    
    public const string ZhuHe = "注『賀』  ";
    public const string FoChiJiao = "佛赤腳";
    public const string TheWinner = "本局贏家：";
    public const string MultiWinner = "多人同籌 ";
    public const string LianZhuang = "連莊";
    public const string ThisJifen = "  得籌： ";
    public const string TotalJifen = "  總籌：";
    public const string ConvertMadiao = "轉換爲馬吊名稱:";
    public const string GetSeyang = "贏得色樣:";
    public const string Start = "開始";
    public const string Register = "注冊";
    public const string Match = "玩家對戰PVP";
    public const string PVE = "人機對戰PVE";
    public const string Teach = "馬弔遊戲教學";
    public const string Setting = "設定";
    public const string MsgIP = "伺服器IP設定";
    public const string Port = "端口";
    public const string Quit = "退出遊戲";
    public const string NickName = "昵稱:";
    public const string JifenName = "銀兩:";
    public const string HeadPicName = "頭像:";
    public const string NameTitle = "用戶名:";
    public const string PwdTitle =  "密  碼:";
    public const string RepeatPwdTitle = "重複密碼:";
    public const string InputName = "請輸入用戶名...";
    public const string InputPwd = "請輸入密碼...";
    public const string RepeatPwd = "再次輸入密碼...";
    public const string TipDiscard = "提示";
    public const string DiscardCard = "出牌";
    public const string ReturnLobby = "回大廳";
    public const string CountinueGame = "繼續戰";
    public const string MultiBase  = "倍數:";
    public const string BaseGold = "銀兩:";
    public const string OpenDoors = "熟門:";
    public const string TipSeyang = "色樣:";
    public const string TipQiShou = "起手:";
    public const string TipKanChong = "看衝:";
    public const string TipDiserror = "錯誤:";
    public const string TestVersion = "伺服器暫未上綫,目前僅支持PVE單機模式";
    //public const string TestVersion = "";
}

public class MDNameFanConst
{
    public const string Wen9 = "九文";
    public const string Wen8 = "八文";
    public const string Wen7 = "七文";
    public const string Wen6 = "六文";
    public const string Wen5 = "五文";
    public const string Wen4 = "四文";
    public const string Wen3 = "三文";
    public const string Wen2 = "二文";
    public const string Wen1 = "一文";
    public const string WenHua = "枝花";
    public const string WenKong = "空文";

    public const string Suo = "索";
    public const string Guan = "貫";
    public const string Wen = "文";
    public const string Shi = "十";
    public const string Nine = "九";
    public const string Eight = "八";
    public const string Seven = "七";
    public const string Six = "六";
    public const string Five = "五";
    public const string Four = "四";
    public const string Three = "三";
    public const string Two = "二";
    public const string One = "一";

    public const string WanWan = "萬萬";
    public const string QianWan = "千萬";
    public const string BaiWan = "百萬";
    public const string JiuShi = "九十萬";
    public const string BaShi = "八十萬";
    public const string QiShi = "七十萬";
    public const string LiuShi = "六十萬";
    public const string WuShi = "五十萬";
    public const string SiShi = "四十萬";
    public const string SanShi = "三十萬";
    public const string ErShi = "二十萬";

    public const string Shang = "賞 ";
    public const string Jian = "肩 ";
    public const string Ji = "極 ";
    public const string Fuji = "副極 ";
    public const string Zha = "雜";
    public const string SingleItem = "單項";
}

public class CardsTypeMdFan
{
    public const string Single = "單張";
    public const string Mussy = "雜牌";
    //public const string Straight = "順子";
    //public const string DoubleStraight = "連對";
    //public const string TripleStraight = "飛機";
    //public const string Double = "對子";
    //public const string Triple = "三張";
    //public const string TriplePlusOne = "三帶一";
    //public const string TriplePlusDouble = "三帶一對";
    //public const string QuartePlusTwo = "四帶二";
    //public const string QuartePlusDouble = "四帶二對";
    //public const string PlanePlusWings = "飛機帶翅膀";
    //public const string Bomb = "炸彈";
    //public const string Rocket = "火箭";//王炸
    public static int ISHUNFENGQI = 3;
    public static int IXIANGLUJIAO = 5;
    public static int IZHUOJI = 1;

    public static string FirstWin = "(首上) ";
    public static string LastWin = "(尾上) ";
    public static string Shang = "賞";
    public static string Jian = "肩";
    public static string Ji = "極";
    public static string Bai = "百";
    public static string Hong = "紅";
    public static string Fujian = "副肩";
    public static string Fuji = "副極";

    public static string Citu = "雌突";
    public static string XiaoTu = "小突";
    public static string DiaoBai = "吊百";
    public static string SiBaiTu = "死百突";
    public static string ZhengBenBai = "正本百";
    public static string XiaoHuoBaiTu = "小活百突";
    public static string DaHuoBai = "大活百";
    public static string DaHuoBaiTu = "大活百突";
    public static string QuanTuDaHuo = "全突大活";

    public static string TianDiJiaoTai = "天地交泰";
    public static string RenJieDiLing = "人傑地靈";
    public static string TianRenHeYi = "天人合一";
    public static string JiQuanSehngTian = "鷄犬升天";
    public static string JinYuanYang = "錦鴛鴦";
    public static string AoYuanYang = "拗鴛鴦";
    public static string QiHongZuiYangFei = "七紅醉楊妃";
    public static string Jjjin = "片片錦";
    public static string QiLingZhong = "麒麟種";
    public static string FengHuangChu = "鳳凰雛";
    public static string XueZhongTan = "雪中炭";
    public static string LiuHong = "六紅";
    public static string QiHong = "七紅";
    public static string BaHong = "八紅";
    public static string ShunFengLiuHong = "六紅順風旗";
    public static string ShunFengQiHong = "七紅順風旗";
    public static string ShunFengBaHong = "八紅順風旗";
    public static string QiShun = "七連同花順";
    public static string BaShun = "八連同花順";
    public static string QiTong = "七同";
    public static string BaTong = "八同";
    public static string BaDa = "八大";
    public static string BaXiao = "八小";
    public static string BaYao = "八幺";


    public static string HuangHuiTu = "皇會圖";
    public static string QianJunZhu = "千鈞柱";
    public static string HuaDuDou = "花肚兜";
    public static string HuaBiJian = "花比肩";
    public static string QiaoSiShang = "巧四賞";
    public static string QiaoSiJian = "巧四肩";
    public static string TianDiFen = "天地分";
    public static string XiaoTianDiFen = "小天地分";
    public static string JianTianDiFen = "肩天地分";
    public static string BaiChangJian = "百長肩";
    public static string BaiDuanJian = "百短肩";
    public static string JiChangJian = "極長肩";
    public static string JiDuanJian = "極短肩";
    public static string DuiJian = "對肩";
    public static string ChangJian = "長肩";
    public static string DuanJian = "短肩";
    public static string BaiJiSiJian = "百極四肩";
    public static string BaiJiSiShang = "百極四賞";
    public static string BaiJianSiJi = "百肩四極";
    public static string BaiShangBaiJi = "百賞百極";
    public static string JieJieGao = "節節高";
    public static string BaiJiYuBei = "百鯽魚背";
    public static string JianJiYuBei = "肩鯽魚背";
    public static string ShangJiYUBei = "賞鯽魚背";
    public static string SanQingYuJi = "三清禦極";
    public static string TongQiLianZhi = "義結金蘭";

    //鬥上雜色樣
    public static string NeiShengWaiWang = "内聖外王";
    public static string TianRanQu = "天然趣";
    public static string FeiLaiQu = "飛來趣";
    public static string NvDiDengJi = "女帝登基";
    public static string SanDieQu = "三疊趣";
    public static string LongMenYue = "龍門躍";
    public static string FoDingZhu = "佛頂珠";
    public static string SanHuaTianNv = "散花天女";
    public static string TianNvSanHua = "天女散花";
    public static string ZhuoJiXianBai = "一枝花";
    public static string ZhuoJiXianJi = "捉極獻極";
    public static string GongSunDuiZuo = "公孫對座";
    public static string FuZiTongDeng = "父子同登";
    public static string XiongDiQiXin = "兄弟齊心";
    public static string ShangJianDuiZuo = "賞肩對座";
    public static string ShangBaiDuiZuo = "賞百對座";
    public static string JianBaiDuiZuo = "賞百對座";  
    public static string SanDaiRongFeng = "三代榮封";
    public static string ShunFengQi = "順風旗";
    public static string XiangLuJiao = "香爐腳";
    public static string YuanyangDing = "鴛鴦鼎";
    public static string ZhuShaDing = "硃砂鼎";
    public static string YuwangDing = "禹王鼎";
    public static string WenwangDing = "文王鼎";
    public static string TieXiangLu = "鐵香爐";
    public static string ShuangFeiQu = "雙飛趣";
    public static string GuoQiaoLong = "過橋龍";
    public static string QuHouBai = "趣後百";
    public static string BaiHouQu = "百後趣";
    public static string ShuangQuHou = "雙槍將";
    public static string ShuangBaiHou = "雙尾蠍";
    public static string DaoJuanLian = "倒捲簾";
    public static string JuanLianFei = "捲簾飛";
    public static string HuangDaoJuan = "美人捲簾";
    public static string BaQuan = "八全";
    public static string LiuDiao = "六桌吊";
    public static string QiDiao = "七桌吊";
    public static string JingZhongRen = "鏡中人";
    public static string JieHuaXianFo = "藉花獻佛";
    public static string FuQiTuanYuan = "夫妻團圓";
    public static string RenMianTaoHua = "人麵桃花";
    public static string MeiNvCanChan = "美女參禪";
    public static string XiaoCanChan = "小參禪";
    public static string ErFoTanJing = "二佛談經";
    public static string TianXianSongZi = "天仙送子";
    public static string GongLingSun = "公領孫";
    public static string FuLuShouXi = "福祿壽喜";
    public static string FourJian = "四肩在手";
    public static string LianHuanSuo = "連環索";
    public static string DaLianHuanSuo = "五絃連環索";
    public static string QingBaiRenJia = "平步青雲";


    //衝成色樣
    public static string ShiHongJuHui = "十紅聚會";
    public static string ShiHongZuiYangFei = "十紅醉楊妃";
    public static string JiuHong = "九紅";
    public static string QuanHongZuiYangFei = "全紅醉楊妃";
    public static string JiuHongZuiYangFei = "九紅醉楊妃";
    public static string BaHongZuiYangFei = "八紅醉楊妃";
    public static string JiuTong = "九同";
    public static string ShiTong = "十同";
    public static string JiuLianHuan = "九連環";
    public static string ShiLianHuan = "順天一統";
    public static string QianShiQuanMen = "錢十全門";
    public static string GuanSuoQuanMen = "貫索全門";
    public static string TaiJiTu = "太極圖";
    public static string YuanYangQiTong = "鴛鴦七同";
    public static string LianHuanQiTong = "連環七同";
    public static string JinJueZang = "金掘藏";
    public static string YinJueZang = "銀掘藏";
    public static string TwoJueZang = "双掘藏";
    public static string YiChuoLiu = "一戳六";
    public static string YiChuoQi = "一戳七";
    public static string YinHua = "印花";
    public static string DuoJinBiao = "夺锦标";

    public static string ShangXJian = "賞衝肩";
    public static string ShangXQu = "賞衝趣";
    public static string ShangXQing = "賞衝青";
    public static string JianXShang = "肩衝賞";
    public static string QuXShang = "趣衝賞";
    public static string QuXFuqu = "趣衝副趣";
    public static string QuXQing = "趣衝青";
    public static string QuXJian = "趣衝肩";
    public static string XiongdiX = "兄弟衝";
    public static string JuanLianX = "捲簾衝";

}

