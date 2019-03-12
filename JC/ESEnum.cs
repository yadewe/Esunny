using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace global
{
    /// <summary>
    /// 日志级别
    /// </summary>
    public enum DDEnumLogLevel : byte
    {
        //! 无
        NONE =(byte) 'N',
        //! Error
        ERROR = (byte)'E',
        //! Warning
        WARNING = (byte)'W',
        //! Debug
        DEBUG = (byte)'D',
    }

    /// <summary>
    /// 登录用户身份类型
    /// </summary>
    public enum DDEnumUserTypeType : int
    {
        /// <summary>
        /// 投资者用户
        /// </summary>
        Client = 10000,
        /// <summary>
        /// 经纪人
        /// </summary>
        Broker = 20000,
        /// <summary>
        /// 交易员
        /// </summary>
        Trader = 30000,
        /// <summary>
        /// 风控
        /// </summary>
        Risk = 40000,
        /// <summary>
        /// 管理员
        /// </summary>
        Manager = 50000,
        /// <summary>
        /// 行情
        /// </summary>
        Quote = 60000
    }
    /// <summary>
    /// 消息类型
    /// </summary>
    public enum DDEnumMsgTypeType : byte
    {
        /// <summary>
        /// 管理
        /// </summary>
        [Description("管理")]
        MANAGER = (byte)'1',
        /// <summary>
        ///  风险
        /// </summary>
        [Description("风险")]
        RISKCONTROL = (byte)'2'
    }
    /// <summary>
    /// 消息级别
    /// </summary>
    public enum DDEnumMsgLevelType : byte
    {
        /// <summary>
        /// 普通
        /// </summary>
        [Description("普通")]
        NORMAL = (byte)'1',
        /// <summary>
        /// 重要
        /// </summary>
        [Description("重要")]
        IMPORTANT = (byte)'2',
        /// <summary>
        /// 紧急
        /// </summary>
        [Description("紧急")]
        IMERGENCY = (byte)'3'
    }
    /// <summary>
    /// 品种类型
    /// </summary>
    public enum DDEnumCommodityType : byte
    {

        /// <summary>
        /// 无
        /// </summary>
        NONE = (byte)'N',
        /// <summary>
        /// 现货
        /// </summary>
        SPOT = (byte)'P',
        /// <summary>
        /// 期货
        /// </summary>
        FUTURES = (byte)'F',
        /// <summary>
        /// 期权
        /// </summary>
        OPTION = (byte)'O',
        /// <summary>
        /// 跨期套利
        /// </summary>
        SPREAD_MONTH = (byte)'S',
        /// <summary>
        /// 跨品种套利
        /// </summary>
        SPREAD_COMMODITY = (byte)'M',
        /// <summary>
        /// 看涨垂直套利
        /// </summary>
        BUL = (byte)'U',
        /// <summary>
        /// 看跌垂直套利
        /// </summary>
        BER = (byte)'E',
        /// <summary>
        /// 跨式套利
        /// </summary>
        STD = (byte)'D',
        /// <summary> 宽跨式套利
        STG = (byte)'G',
        /// <summary>
        /// 备兑组合
        /// </summary>
        PRT = (byte)'R',
        /// <summary>
        /// 外汇——直接汇率
        /// </summary>
        DIRECTFOREX = (byte)'X',

        /// <summary>
        ///  外汇——间接汇率
        /// </summary>
        INDIRECTFOREX = (byte)'I',
        /// <summary>
        ///  外汇——交叉汇率
        /// </summary>
        CROSSFOREX = (byte)'C',
        /// <summary>
        ///  指数
        /// </summary>
        INDEX = (byte)'Z',
        /// <summary>
        /// 股票
        /// </summary>
        STOCK = (byte)'T'
    }



    /// <summary>
    /// 看涨看跌标示
    /// </summary>
    public enum DDEnumCallOrPutFlagType : byte
    {
        /// <summary>
        /// 买权
        /// </summary>
        CALL = (byte)'C',
        /// <summary>
        /// 卖权
        /// </summary>
        PUT = (byte)'P',
        /// <summary>
        /// 无
        /// </summary>
        NONE = (byte)'N'
    }
    /// <summary>
    /// 计算方式
    /// </summary>
    public enum DDEnumCalculateModeType : byte
    {
        /// <summary>
        /// 比例+定额（仅限手续费）大于0.01部分为定额，小于0.01部分为比例，如：0.001为比例收取1%。
        /// </summary>
        COMBINE = (byte)'0',
        /// <summary>
        ///  比例
        /// </summary>
        PERCENTAGE = (byte)'1',
        /// <summary>
        /// 定额
        /// </summary>
        QUOTA = (byte)'2',
        /// <summary>
        /// 差值比例	
        /// </summary>
        CHAPERCENTAGE = (byte)'3',
        /// <summary>
        /// 差值定额
        /// </summary>
        CHAQUOTA = (byte)'4',
        /// <summary>
        ///  折扣
        /// </summary>
        DISCOUNT = (byte)'5'
    }

    /// <summary>
    /// 成交来源
    /// </summary>
    public enum DDEnumMatchSourceType : byte
    {
        /// <summary>
        /// 全部
        /// </summary>
        ALL = (byte)'0',
        /// <summary>
        /// 自助电子单
        /// </summary>
        SELF_ETRADER = (byte)'1',
        /// <summary>
        /// 代理电子单
        /// </summary>
        PROXY_ETRADER = (byte)'2',
        /// <summary>
        /// 外部电子单
        /// </summary>
        JTRADER = (byte)'3',
        /// <summary>
        /// 人工录入单
        /// </summary>
        MANUAL = (byte)'4',
        /// <summary>
        /// carry单
        /// </summary>
        CARRY = (byte)'5',
        /// <summary>
        /// 程式化单
        /// </summary>
        PROGRAM = (byte)'6',
        /// <summary>
        /// 交割行权
        /// </summary>
        DELIVERY = (byte)'7',
        /// <summary>
        ///  期权放弃
        /// </summary>
        ABANDON = (byte)'8',
        /// <summary>
        /// 通道费
        /// </summary>
        CHANNEL = (byte)'9',
        /// <summary>
        /// 易盛API
        /// </summary>
        ESUNNY_API = (byte)'A'

    }


    /// <summary>
    /// 资金调整类型
    /// </summary>
    public enum DDEnumCashAdjustTypeType : byte
    {

        /// <summary>
        ///  手续费调整
        /// </summary>
        FEEADJUST = (byte)'0',
        /// <summary>
        /// 盈亏调整
        /// </summary>
        YKADJUST = (byte)'1',
        /// <summary>
        ///  质押资金
        /// </summary>
        PLEDGE = (byte)'2',
        /// <summary>
        /// 利息收入
        /// </summary>
        INTERESTREVENUE = (byte)'3',
        /// <summary>
        /// 代扣费用
        /// </summary>
        COLLECTIONCOST = (byte)'4',
        /// <summary>
        /// 其它
        /// </summary>
        OTHER = (byte)'5',
        /// <summary>
        /// 公司间拨账
        /// </summary>
        COMPANY = (byte)'6'
    }

    /// <summary>
    /// 本外币标识
    /// </summary>
    public enum DDEnumBankAccountLWFlagType : byte
    {
        /// <summary>
        /// 境内人民币账户
        /// </summary>
        L = (byte)'L',
        /// <summary>
        /// 客户境内外币账户
        /// </summary>
        W = (byte)'W'
    }
    /// <summary>
    /// 交割行权方式,期货和期权了结的方式
    /// </summary>
    public enum DDEnumDeliveryModeType : byte
    {
        /// <summary>
        /// 实物交割
        /// </summary>
        GOODS = (byte)'G',
        /// <summary>
        /// 现金交割
        /// </summary>
        CASH = (byte)'C',
        /// <summary>
        /// 期权行权
        /// </summary>
        EXECUTE = (byte)'E',
        /// <summary>
        /// 期权放弃
        /// </summary>
        ABANDON = (byte)'A',
        /// <summary>
        /// 港交所行权
        /// </summary>
        HKF = (byte)'H'
    }

    /// <summary>
    /// 买卖类型
    /// </summary>
    public enum DDEnumSideType : byte
    {
        /// <summary>
        ///  无
        /// </summary>
        NONE = (byte)'N',
        /// <summary>
        /// 买入
        /// </summary>
        [Description("买入")]
        BUY = (byte)'B',
        /// <summary>
        /// 卖出
        /// </summary>
        [Description("卖出")]
        SELL = (byte)'S'
    }

    /// <summary>
    /// 投机保值类型
    /// </summary>
    public enum DDEnumHedgeFlagType : byte
    {
        /// <summary>
        /// 无
        /// </summary>
        [Description("无")]
        NONE = (byte)'N',
        /// <summary>
        ///  投机
        /// </summary>
        [Description("投机")]
        T = (byte)'T',
        /// <summary>
        /// 保值
        /// </summary>
        [Description("保值")]
        B = (byte)'B',
        /// <summary>
        /// 套利
        /// </summary>
        [Description("套利")]
        L = (byte)'L'
    }
    /// <summary>
    /// 账单类型
    /// </summary>
    public enum DDEnumSettleFlagType : byte
    {
        /// <summary>
        /// 自动结算
        /// </summary>
        AutoSettle = (byte)'0',
        /// <summary>
        /// 人工结算
        /// </summary>
        Manual = (byte)'2'
    }
    /// <summary>
    /// 开平类型
    /// </summary>
    public enum DDEnumPositionEffectType : byte
    {
        /// <summary>
        ///  不分开平
        /// </summary>
        [Description("不分开平")]
        NONE = (byte)'N',
        /// <summary>
        /// 开仓
        /// </summary>
        [Description("开仓")]
        OPEN = (byte)'O',
        /// <summary>
        /// 平仓
        /// </summary>
        [Description("平仓")]
        COVER = (byte)'C',
        /// <summary>
        /// 平当日
        /// </summary>
        [Description("平当日")]
        COVER_TODAY = (byte)'T'
    }

    /// <summary>
    /// 是否标记
    /// </summary>
    public enum DDEnumYNFlag : byte
    {
        /// <summary>
        /// 是
        /// </summary>
        YES = (byte)'Y',
        /// <summary>
        /// 否
        /// </summary>
        NO = (byte)'N'
    }

    /// <summary>
    /// 委托状态类型
    /// </summary>
    public enum DDEnumOrderStateType : byte
    {
        /// <summary>
        /// 终端提交
        /// </summary>
        [Description("终端提交")]
        SUBMIT = (byte)'0',
        /// <summary>
        /// 已受理
        /// </summary>
        [Description("已受理")]
        ACCEPT = (byte)'1',
        /// <summary>
        /// 策略待触发
        /// </summary>
        [Description("策略待触发")]
        TRIGGERING = (byte)'2',
        /// <summary>
        /// 交易所待触发
        /// </summary>
        [Description("交易所待触发")]
        EXCTRIGGERING = (byte)'3',
        /// <summary>
        /// 已排队
        /// </summary>
        [Description("已排队")]
        QUEUED = (byte)'4',
        /// <summary>
        ///  部分成交
        /// </summary>
        [Description("部分成交")]
        PARTFINISHED = (byte)'5',

        /// <summary>
        /// 完全成交
        /// </summary>
        [Description("完全成交")]
        FINISHED = (byte)'6',
        /// <summary>
        /// 待撤消(排队临时状态)
        /// </summary>
        [Description("待撤消")]
        CANCELING = (byte)'7',
        /// <summary>
        /// 待修改(排队临时状态)
        /// </summary>
        [Description("待修改")]
        MODIFYING = (byte)'8',
        /// <summary>
        /// 完全撤单
        /// </summary>
        [Description("完全撤单")]
        CANCELED = (byte)'9',
        /// <summary>
        /// 已撤余单
        /// </summary>
        [Description("已撤余单")]
        LEFTDELETED = (byte)'A',
        /// <summary>
        /// 指令失败
        /// </summary>
        [Description("指令失败")]
        FAIL = (byte)'B',
        /// <summary>
        /// 策略删除
        /// </summary>
        [Description("策略删除")]
        DELETED = (byte)'C',
        /// <summary>
        /// 已挂起
        /// </summary>
        [Description("已挂起")]
        SUPPENDED = (byte)'D',
        /// <summary>
        ///  到期删除
        /// </summary>
        [Description("到期删除")]
        DELETEDFOREXPIRE = (byte)'E',
        /// <summary>
        /// 已生效——询价成功
        /// </summary>
        [Description("已生效")]
        EFFECT = (byte)'F',
        /// <summary>
        /// 已申请——行权、弃权、套利等申请成功
        /// </summary>
        [Description("已申请")]
        APPLY = (byte)'G'
    }


    /// <summary>
    /// 委托有效类型
    /// </summary>
    public enum DDEnumTimeInForceType : byte
    {
        /// <summary>
        /// 当日有效
        /// </summary>
        GFD = (byte)'0',
        /// <summary>
        /// 取消前有效
        /// </summary>
        GTC = (byte)'1',
        /// <summary>
        /// 指定日期前有效
        /// </summary>
        GTD = (byte)'2',
        /// <summary>
        /// FAK或IOC
        /// </summary>
        FAK = (byte)'3',
        /// <summary>
        /// FOK
        /// </summary>
        FOK = (byte)'4'
    }

    /// <summary>
    /// 账单类型
    /// </summary>
    public enum DDEnumBillTypeType : byte
    {
        /// <summary>
        /// 日类型
        /// </summary>
        DATE = (byte)'D',
        /// <summary>
        /// 月类型
        /// </summary>
        MONTH = (byte)'M'
    }
    /// <summary>
    /// 帐单文件类型
    /// </summary>
    public enum DDEnumBillFileTypeType : byte
    {
        /// <summary>
        /// txt文件类型
        /// </summary>
        TXT = (byte)'T',
        /// <summary>
        /// pdf文件类型
        /// </summary>
        PDF = (byte)'F'
    }
    public enum DDEnumAccountType : byte
    {
        /// <summary>
        /// 个人客户
        /// </summary>
        PERSON = (byte)'P',
        /// <summary>
        /// 机构客户
        /// </summary>
        ORGANIZATION = (byte)'O',
        /// <summary>
        /// 代理人
        /// </summary>
        AGENT = (byte)'A',
        /// <summary>
        /// Margin
        /// </summary>
        MARGIN = (byte)'M',
        /// <summary>
        /// Internal
        /// </summary>
        HOUSE = (byte)'H',
        /// <summary>
        /// 股票账户
        /// </summary>
        STOCK = (byte)'S'
    }
    /// <summary>
    /// 账号状态
    /// </summary>
    public enum DDEnumAccountState : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        NORMAL = (byte)'N',
        /// <summary>
        /// 销户
        /// </summary>
        CANCEL = (byte)'C',
        /// <summary>
        /// 休眠
        /// </summary>
        SLEEP = (byte)'S'
    }

    /// <summary>
    /// 客户交易状态类型
    /// </summary>
    public enum DDEnumAccountRightType : byte
    {
        /// <summary>
        /// 正常交易
        /// </summary>
        NORMAL = (byte)'0',
        /// <summary>
        /// 禁止交易
        /// </summary>
        NOTRADE = (byte)'1',
        /// <summary>
        /// 只可平仓
        /// </summary>
        CLOSE = (byte)'2'
    }

    /// <summary>
    /// 委托类型
    /// </summary>
    public enum DDEnumOrderTypeType : byte
    {
        /// <summary>
        /// 市价
        /// </summary>
        MARKET = (byte)'1',
        /// <summary>
        /// 限价
        /// </summary>
        LIMIT = (byte)'2',
        /// <summary>
        /// 市价止损
        /// </summary>
        STOP_MARKET = (byte)'3',
        /// <summary>
        /// 限价止损
        /// </summary>
        STOP_LIMIT = (byte)'4',
        /// <summary>
        /// 期权行权
        /// </summary>
        OPT_EXEC = (byte)'5',
        /// <summary>
        /// 期权弃权
        /// </summary>
        OPT_ABANDON = (byte)'6',
        /// <summary>
        /// 询价
        /// </summary>
        REQQUOT = (byte)'7',
        /// <summary>
        /// 应价
        /// </summary>
        RSPQUOT = (byte)'8',
        /// <summary>
        /// 冰山单
        /// </summary>
        ICEBERG = (byte)'9',
        /// <summary>
        /// 影子单
        /// </summary>
        GHOST = (byte)'A',
        /// <summary>
        /// 港交所竞价单
        /// </summary>
        HKEX_AUCTION = (byte)'B',
        /// <summary>
        /// 互换
        /// </summary>
        SWAP = (byte)'C'
    }
    /// <summary>
    /// 委托来源
    /// </summary>
    public enum DDEnumOrderSourceType : byte
    {
        /// <summary>
        /// 自助电子单
        /// </summary>
        SELF_ETRADER = (byte)'1',
        /// <summary>
        /// 代理电子单
        /// </summary>
        PROXY_ETRADER = (byte)'2',
        /// <summary>
        /// 外部电子单(外部电子系统下单，本系统录入)
        /// </summary>
        JTRADER = (byte)'3',
        /// <summary>
        /// 人工录入单(外部其他方式下单，本系统录入)
        /// </summary>
        MANUAL = (byte)'4',
        /// <summary>
        /// carry单
        /// </summary>
        CARRY = (byte)'5',
        /// <summary>
        ///  程式化报单
        /// </summary>
        PROGRAM = (byte)'6',
        /// <summary>
        /// 交割行权
        /// </summary>
        DELIVERY = (byte)'7',
        /// <summary>
        /// 期权放弃
        /// </summary>
        ABANDON = (byte)'8',
        /// <summary>
        /// 通道费
        /// </summary>
        CHANNEL = (byte)'9'
    }
    /// <summary>
    /// 策略单类型
    /// </summary>
    public enum DDEnumTacticsTypeType : byte
    {
        /// <summary>
        /// 无
        /// </summary>
        NONE = (byte)'N',

        /// <summary>
        /// 预备单(埋单)
        /// </summary>
        READY = (byte)'M',
        /// <summary>
        /// 自动单
        /// </summary>
        ATUO = (byte)'A',
        /// <summary>
        /// 条件单
        /// </summary>
        CONDITION = (byte)'C'
    }

    /// <summary>
    /// 触发条件类型
    /// </summary>
    public enum DDEnumTriggerConditionType : byte
    {
        /// <summary>
        /// 无
        /// </summary>
        NONE = (byte)'N',
        /// <summary>
        /// 大于等于
        /// </summary>
        GREAT = (byte)'G',
        /// <summary>
        /// 小于等于
        /// </summary>
        LITTLE = (byte)'L'
    }
    /// <summary>
    /// 触发价格类型
    /// </summary>
    public enum DDEnumTriggerPriceTypeType : byte
    {
        /// <summary>
        /// 无
        /// </summary>
        NONE = (byte)'N',
        /// <summary>
        /// 买价
        /// </summary>
        BUY = (byte)'B',

        /// <summary>
        /// 卖价
        /// </summary>
        SELL = (byte)'S',
        /// <summary>
        /// 最新价
        /// </summary>
        LAST = (byte)'L'
    }

    /// <summary>
    /// 期货算法
    /// </summary>
    public enum DDEnumFutureAlgType : byte
    {
        /// <summary>
        /// 逐笔
        /// </summary>
        ZHUBI = (byte)'1',
        /// <summary>
        /// 盯市
        /// </summary>
        DINGSHI = (byte)'2'
    }

    /// <summary>
    /// 期权算法
    /// </summary>
    public enum DDEnumOptionAlgType : byte
    {
        /// <summary>
        /// 期货方式
        /// </summary>
        FUTURES = (byte)'1',
        /// <summary>
        /// 期权方式
        /// </summary>
        OPTION = (byte)'2'
    }
    /// <summary>
    /// 合约类型
    /// </summary>
    public enum DDEnumContractTypeType : byte
    {
        /// <summary>
        /// 交易行情合约
        /// </summary>
        TRADEQUOTE = (byte)'1',
        /// <summary>
        /// 行情合约
        /// </summary>
        QUOTE = (byte)'2'
    }
    /// <summary>
    /// 开平方式
    /// </summary>
    public enum DDEnumOpenCloseModeType : byte
    {
        /// <summary>
        /// 不区分开平
        /// </summary>
        [Description("不区分开平")]
        NONE = (byte)'N',
        /// <summary>
        /// 平仓未了结(byte)
        /// </summary>
        [Description("平仓未了结")]
        UNFINISHED = (byte)'U',
        /// <summary>
        /// 区分开仓和平仓
        /// </summary>
        [Description("区分开仓和平仓")]
        OPENCOVER = (byte)'C',
        /// <summary>
        ///  区分开仓、平仓和平今
        /// </summary>
        [Description("区分开仓、平仓和平今")]
        CLOSETODAY = (byte)'T'
    }

    /// <summary>
    /// 组合方向,品种两腿组合合约的买卖方向和第几腿相同
    /// </summary>
    public enum DDEnumCmbDirectType : byte
    {
        /// <summary>
        /// 和第一腿一致
        /// </summary>
        FIRST = (byte)'1',
        /// <summary>
        /// 和第二腿一致
        /// </summary>
        SECOND = (byte)'2',
    }
    /// <summary>
    /// 订单操作类型
    /// </summary>
    public enum DDEnumOrderAct : byte
    {
        /// <summary>
        /// 报单
        /// </summary>
        [Description("报单")]
        INSERT = (byte)'1',
        /// <summary>
        /// 改单
        /// </summary>
        [Description("改单")]
        MODIFY = (byte)'2',
        /// <summary>
        /// 撤单
        /// </summary>
        [Description("撤单")]
        DELETE = (byte)'3',
        /// <summary>
        /// 挂起
        /// </summary>
        [Description("挂起")]
        SUSPEND = (byte)'4',
        /// <summary>
        /// 激活
        /// </summary>
        [Description("激活")]
        ACTIVATE = (byte)'5',
        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        SYSTEM_DELETE = (byte)'6'
    }

    /// <summary>
    /// 密码类型
    /// </summary>
    public enum DDEnumPasswordType : byte
    {
        /// <summary>
        /// 交易
        /// </summary>
        TRADE = (byte)'T',
        /// <summary>
        /// 手机消息
        /// </summary>
        PHONE = (byte)'P'
    }
}
