#pragma once
#include "Stdafx.h"
#include "Convert.h"
#include "RefHead\iTapTradeAPIDataType.h"
#include <memory>

using namespace System;
using namespace ITapTrade;
using namespace System::Runtime::InteropServices;

namespace global {

	/// 非托管类,自动释放字符串指针内存
	class CAutoStrPtr
	{
	public:
		char* m_pChar;
		//int m_Length;
		CAutoStrPtr(String^ str);
		//CAutoStrPtr(String^ str, void* pDst, int length);
		~CAutoStrPtr();
	};
	String^ ToString(const char *errtext);

	//-------------------------------------------------------------Req
	//-------------------------------------------------------------Req
	//-------------------------------------------------------------Req
	TapAPIChangePasswordReq To_ChangePasswordField(DDChangePasswordReq^ info);

	TapAPIAuthPasswordReq To_AuthPasswordField(DDAuthPasswordReq^ info);

	TapAPIAccQryReq To_QryAccountField(DDAccQryReq^ info);

	TapAPIFundReq To_QryFundField(DDFundReq^ info);

	TapAPICommodity To_QryContractFiled(DDCommodity^ info);

	TapAPINewOrder To_InsertOrderField(DDNewOrder^ info);

	TapAPIOrderCancelReq To_CancelOrderField(DDOrderCancelReq^ info);

	TapAPIAmendOrder To_AmendOrderField(DDAmendOrder^ info);

	TapAPIOrderQryReq To_QryOrderField(DDOrderQryReq^ info);

	TapAPIPositionQryReq To_QryPositionField(DDPositionQryReq^ info);

	TapAPIPositionQryReq To_QryPositionSummaryField(DDPositionQryReq^ info);

	TapAPITradeLoginAuth To_ReqLoginField(DDTradeLoginAuth^ info);

	TapAPIAccountMarginRentQryReq To_QryAccountMarginRentField(DDAccountMarginRentQryReq^ info);

	TapAPIAccountFeeRentQryReq To_QryAccountFeeRentField(DDAccountFeeRentQryReq^ info);

	TapAPIHisPositionQryReq To_QryHisPositionField(DDHisPositionQryReq^ info);

	TapAPIHisMatchQryReq To_QryHisMatchField(DDHisMatchQryReq^ info);

	TapAPIHisOrderQryReq To_QryHisOrderField(DDHisOrderQryReq^ info);

	TapAPIBillQryReq To_QryBillField(DDBillQryReq^ info);

	TapAPITradeMessageReq To_QryTradeMessageField(DDTradeMessageReq^ info);

	TapAPIFillQryReq To_QryFillField(DDFillQryReq^ info);

	//-------------------------------------------------------------Rsp
	//-------------------------------------------------------------Rsp
	//-------------------------------------------------------------Rsp
	DDFundData^ To_QryFundRspField(const TapAPIFundData* entityStrc);

	DDExchangeInfo^ To_QryExchangeRspField(const TapAPIExchangeInfo* entityStrc);

	DDCommodityInfo^ To_QryCommodityRspField(const TapAPICommodityInfo* entityStrc);

	DDTradeContractInfo^ To_QryContractRspField(const TapAPITradeContractInfo* entityStrc);

	DDOrderInfo^ To_QryOrderRspField(const TapAPIOrderInfo* entityStrc);

	DDFillInfo^ To_QryFillRspField(const TapAPIFillInfo* entityStrc);

	DDPositionInfo^ To_QryPositionRspField(const TapAPIPositionInfo* entityStrc);

	DDPositionSummary^ To_QryPositionSummaryRspField(const TapAPIPositionSummary* entityStrc);

	DDCurrencyInfo^ To_QryCurrencyRspField(const TapAPICurrencyInfo* entityStrc);

	DDTradeMessage^ To_QryTradeMessageRspField(const TapAPITradeMessage* entityStrc);

	DDBillQryRsp^ To_QryBillRspField(const TapAPIBillQryRsp* entityStrc);

	DDHisOrderQryRsp^ To_QryHisOrderRspField(const TapAPIHisOrderQryRsp* entityStrc);

	DDHisMatchQryRsp^ To_QryHisMatchRspField(const TapAPIHisMatchQryRsp* entityStrc);

	DDHisPositionQryRsp^ To_QryHisPositionRspField(const TapAPIHisPositionQryRsp* entityStrc);

	DDAccountFeeRentQryRsp^ To_QryAccountFeeRentRspField(const TapAPIAccountFeeRentQryRsp* entityStrc);

	DDAccountMarginRentQryRsp^ To_QryAccountMarginRentRspField(const TapAPIAccountMarginRentQryRsp* entityStrc);

	DDAccountInfo^ To_RspQryAccountField(const TapAPIAccountInfo *entityStrc);

	DDRequestVertificateCodeRsp^ To_RspRequestVertificateCodeField(const TapAPIRequestVertificateCodeRsp *entityStrc);

	DDTradeLoginRspInfo^ To_RspLoginField(const TapAPITradeLoginRspInfo* entityStrc);

	DDOrderActionRsp^ To_QryOrderRspField_2(const TapAPIOrderActionRsp* entityStrc);
	
	DDOrderInfoNotice^ To_QryOrderRspField_3(const TapAPIOrderInfoNotice* entityStrc);

	DDPositionProfitNotice^ To_RtnPositionProfitField(const TapAPIPositionProfitNotice* entityStrc);

	bool IsLast(TAPIYNFLAG flag);

};
