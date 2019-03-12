// 这是主 DLL 文件。
#include "stdafx.h"
#include <vcclr.h>

#include "ESTrade9.0CLR.h"
#include "Convert.h"
#include "Autority.h"
#include "RefHead\iTapAPICommDef.h"
#include "RefHead\iTapTradeAPIDataType.h"
#include "RefHead\iTapTradeAPI.h"

using namespace System;
using namespace ITapTrade;
using namespace System::Runtime::InteropServices;
using namespace std;

namespace global {

	//交易回调
	class EsTradeApiResonse :public ITapTradeAPINotify
	{

	private:
		//用gcroot定义托管类型的全局变量
		gcroot<DDEsunnyApiCallback^> tradeCallback;

	public:
		EsTradeApiResonse(DDEsunnyApiCallback^  callback) {
			tradeCallback = callback;
		}

		/**
		* @brief 连接成功回调通知
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnConnect() {
			tradeCallback->OnConnect();
		}

		/**
		* @brief	系统登录过程回调。
		* @details	此函数为Login()登录函数的回调，调用Login()成功后建立了链路连接，然后API将向服务器发送登录认证信息，
		*			登录期间的数据发送情况和登录的回馈信息传递到此回调函数中。
		* @param[in] errorCode 返回错误码,0表示成功。
		* @param[in] loginRspInfo 登陆应答信息，如果errorCode!=0，则loginRspInfo=NULL。
		* @attention	该回调返回成功，说明用户登录成功。但是不代表API准备完毕。
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnRspLogin(TAPIINT32 errorCode, const TapAPITradeLoginRspInfo *loginRspInfo) {
			tradeCallback->OnRspLogin(errorCode, To_RspLoginField(loginRspInfo));
		}

		/**
		* @brief	二次认证联系方式通知。
		* @details	登录完成后，如果需要二次认证（9.2.7后台），会收到联系方式的通知，可以选择通知消息的一个联系方式（邮箱或者电话）
		*			请求发送二次认证授权码（RequestVertificateCode）。
		* @param[in] errorCode 返回错误码,0表示成功。如果账户没有绑定二次认证联系方式，则返回10016错误。
		* @param[in] isLast,标识是否是最后一条联系信息。
		* @param[in]  认证方式信息，如果errorCode!=0，则ContactInfo为空。
		* @attention	该回调返回成功，说明需要二次认证，并且需要选择一个联系方式然后调用RequestVertificateCode。
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnRtnContactInfo(TAPIINT32 errorCode, TAPIYNFLAG isLast, const TAPISTR_40 ContactInfo) {
			tradeCallback->OnRtnContactInfo(errorCode, IsLast(isLast), gcnew String(ContactInfo));
		}

		/**
		* @brief	请求发送二次认证码应答。
		* @details	请求获取二次认证授权码，后台发送邮件或者短信，并给出应答，包含发送序号以及认证码有效期。
		*
		* @param[in] sessionID 请求二次认证码会话ID。
		* @param[in]  errorCode 如果没有绑定联系，返回10016错误.
		* @param[in]  rsp二次认证码有效期，以秒返回，在二次认证有效期内，可以重复设置二次认证码，但是不能再重新申请二次认证码。
		* @attention	该回调返回成功，说明需要二次认证，并且需要选择一个联系方式然后调用RequestVertificateCode。
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnRspRequestVertificateCode(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIRequestVertificateCodeRsp *rsp) {
			tradeCallback->OnRspRequestVertificateCode(sessionID, errorCode, To_RspRequestVertificateCodeField(rsp));
		}

		/**
		* @brief	API到期提醒回调
		* @details	此函数为Login()登录成功后，如果到期日与当前日期小于30天，则进行回调提醒。
		* @param[in] date 返回API授权到期日。
		* @param[in] days 返回还有几天授权到期。
		* @attention	该函数回调，则说明授权在一个月之内到期。否则不产生该回调。
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnExpriationDate(TAPIDATE date, int days) {
			tradeCallback->OnExpriationDate(gcnew String(date), days);
		}

		/**
		* @brief	通知用户API准备就绪。
		* @details	只有用户回调收到此就绪通知时才能进行后续的各种行情数据查询操作。\n
		*			此回调函数是API能否正常工作的标志。
		* @attention 就绪后才可以进行后续正常操作
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnAPIReady(TAPIINT32 errorCode) {
			tradeCallback->OnAPIReady(errorCode);
		}

		/**
		* @brief	API和服务失去连接的回调
		* @details	在API使用过程中主动或者被动与服务器服务失去连接后都会触发此回调通知用户与服务器的连接已经断开。
		* @param[in] reasonCode 断开原因代码。
		* @ingroup G_T_Disconnect
		*/
		virtual void TAP_CDECL OnDisconnect(TAPIINT32 reasonCode) {
			tradeCallback->OnDisconnect(reasonCode);
		}

		/**
		* @brief 通知用户密码修改结果
		* @param[in] sessionID 修改密码的会话ID,和ChangePassword返回的会话ID对应。
		* @param[in] errorCode 返回错误码，0表示成功。
		* @ingroup G_T_UserInfo
		*/
		virtual void TAP_CDECL OnRspChangePassword(TAPIUINT32 sessionID, TAPIINT32 errorCode) {
			tradeCallback->OnRspChangePassword(sessionID, errorCode);
		}

		/**
		* @brief 认证账户密码反馈
		* @param[in] sessionID 修改密码的会话ID,和AuthPassword返回的会话ID对应。
		* @param[in] errorCode 返回错误码，0表示成功。
		* @ingroup G_T_UserInfo
		*/
		virtual void TAP_CDECL OnRspAuthPassword(TAPIUINT32 sessionID, TAPIINT32 errorCode) {
			tradeCallback->OnRspAuthPassword(sessionID, errorCode);
		}

		/**
		* @brief 设置用户预留信息反馈
		* @param[in] sessionID 设置用户预留信息的会话ID
		* @param[in] errorCode 返回错误码，0表示成功。
		* @param[in] info 指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @note 该接口暂未实现
		* @ingroup G_T_UserInfo
		*/
		virtual void TAP_CDECL OnRspSetReservedInfo(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TAPISTR_50 info) {
			tradeCallback->OnRspSetReservedInfo(sessionID, errorCode, gcnew String(info));
		}

		/**
		* @brief	返回用户信息
		* @details	此回调接口向用户返回查询的资金账号的详细信息。用户有必要将得到的账号编号保存起来，然后在后续的函数调用中使用。
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 标示是否是最后一批数据；
		* @param[in] info 指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_AccountInfo
		*/
		virtual void TAP_CDECL OnRspQryAccount(TAPIUINT32 sessionID, TAPIUINT32 errorCode, TAPIYNFLAG isLast, const TapAPIAccountInfo *rsp) {
			tradeCallback->OnRspQryAccount(sessionID, errorCode, IsLast(isLast), To_RspQryAccountField(rsp));
		}

		/**
		* @brief 返回资金账户的资金信息
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_AccountDetails
		*/
		virtual void TAP_CDECL OnRspQryFund(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIFundData *rsp) {
			tradeCallback->OnRspQryFund(sessionID, errorCode, IsLast(isLast), To_QryFundRspField(rsp));
		}

		/**
		* @brief	用户资金变化通知
		* @details	用户的委托成交后会引起资金数据的变化，因此需要向用户实时反馈。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @note 如果不关注此项内容，可以设定Login时的NoticeIgnoreFlag以屏蔽。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_AccountDetails
		*/
		virtual void TAP_CDECL OnRtnFund(const TapAPIFundData *info) {
			tradeCallback->OnRtnFund(To_QryFundRspField(info));
		}

		/**
		* @brief 返回系统中的交易所信息
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeSystem
		*/
		virtual void TAP_CDECL OnRspQryExchange(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIExchangeInfo *rsp) {
			tradeCallback->OnRspQryExchange(sessionID, errorCode, IsLast(isLast), To_QryExchangeRspField(rsp));
		}

		/**
		* @brief	返回系统中品种信息
		* @details	此回调接口用于向用户返回得到的所有品种信息。
		* @param[in] sessionID 请求的会话ID，和GetAllCommodities()函数返回对应；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_Commodity
		*/
		virtual void TAP_CDECL OnRspQryCommodity(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPICommodityInfo *rsp) {
			tradeCallback->OnRspQryCommodity(sessionID, errorCode, IsLast(isLast), To_QryCommodityRspField(rsp));
		}

		/**
		* @brief 返回系统中合约信息
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_Contract
		*/
		virtual void TAP_CDECL OnRspQryContract(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPITradeContractInfo *rsp) {
			tradeCallback->OnRspQryContract(sessionID, errorCode, IsLast(isLast), To_QryContractRspField(rsp));
		}

		/**
		* @brief	返回新增合约信息
		* @details	向用户推送新的合约。主要用来处理在交易时间段中服务器添加了新合约时，向用户发送这个合约的信息。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_Contract
		*/
		virtual void TAP_CDECL OnRtnContract(const TapAPITradeContractInfo *rsp) {
			tradeCallback->OnRtnContract(To_QryContractRspField(rsp));
		}

		/**
		* @brief	订单操作应答
		* @details	下单、撤单、改单应答。下单都会有次应答回调，如果下单请求结构中没有填写合约或者资金账号，则仅返回错误号。
		* 撤单、改单错误由应答和OnRtnOrder，成功仅返回OnRtnOrder回调。
		* sessionID标识请求对应的sessionID，以便确定该笔应答对应的请求。
		*
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info 订单应答具体类型，包含订单操作类型和订单信息指针。
		* 订单信息指针部分情况下可能为空，如果为空，可以通过SessiuonID找到对应请求获取请求类型。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRspOrderAction(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderActionRsp *rsp) {
			tradeCallback->OnRspOrderAction(sessionID, errorCode, To_QryOrderRspField_2(rsp));
		}

		/**
		* @brief 返回新委托。新下的或者其他地方下的推送过来的。
		* @details	服务器接收到客户下的委托内容后就会保存起来等待触发，同时向用户回馈一个
		*			新委托信息说明服务器正确处理了用户的请求，返回的信息中包含了全部的委托信息，
		*			同时有一个用来标示此委托的委托号。
		* @param[in] info 指向返回的信息结构体。当errorCode不为0时，info为空。
		* @note 如果不关注此项内容，可以设定Login时的NoticeIgnoreFlag以屏蔽。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnOrder(const TapAPIOrderInfoNotice *info) {
			tradeCallback->OnRtnOrder(To_QryOrderRspField_3(info));
		}

		/**
		* @brief	返回查询的委托信息
		* @details	返回用户查询的委托的具体信息。
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 标示是否是最后一批数据；
		* @param[in] info 指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryOrder(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIOrderInfo *rsp) {
			tradeCallback->OnRspQryOrder(sessionID, errorCode, IsLast(isLast), To_QryOrderRspField(rsp));
		}

		/**
		* @brief 返回查询的委托变化流程信息
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码，当errorCode==0时，info指向返回的委托变化流程结构体，不然为NULL；
		* @param[in] isLast 标示是否是最后一批数据；
		* @param[in] info 返回的委托变化流程指针。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryOrderProcess(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIOrderInfo *info) {
		}

		/**
		* @brief 返回查询的成交信息
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryFill(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIFillInfo *rsp) {
			tradeCallback->OnRspQryFill(sessionID, errorCode, IsLast(isLast), To_QryFillRspField(rsp));
		}

		/**
		* @brief	推送来的成交信息
		* @details	用户的委托成交后将向用户推送成交信息。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @note 如果不关注此项内容，可以设定Login时的NoticeIgnoreFlag以屏蔽。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnFill(const TapAPIFillInfo *rsp) {
			tradeCallback->OnRtnFill(To_QryFillRspField(rsp));
		}

		/**
		* @brief 返回查询的持仓
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryPosition(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIPositionInfo *rsp) {
			tradeCallback->OnRspQryPosition(sessionID, errorCode, IsLast(isLast), To_QryPositionRspField(rsp));
		}

		/**
		* @brief 持仓变化推送通知
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @note 如果不关注此项内容，可以设定Login时的NoticeIgnoreFlag以屏蔽。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnPosition(const TapAPIPositionInfo *rsp) {
			tradeCallback->OnRtnPosition(To_QryPositionRspField(rsp));
		}

		/**
		* @brief 返回查询的持仓汇总
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryPositionSummary(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIPositionSummary *rsp) {
			tradeCallback->OnRspQryPositionSummary(sessionID, errorCode, (DDEnumYNFlag)isLast, To_QryPositionSummaryRspField(rsp));
		}

		/**
		* @brief 持仓汇总变化推送通知
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @note 如果不关注此项内容，可以设定Login时的NoticeIgnoreFlag以屏蔽。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnPositionSummary(const TapAPIPositionSummary *rsp) {
			tradeCallback->OnRtnPositionSummary(To_QryPositionSummaryRspField(rsp));
		}

		/**
		* @brief 持仓盈亏通知
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @note 如果不关注此项内容，可以设定Login时的NoticeIgnoreFlag以屏蔽。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnPositionProfit(const TapAPIPositionProfitNotice *rsp) {
			tradeCallback->OnRtnPositionProfit(To_RtnPositionProfitField(rsp));
		}


		/**
		* @brief 返回系统中的币种信息
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_TradeSystem
		*/
		virtual void TAP_CDECL OnRspQryCurrency(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPICurrencyInfo *rsp) {
			tradeCallback->OnRspQryCurrency(sessionID, errorCode, IsLast(isLast), To_QryCurrencyRspField(rsp));
		}

		/**
		* @brief	交易消息通知
		* @details	返回查询的用户资金状态信息。信息说明了用户的资金状态，用户需要仔细查看这些信息。
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据；
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_AccountDetails
		*/
		virtual void TAP_CDECL OnRspQryTradeMessage(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPITradeMessage *rsp) {
			tradeCallback->OnRspQryTradeMessage(sessionID, errorCode, IsLast(isLast), To_QryTradeMessageRspField(rsp));
		}

		/**
		* @brief	交易消息通知
		* @details	用户在交易过程中可能因为资金、持仓、平仓的状态变动使账户处于某些危险状态，或者某些重要的信息需要向用户通知。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_AccountDetails
		*/
		virtual void TAP_CDECL OnRtnTradeMessage(const TapAPITradeMessage *rsp) {
			tradeCallback->OnRtnTradeMessage(To_QryTradeMessageRspField(rsp));
		}

		/**
		* @brief 历史委托查询应答
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisOrder(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisOrderQryRsp *rsp) {
			tradeCallback->OnRspQryHisOrder(sessionID, errorCode, IsLast(isLast), To_QryHisOrderRspField(rsp));
		}

		/**
		* @brief 历史委托流程查询应答
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisOrderProcess(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisOrderProcessQryRsp *info) {
		}

		/**
		* @brief 历史成交查询应答
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisMatch(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisMatchQryRsp *rsp) {
			tradeCallback->OnRspQryHisMatch(sessionID, errorCode, IsLast(isLast), To_QryHisMatchRspField(rsp));
		}

		/**
		* @brief 历史持仓查询应答
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisPosition(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisPositionQryRsp *rsp) {
			tradeCallback->OnRspQryHisPosition(sessionID, errorCode, IsLast(isLast), To_QryHisPositionRspField(rsp));
		}

		/**
		* @brief 历史交割查询应答
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisDelivery(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisDeliveryQryRsp *info) {
		}

		/**
		* @brief 资金调整查询应答
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] isLast 	标示是否是最后一批数据
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryAccountCashAdjust(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIAccountCashAdjustQryRsp *info) {
		}

		/**
		* @brief 查询用户账单应答 Add:2013.12.11
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_Bill
		*/
		virtual void TAP_CDECL OnRspQryBill(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIBillQryRsp *rsp) {
			tradeCallback->OnRspQryBill(sessionID, errorCode, IsLast(isLast), To_QryBillRspField(rsp));
		}

		/**
		* @brief 查询账户手续费计算参数 Add:2017.01.14
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_Rent
		*/
		virtual void TAP_CDECL OnRspQryAccountFeeRent(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIAccountFeeRentQryRsp *rsp) {
			tradeCallback->OnRspQryAccountFeeRent(sessionID, errorCode, IsLast(isLast), To_QryAccountFeeRentRspField(rsp));
		}

		/**
		* @brief 查询账户保证金计算参数 Add:2017.01.14
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_Rent
		*/
		virtual void TAP_CDECL OnRspQryAccountMarginRent(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIAccountMarginRentQryRsp *rsp) {
			tradeCallback->OnRspQryAccountMarginRent(sessionID, errorCode, IsLast(isLast), To_QryAccountMarginRentRspField(rsp));
		}

		/**
		* @brief 港交所做市商双边报价应答 Add:2017.08.29
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HKMarket
		*/
		virtual void TAP_CDECL OnRspHKMarketOrderInsert(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderMarketInsertRsp *info) {
		}

		/**
		* @brief 港交所做市商双边撤单应答 Add:2017.08.29
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HKMarket
		*/
		virtual void TAP_CDECL OnRspHKMarketOrderDelete(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderMarketDeleteRsp *info) {
		}

		/**
		* @brief 港交所询价通知 Add:2017.08.29
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_HKMarket
		*/
		virtual void TAP_CDECL OnHKMarketQuoteNotice(const TapAPIOrderQuoteMarketNotice *info) {
		}

		/**
		* @brief 订单删除应答 Add:2017.12.05
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspOrderLocalRemove(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderLocalRemoveRsp *info) {
		}

		/**
		* @brief 订单录入应答 Add:2017.12.05
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspOrderLocalInput(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderLocalInputRsp *info) {
		}

		/**
		* @brief 订单修改应答 Add:2017.12.05
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspOrderLocalModify(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderLocalModifyRsp *info) {
		}

		/**
		* @brief 订单转移应答 Add:2017.12.05
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspOrderLocalTransfer(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderLocalTransferRsp *info) {
		}

		/**
		* @brief 成交录入应答 Add:2017.12.05
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspFillLocalInput(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIFillLocalInputRsp *info) {
		}

		/** f
		* @brief 订单删除应答 Add:2017.12.05
		* @param[in] sessionID 请求的会话ID；
		* @param[in] errorCode 错误码。0 表示成功。
		* @param[in] info		指向返回的信息结构体。当errorCode不为0时，info为空。
		* @attention 不要修改和删除info所指示的数据；函数调用结束，参数不再有效。
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspFillLocalRemove(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIFillLocalRemoveRsp *info) {
		}

	};


	//---------------------------------------------------------------------
	/// <summary>
	/// 托管类,交易
	/// </summary>
	public ref class DDEsunnyApi :public IDisposable
	{

		static DDEsunnyApi() {
			Check();
		}

		ITapTradeAPI *api;
		EsTradeApiResonse *apiCallback;
		int _reqeutId;
		//-------------------
	public:

		int RequestId() {
			return System::Threading::Interlocked::Increment(_reqeutId);
		}

		//销毁API
		virtual	~DDEsunnyApi() {
			if (nullptr != api) {
				api->Disconnect();
				FreeITapTradeAPI(api);
				if (nullptr != apiCallback) {
					delete apiCallback;
				}
				api = nullptr;
				apiCallback = nullptr;
			}
		}

		DDEsunnyApi() {
		}

		//---------------------------------------------------------------------------------------------my
		//---------------------------------------------------------------------------------------------my
		int CreateApi(String^ authCode, String^ path, DDEsunnyApiCallback^  callback) {
			//no create again
			if (nullptr != api) {
				return 0;
			}
			//
			TapAPIApplicationInfo info = {};
			strcpy(info.AuthCode, CAutoStrPtr(authCode).m_pChar);
			strcpy(info.KeyOperationLogPath, CAutoStrPtr(path).m_pChar);
			//
			int result = 0;
			api = CreateITapTradeAPI(&info, result);
			if (0 == result) {
				apiCallback = new EsTradeApiResonse(callback);
				api->SetAPINotify(apiCallback);
			}
			return result;
		}

		/**
		* @brief	断开和服务器的链路连接。
		* @details	调用函数后API将登出并断开与服务器的连接。
		* @operationtype 同步操作
		* @ingroup G_T_Disconnect
		*/
		virtual int Disconnect() {
			return	api->Disconnect();
		}

		/**
		* @brief 设置服务器的IP地址和端口。
		* @param[in] IP   IP地址
		* @param[in] port 端口号
		* @operationtype 同步操作
		* @ingroup G_T_Login
		*/
		virtual int SetHostAddress(String^ ip, int port) {
			return api->SetHostAddress(CAutoStrPtr(ip).m_pChar, port);
		}

		/**
		* @brief	发起登录请求。API将先连接服务，建立链路，发起登录认证。
		* @details	在使用函数前用户需要完成服务器的设置SetHostAddress()，并且创建TapAPITradeLoginAuth类型的用户信息，
		*			并且需要设置好回调接口。\n
		*			登录过程中建立连接的返回信息通过回调OnConnect返回给用户。\n
		*			连接建立后的用户验证回馈信息通过回调OnLogin()返回给用户。\n
		*			登录成功后API会自动进行API的初始化，API向服务器请求基础数据，查询完以后会通过回调OnAPIReady()
		*			指示用户API初始化完成，可以进行后续的操作了。
		* @param[in] loginAuth 登录验证信息结构指针。包含登录需要的验证信息。
		* @retval 0 登录成功，API开始准备后台数据
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @note TapAPITradeLoginAuth中的NoticeIgnoreFlag用于标记是否忽略特定的通知回调。\n
		*       例如：不需要接收OnRtnFund和OnRtnPositionProfit,可以这么设定：\n
		*       NoticeIgnoreFlag = TAPI_NOTICE_IGNORE_FUND | TAPI_NOTICE_IGNORE_POSITIONPROFIT;
		* @attention Login()函数调用成功只是代表于服务器建立了链路连接，只有回调OnLogin()的返回能指示用户是否成功登录了。
		* @ingroup G_T_Login
		*/
		virtual int Login(DDTradeLoginAuth^ loginAuth) {
			TapAPITradeLoginAuth field = To_ReqLoginField(loginAuth);
			return  api->Login(&field);
		}

		/**
		* @brief	请求发送二次认证认证码
		* @details	此函数需要9.2.7后台，根据回掉函数OnRtnContactInfo中的联系方式，选择其中一个请求二次认证吗，
		*			收到正确应答后可以通过SetVertificateCode 设置二次认证授权码完成登陆过程。
		* @param[out] sessionID本次请求的会话ID。
		* @param[in]  ContractInfo,要接收二次认证吗的邮箱或者电话。
		* @attention 该函数调用需要在登陆应答后返回10003错误，API会回调客户二次 认证的联系方式，用户选择其中一个联系方式（邮箱或者电话）请求二次认证。再通过设置二次认证授权码完成登陆。
		*/
		virtual int RequestVertificateCode(int requestId, String^ ContactInfo)
		{
			TAPIUINT32 sessionID = requestId;
			return api->RequestVertificateCode(&sessionID, CAutoStrPtr(ContactInfo).m_pChar);
		}

		/**
		* @brief	设置二次认证信息。
		* @details	登录完成后，如果系统配置需要进行二次认证码输入，则登录后会提示需要进行二次认证。
		*			此时调用该函数输入二次认证来完成登录。
		*			登录完成后不允许再调用此函数。其他原因引起的登录失败也不能调用次函数，否则会返回对应的错误信息。
		*			调用此接口后，会返回登录应答成功与否的标记，如果成功表示登录完成，可以等待OnAPIReady API完成回调。
		*			如果超时，回调完成后API会主动断开链接，需要再次进行登录操作。
		*			如果验证码错误，则可以再次调用此函数输入正确的验证码进行验证。
		* @param[in] VertificateCode二次认证码。
		* @retval 0 发送认证码成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_Login
		*/
		virtual int SetVertificateCode(String^ VertificateCode)
		{
			return api->SetVertificateCode(CAutoStrPtr(VertificateCode).m_pChar);
		}

		/**
		* @brief	修改密码。
		* @details	成功后用户密码将被设置成newPassword。
		* @param[out]	sessionID 返回此次修改密码的会话ID;
		* @param[in]	req 请求修改密码的结构体指针
		* @retval 0 成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_UserInfo
		*/
		virtual int ChangePassword(int requestId, DDChangePasswordReq^ req) {

			TAPIUINT32 sessionID = requestId;
			TapAPIChangePasswordReq entity = To_ChangePasswordField(req);
			return api->ChangePassword(&sessionID, &entity);
		}


		/**
		* @brief	认证密码。
		* @details	交易员认证某个账户密码是否正确。
		* @param[out]	sessionID 返回此次修改密码的会话ID;
		* @param[in]	req 请求认证密码的结构体指针
		* @retval 0 成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_UserInfo
		*/
		virtual int AuthPassword(int requestId, DDAuthPasswordReq^ req) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAuthPasswordReq entity = To_AuthPasswordField(req);
			//
			return api->AuthPassword(&sessionID, &entity);
		}

		/**
		* @brief 查询用户下属的资金账号
		* @details	TapAPIAccQryReq是包含资金账号结构的结构体，用户需要实例化此结构体，
		*			但是不需要填写，这个结构体主要是用来提醒用户保存资金账号，资金账号
		*			在后续的函数调用中很多函数都需要使用到。
		* @param[out]	sessionID 返回请求的会话ID;
		* @param[in]	qryReq 查询用户下属的资金账号的结构体指针
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_AccountInfo
		*/
		virtual int QryAccount(int requestId, DDAccQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAccQryReq entity = To_QryAccountField(info);
			return api->QryAccount(&sessionID, &entity);
		}

		/**
		* @brief	查询客户资金
		* @details	TapAPIFundReq需要QryAccount()获取的资金账号。
		*			函数的回调将返回资金账号的资金信息。\n
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in] qryReq	查询客户资金请求的结构体指针
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_AccountDetails
		* @attention 每次登陆，该接口只能进行一次调用。建议初始化时调用一次，后续的通知通过OnRtnFund取得。
		*/
		virtual int QryFund(int requestId, DDFundReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIFundReq entity = To_QryFundField(info);
			return api->QryFund(&sessionID, &entity);
		}

		/**
		* @brief 查询交易系统交易所信息
		* @param[out] sessionID 返回请求的会话ID;
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeSystem
		*/
		virtual int QryExchange(int requestId) {
			TAPIUINT32 sessionID = requestId;
			return api->QryExchange(&sessionID);
		}

		/**
		* @brief	查询系统品种信息
		* @details	函数请求获取所有的品种信息。
		* @param[out] sessionID 返回请求的会话ID;
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_Commodity
		*/
		virtual int QryCommodity(int requestId) {
			TAPIUINT32 sessionID = requestId;
			return api->QryCommodity(&sessionID);
		}

		/**
		* @brief	查询系统中指定品种的合约信息
		* @details	使用此函数前需要先Qrycommodity()取得品种信息，
		*			然后选择需要的品种将信息填入TapAPICommodity结构体中完成查询请求。
		*			或者TapAPICommodity不填，则返回所有信息。
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in] qryReq 查询系统中指定品种的合约信息请求的结构体指针;\n
		*				    该参数各字段为可选字段，可以用以下方法查询：\n
		*					1.全部留空：查所有合约\n
		*					2.仅交易所编码有效：查该交易所下所有品种的合约\n
		*					3.交易所编码和品种类型有效：查该交易所下指定品种类型的合约\n
		*					4.交易所编码、品种类型和品种编码都有效：查该品种下的所有合约
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_Contract
		*/
		virtual int QryContract(int requestId, DDCommodity^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPICommodity entity = To_QryContractFiled(info);
			//
			return api->QryContract(&sessionID, &entity);
		}

		/**
		* @brief	下单
		* @details	用户下单的操作函数。
		*			用户的下单操作会造成用户的资金、持仓、平仓、资金、风控标记等多种数据的变化，所以用户下的单成交后，
		*			会有多个回调通知来向用户展示数据的变化。
		* @param[out]	sessionID 返回请求的会话ID;
		* @param[out]	ClientOrderNo 返回客户本地委托号。
		* @param[in]	order 新的委托
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeActions
		*/
		virtual int InsertOrder(int requestId, String^ ClientOrderNo, DDNewOrder^ info) {
			TAPIUINT32 sessionID = requestId;
			TAPISTR_50 nn;
			strcpy(nn, CAutoStrPtr(ClientOrderNo).m_pChar);
			//
			TapAPINewOrder entity = To_InsertOrderField(info);
			return api->InsertOrder(&sessionID, &nn, &entity);
		}

		/**
		* @brief	撤单
		* @details	用户委托没有完全成交之前撤销剩余的委托。
		* @param[out]	sessionID 返回请求的会话ID;
		* @param[in]	order 撤销的委托
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeActions
		*/
		virtual int CancelOrder(int requestId, DDOrderCancelReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIOrderCancelReq entity = To_CancelOrderField(info);
			return api->CancelOrder(&sessionID, &entity);
		}

		/**
		* @brief	改单
		* @details	用户的委托没有完全成交之前可以进行改单操作来修改剩余的未成交的委托。\n
		*			用户填写新的委托来修改原来的未成交的部分。报单的修改会对比已经成交的部分来扣除成交部分。
		* @param[out]	sessionID 返回请求的会话ID;
		* @param[in]	order 修改的委托
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeActions
		*/
		virtual int AmendOrder(int requestId, DDAmendOrder^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAmendOrder entity = To_AmendOrderField(info);
			return api->AmendOrder(&sessionID, &entity);
		}


		/**
		* @brief	查询委托信息
		* @details	返回当前的委托信息，可以查询所有委托，也可以查询所有未结束的委托。\n
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeInfo
		* @attention 每次登陆，该接口只能进行一次调用。建议初始化时调用一次，后续的通知通过OnRtnOrder取得。
		*/
		virtual int QryOrder(int requestId, DDOrderQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIOrderQryReq entity = To_QryOrderField(info);
			return api->QryOrder(&sessionID, &entity);
		}


		/**
		* @brief 查询成交信息
		* @details	查询系统中成交的信息。
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in] qryReq 成交查询信息结构体指针。
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeInfo
		* @attention 每次登陆，该接口只能进行一次调用。建议初始化时调用一次，后续的通知通过OnRtnFill取得。
		*/
		virtual int QryFill(int requestId, DDFillQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIFillQryReq entity = To_QryFillField(info);
			return api->QryFill(&sessionID, &entity);
		}

		/**
		* @brief	查询用户持仓
		* @details	查询用户的所有持仓信息。
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in] qryReq	查询用户持仓请求的结构体指针
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeInfo
		* @attention 每次登陆，该接口只能进行一次调用。建议初始化时调用一次，后续的通知通过OnRtnPosition取得。
		*/
		virtual int QryPosition(int requestId, DDPositionQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIPositionQryReq entity = To_QryPositionField(info);
			return api->QryPosition(&sessionID, &entity);
		}

		/**
		* @brief	查询用户持仓汇总
		* @details	查询用户的所有持仓信息。
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in] qryReq	查询用户持仓请求的结构体指针
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeInfo
		* @attention 每次登陆，该接口只能进行一次调用。建议初始化时调用一次，后续的通知通过OnRtnPosition取得。
		*/
		virtual int QryPositionSummary(int requestId, DDPositionQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIPositionQryReq entity = To_QryPositionSummaryField(info);
			return api->QryPositionSummary(&sessionID, &entity);
		}

		/**
		* @brief 获取交易所用币种的信息
		* @param[out] sessionID 返回请求的会话ID;
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_TradeSystem
		*/
		virtual int QryCurrency(int requestId) {
			TAPIUINT32 sessionID = requestId;
			return api->QryCurrency(&sessionID);
		}


		/**
		* @brief	获取交易或风控消息
		* @details	此函数用来主动获取账号的交易或者风控消息。交易或者风控消息用来标识账号的状态。
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in] qryReq 获取交易或风控消息请求的结构体指针;
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		说明：易盛保留接口
		* @ingroup G_T_AccountDetails
		*/
		virtual int QryTradeMessage(int requestId, DDTradeMessageReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPITradeMessageReq entity = To_QryTradeMessageField(info);
			return api->QryTradeMessage(&sessionID, &entity);
		}

		/**
		* @brief 查询用户账单
		* @param[out]	sessionID 返回请求的会话ID;
		* @param[in]	qryReq	查询帐单请求的结构体指针
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_Bill
		*/
		virtual int QryBill(int requestId, DDBillQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIBillQryReq entity = To_QryBillField(info);
			return api->QryBill(&sessionID, &entity);
		}

		/**
		* @brief 历史委托查询请求
		* @param[out]	sessionID 返回请求的会话ID;
		* @param[in]	Req	历史委托查询请求的结构体指针
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_HisInfo
		*/
		virtual int QryHisOrder(int requestId, DDHisOrderQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIHisOrderQryReq entity = To_QryHisOrderField(info);
			return api->QryHisOrder(&sessionID, &entity);
		}


		/**
		* @brief 历史成交查询请求
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in]	Req	历史成交查询请求的结构体指针
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_HisInfo
		*/
		virtual int QryHisMatch(int requestId, DDHisMatchQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIHisMatchQryReq entity = To_QryHisMatchField(info);
			return api->QryHisMatch(&sessionID, &entity);
		}

		/**
		* @brief 历史持仓查询请求
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in]	Req	历史持仓查询请求的结构体指针
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_HisInfo
		*/
		virtual int QryHisPosition(int requestId, DDHisPositionQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIHisPositionQryReq entity = To_QryHisPositionField(info);
			return api->QryHisPosition(&sessionID, &entity);
		}



		/**
		* @brief 客户手续费计算参数查询请求
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in]	Req	客户手续费计算参数查询请求结构
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_Rent
		*/
		virtual int QryAccountFeeRent(int requestId, DDAccountFeeRentQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAccountFeeRentQryReq entity = To_QryAccountFeeRentField(info);
			return api->QryAccountFeeRent(&sessionID, &entity);
		}

		/**
		* @brief 客户保证金计算参数查询请求
		* @param[out] sessionID 返回请求的会话ID;
		* @param[in]	Req	客户保证金计算参数查询请求结构
		* @retval 0 请求成功
		* @retval 非0 错误码
		* @operationtype 异步操作
		* @ingroup G_T_Rent
		*/
		virtual int QryAccountMarginRent(int requestId, DDAccountMarginRentQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAccountMarginRentQryReq entity = To_QryAccountMarginRentField(info);
			return api->QryAccountMarginRent(&sessionID, &entity);
		}









		//---------------------------------------------------------------------------------------------static
		//---------------------------------------------------------------------------------------------static
	public:

		static String^ GetAPIVersion() {
			String^ str = gcnew String(GetITapTradeAPIVersion());
			return str;
		}

		static	String^  GetErrorDescribe(int iErrcode) {
			return gcnew String(GetITapErrorDescribe(iErrcode));
		}

		static	int  SetAPILogLevel(DDEnumLogLevel level) {
			return SetITapTradeAPILogLevel((TAPILOGLEVEL)level);
		}


		static	int  SetAPIDataPath(String^ path) {
			return SetITapTradeAPIDataPath(CAutoStrPtr(path).m_pChar);
		}

	};

};