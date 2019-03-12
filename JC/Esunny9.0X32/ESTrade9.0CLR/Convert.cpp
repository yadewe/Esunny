#pragma once
#include "Stdafx.h"
#include "Convert.h"
#include "RefHead\iTapTradeAPIDataType.h"
#include <memory>

using namespace System;
using namespace ITapTrade;
using namespace System::Runtime::InteropServices;
using namespace std;

namespace global {
	CAutoStrPtr::CAutoStrPtr(String^ str)
	{
		if (str != nullptr)
		{
			m_pChar = (char*)Marshal::StringToHGlobalAnsi(str).ToPointer();
			//m_Length = strlen(m_pChar);
		}
		else
			m_pChar = nullptr;
	}

	CAutoStrPtr::~CAutoStrPtr()
	{
		if (m_pChar != nullptr)
			Marshal::FreeHGlobal(IntPtr(m_pChar));
	}

	String^ ToString(const char *errtext)
	{
		return gcnew System::String(errtext);
	}


	//-------------------------------------------------------------Req
	//-------------------------------------------------------------Req
	//-------------------------------------------------------------Req
	TapAPIChangePasswordReq To_ChangePasswordField(DDChangePasswordReq^ info)
	{
		TapAPIChangePasswordReq cinfo = {};
		if (info != nullptr)
		{
			cinfo.PasswordType = (char)info->PasswordType;
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->OldPassword != nullptr)
			{
				strcpy(cinfo.OldPassword, CAutoStrPtr(info->OldPassword).m_pChar);
			}
			if (info->NewPassword != nullptr)
			{
				strcpy(cinfo.NewPassword, CAutoStrPtr(info->NewPassword).m_pChar);
			}
		}
		return cinfo;
	};



	TapAPIAuthPasswordReq To_AuthPasswordField(DDAuthPasswordReq^ info)
	{
		TapAPIAuthPasswordReq cinfo = {};
		if (info != nullptr)
		{
			cinfo.PasswordType = (char)info->PasswordType;
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->Password != nullptr)
			{
				strcpy(cinfo.Password, CAutoStrPtr(info->Password).m_pChar);
			}
		}
		return cinfo;
	};

	TapAPIAccQryReq To_QryAccountField(DDAccQryReq^ info)
	{
		TapAPIAccQryReq cinfo = {};
		return cinfo;

	};


	TapAPIFundReq To_QryFundField(DDFundReq^ info)
	{
		TapAPIFundReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
		}
		return cinfo;
	};


	TapAPICommodity To_QryContractFiled(DDCommodity^ info)
	{
		TapAPICommodity cinfo = {};
		if (info != nullptr)
		{
			cinfo.CommodityType = (char)info->CommodityType;
			if (info->ExchangeNo != nullptr)
			{
				strcpy(cinfo.ExchangeNo, CAutoStrPtr(info->ExchangeNo).m_pChar);
			}
			if (info->CommodityNo != nullptr)
			{
				strcpy(cinfo.CommodityNo, CAutoStrPtr(info->CommodityNo).m_pChar);
			}
		}
		return cinfo;
	};


	TapAPINewOrder To_InsertOrderField(DDNewOrder^ info)
	{
		TapAPINewOrder cinfo = {};
		if (info != nullptr)
		{
			cinfo.CommodityType = (char)info->CommodityType;
			cinfo.CallOrPutFlag = (char)info->CallOrPutFlag;
			cinfo.CallOrPutFlag2 = (char)info->CallOrPutFlag2;
			cinfo.OrderType = (char)info->OrderType;
			cinfo.OrderSource = (char)info->OrderSource;
			cinfo.TimeInForce = (char)info->TimeInForce;
			cinfo.IsRiskOrder = (char)info->IsRiskOrder;
			cinfo.OrderSide = (char)info->OrderSide;
			cinfo.PositionEffect = (char)info->PositionEffect;
			cinfo.PositionEffect2 = (char)info->PositionEffect2;
			cinfo.HedgeFlag = (char)info->HedgeFlag;
			cinfo.TacticsType = (char)info->TacticsType;
			cinfo.TriggerCondition = (char)info->TriggerCondition;
			cinfo.TriggerPriceType = (char)info->TriggerPriceType;
			cinfo.AddOneIsValid = (char)info->AddOneIsValid;

			cinfo.OrderPrice = info->OrderPrice;
			cinfo.OrderPrice2 = info->OrderPrice2;
			cinfo.StopPrice = info->StopPrice;
			cinfo.OrderQty = info->OrderQty;
			cinfo.OrderMinQty = info->OrderMinQty;
			cinfo.MinClipSize = info->MinClipSize;
			cinfo.MaxClipSize = info->MaxClipSize;
			cinfo.RefInt = info->RefInt;
			cinfo.RefDouble = info->RefDouble;
			if (info->RefString != nullptr)
			{
				strcpy(cinfo.RefString, CAutoStrPtr(info->RefString).m_pChar);
			}
			if (info->ClientID != nullptr)
			{
				strcpy(cinfo.ClientID, CAutoStrPtr(info->ClientID).m_pChar);
			}
			if (info->ExchangeNo != nullptr)
			{
				strcpy(cinfo.ExchangeNo, CAutoStrPtr(info->ExchangeNo).m_pChar);
			}
			if (info->InquiryNo != nullptr)
			{
				strcpy(cinfo.InquiryNo, CAutoStrPtr(info->InquiryNo).m_pChar);
			}
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->CommodityNo != nullptr)
			{
				strcpy(cinfo.CommodityNo, CAutoStrPtr(info->CommodityNo).m_pChar);
			}
			if (info->ContractNo != nullptr)
			{
				strcpy(cinfo.ContractNo, CAutoStrPtr(info->ContractNo).m_pChar);
			}
			if (info->StrikePrice != nullptr)
			{
				strcpy(cinfo.StrikePrice, CAutoStrPtr(info->StrikePrice).m_pChar);
			}
			if (info->ContractNo2 != nullptr)
			{
				strcpy(cinfo.ContractNo2, CAutoStrPtr(info->ContractNo2).m_pChar);
			}
			if (info->StrikePrice2 != nullptr)
			{
				strcpy(cinfo.StrikePrice2, CAutoStrPtr(info->StrikePrice2).m_pChar);
			}
			if (info->ExpireTime != nullptr)
			{
				strcpy(cinfo.ExpireTime, CAutoStrPtr(info->ExpireTime).m_pChar);
			}
		}
		return cinfo;
	};


	TapAPIOrderCancelReq To_CancelOrderField(DDOrderCancelReq^ info)
	{
		TapAPIOrderCancelReq cinfo = {};

		if (info != nullptr)
		{
			cinfo.ServerFlag = (char)info->ServerFlag;

			cinfo.RefInt = info->RefInt;
			cinfo.RefDouble = info->RefDouble;
			if (info->RefString != nullptr)
			{
				strcpy(cinfo.RefString, CAutoStrPtr(info->RefString).m_pChar);
			}
			if (info->OrderNo != nullptr)
			{
				strcpy(cinfo.OrderNo, CAutoStrPtr(info->OrderNo).m_pChar);
			}
		}
		return cinfo;
	};


	TapAPIAmendOrder To_AmendOrderField(DDAmendOrder^ info)
	{
		TapAPIAmendOrder cinfo = {};
		if (info != nullptr)
		{
			TapAPINewOrder cinfo2 = {};
			DDNewOrder ^ info2 = info->ReqData;
			if (info2 != nullptr)
			{
				cinfo2.CommodityType = (char)info2->CommodityType;
				cinfo2.CallOrPutFlag = (char)info2->CallOrPutFlag;
				cinfo2.CallOrPutFlag2 = (char)info2->CallOrPutFlag2;
				cinfo2.OrderType = (char)info2->OrderType;
				cinfo2.OrderSource = (char)info2->OrderSource;
				cinfo2.TimeInForce = (char)info2->TimeInForce;
				cinfo2.IsRiskOrder = (char)info2->IsRiskOrder;
				cinfo2.OrderSide = (char)info2->OrderSide;
				cinfo2.PositionEffect = (char)info2->PositionEffect;
				cinfo2.PositionEffect2 = (char)info2->PositionEffect2;
				cinfo2.HedgeFlag = (char)info2->HedgeFlag;
				cinfo2.TacticsType = (char)info2->TacticsType;
				cinfo2.TriggerCondition = (char)info2->TriggerCondition;
				cinfo2.TriggerPriceType = (char)info2->TriggerPriceType;
				cinfo2.AddOneIsValid = (char)info2->AddOneIsValid;

				cinfo2.OrderPrice = info2->OrderPrice;
				cinfo2.OrderPrice2 = info2->OrderPrice2;
				cinfo2.StopPrice = info2->StopPrice;
				cinfo2.OrderQty = info2->OrderQty;
				cinfo2.OrderMinQty = info2->OrderMinQty;
				cinfo2.MinClipSize = info2->MinClipSize;
				cinfo2.MaxClipSize = info2->MaxClipSize;
				cinfo2.RefInt = info2->RefInt;
				cinfo2.RefDouble = info2->RefDouble;
				if (info2->RefString != nullptr)
				{
					strcpy(cinfo2.RefString, CAutoStrPtr(info2->RefString).m_pChar);
				}
				if (info2->ClientID != nullptr)
				{
					strcpy(cinfo2.ClientID, CAutoStrPtr(info2->ClientID).m_pChar);
				}
				if (info2->ExchangeNo != nullptr)
				{
					strcpy(cinfo2.ExchangeNo, CAutoStrPtr(info2->ExchangeNo).m_pChar);
				}
				if (info2->InquiryNo != nullptr)
				{
					strcpy(cinfo2.InquiryNo, CAutoStrPtr(info2->InquiryNo).m_pChar);
				}
				if (info2->AccountNo != nullptr)
				{
					strcpy(cinfo2.AccountNo, CAutoStrPtr(info2->AccountNo).m_pChar);
				}
				if (info2->CommodityNo != nullptr)
				{
					strcpy(cinfo2.CommodityNo, CAutoStrPtr(info2->CommodityNo).m_pChar);
				}
				if (info2->ContractNo != nullptr)
				{
					strcpy(cinfo2.ContractNo, CAutoStrPtr(info2->ContractNo).m_pChar);
				}
				if (info2->StrikePrice != nullptr)
				{
					strcpy(cinfo2.StrikePrice, CAutoStrPtr(info2->StrikePrice).m_pChar);
				}
				if (info2->ContractNo2 != nullptr)
				{
					strcpy(cinfo2.ContractNo2, CAutoStrPtr(info2->ContractNo2).m_pChar);
				}
				if (info2->StrikePrice2 != nullptr)
				{
					strcpy(cinfo2.StrikePrice2, CAutoStrPtr(info2->StrikePrice2).m_pChar);
				}
				if (info2->ExpireTime != nullptr)
				{
					strcpy(cinfo2.ExpireTime, CAutoStrPtr(info2->ExpireTime).m_pChar);
				}
			}
			cinfo.ReqData = cinfo2;
			cinfo.ServerFlag = (char)info->ServerFlag;
			if (info->OrderNo != nullptr)
			{
				strcpy(cinfo.OrderNo, CAutoStrPtr(info->OrderNo).m_pChar);
			}
		}
		return cinfo;
	};

	//To_QryFillField

	TapAPIOrderQryReq To_QryOrderField(DDOrderQryReq^ info)
	{
		TapAPIOrderQryReq cinfo = {};
		if (info != nullptr)
		{
			cinfo.CommodityType = (char)info->CommodityType;
			cinfo.OrderType = (char)info->OrderType;
			cinfo.OrderSource = (char)info->OrderSource;
			cinfo.TimeInForce = (char)info->TimeInForce;
			cinfo.IsRiskOrder = (char)info->IsRiskOrder;
			cinfo.ServerFlag = (char)info->ServerFlag;
			cinfo.IsBackInput = (char)info->IsBackInput;
			cinfo.IsDeleted = (char)info->IsDeleted;
			cinfo.IsAddOne = (char)info->IsAddOne;
			if (info->OrderNo != nullptr)
			{
				strcpy(cinfo.OrderNo, CAutoStrPtr(info->OrderNo).m_pChar);
			}
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->ExchangeNo != nullptr)
			{
				strcpy(cinfo.ExchangeNo, CAutoStrPtr(info->ExchangeNo).m_pChar);
			}
			if (info->CommodityNo != nullptr)
			{
				strcpy(cinfo.CommodityNo, CAutoStrPtr(info->CommodityNo).m_pChar);
			}
			if (info->ExpireTime != nullptr)
			{
				strcpy(cinfo.ExpireTime, CAutoStrPtr(info->ExpireTime).m_pChar);
			}
		}
		return cinfo;
	};


	//TapAPIOrderQryReq To_QryOrderField(DDOrderQryReq^ info)
	//{
	//	//如上函数 To_QryOrderField
	//	return To_QryOrderField(info);
	//}


	TapAPIPositionQryReq To_QryPositionField(DDPositionQryReq^ info)
	{
		TapAPIPositionQryReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
		}
		return cinfo;
	};


	TapAPIPositionQryReq To_QryPositionSummaryField(DDPositionQryReq^ info)
	{
		//同上函数 To_QryPositionField
		return To_QryPositionField(info);
	};



	TapAPITradeLoginAuth To_ReqLoginField(DDTradeLoginAuth^ info)
	{
		TapAPITradeLoginAuth cinfo = {};
		if (info != nullptr)
		{
			cinfo.ISModifyPassword = (char)info->ISModifyPassword;
			if (info->UserNo != nullptr)
			{
				strcpy(cinfo.UserNo, CAutoStrPtr(info->UserNo).m_pChar);
			}
			if (info->Password != nullptr)
			{
				strcpy(cinfo.Password, CAutoStrPtr(info->Password).m_pChar);
			}
			if (info->NewPassword != nullptr)
			{
				strcpy(cinfo.NewPassword, CAutoStrPtr(info->NewPassword).m_pChar);
			}
		}
		return cinfo;
	};


	TapAPIAccountMarginRentQryReq To_QryAccountMarginRentField(DDAccountMarginRentQryReq^ info)
	{
		TapAPIAccountMarginRentQryReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->ExchangeNo != nullptr)
			{
				strcpy(cinfo.ExchangeNo, CAutoStrPtr(info->ExchangeNo).m_pChar);
			}
			cinfo.CommodityType = (char)info->CommodityType;
			if (info->CommodityNo != nullptr)
			{
				strcpy(cinfo.CommodityNo, CAutoStrPtr(info->CommodityNo).m_pChar);
			}
		}
		return cinfo;
	};

	TapAPIAccountFeeRentQryReq To_QryAccountFeeRentField(DDAccountFeeRentQryReq^ info)
	{
		TapAPIAccountFeeRentQryReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
		}
		return cinfo;
	};

	TapAPIHisPositionQryReq To_QryHisPositionField(DDHisPositionQryReq^ info)
	{
		TapAPIHisPositionQryReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->Date != nullptr)
			{
				strcpy(cinfo.Date, CAutoStrPtr(info->Date).m_pChar);
			}
			cinfo.SettleFlag = (char)info->SettleFlag;
		}
		return cinfo;
	};


	TapAPIHisMatchQryReq To_QryHisMatchField(DDHisMatchQryReq^ info)
	{
		TapAPIHisMatchQryReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->AccountAttributeNo != nullptr)
			{
				strcpy(cinfo.AccountAttributeNo, CAutoStrPtr(info->AccountAttributeNo).m_pChar);
			}
			if (info->BeginDate != nullptr)
			{
				strcpy(cinfo.BeginDate, CAutoStrPtr(info->BeginDate).m_pChar);
			}
			if (info->EndDate != nullptr)
			{
				strcpy(cinfo.EndDate, CAutoStrPtr(info->EndDate).m_pChar);
			}
			cinfo.CountType = (char)info->CountType;
		}
		return cinfo;
	};


	TapAPIHisOrderQryReq To_QryHisOrderField(DDHisOrderQryReq^ info)
	{
		TapAPIHisOrderQryReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->AccountAttributeNo != nullptr)
			{
				strcpy(cinfo.AccountAttributeNo, CAutoStrPtr(info->AccountAttributeNo).m_pChar);
			}
			if (info->BeginDate != nullptr)
			{
				strcpy(cinfo.BeginDate, CAutoStrPtr(info->BeginDate).m_pChar);
			}
			if (info->EndDate != nullptr)
			{
				strcpy(cinfo.EndDate, CAutoStrPtr(info->EndDate).m_pChar);
			}
		}
		return cinfo;
	};


	TapAPIBillQryReq To_QryBillField(DDBillQryReq^ info)
	{
		TapAPIBillQryReq cinfo = {};
		if (info != nullptr)
		{
			if (info->UserNo != nullptr)
			{
				strcpy(cinfo.UserNo, CAutoStrPtr(info->UserNo).m_pChar);
			}
			cinfo.BillType = (char)info->BillType;
			if (info->BillDate != nullptr)
			{
				strcpy(cinfo.BillDate, CAutoStrPtr(info->BillDate).m_pChar);
			}
			cinfo.BillFileType = (char)info->BillFileType;
		}
		return cinfo;
	};


	TapAPITradeMessageReq To_QryTradeMessageField(DDTradeMessageReq^ info)
	{
		TapAPITradeMessageReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->AccountAttributeNo != nullptr)
			{
				strcpy(cinfo.AccountAttributeNo, CAutoStrPtr(info->AccountAttributeNo).m_pChar);
			}
			if (info->BenginSendDateTime != nullptr)
			{
				strcpy(cinfo.BenginSendDateTime, CAutoStrPtr(info->BenginSendDateTime).m_pChar);
			}
			if (info->EndSendDateTime != nullptr)
			{
				strcpy(cinfo.EndSendDateTime, CAutoStrPtr(info->EndSendDateTime).m_pChar);
			}
		}
		return cinfo;
	};


	TapAPIFillQryReq To_QryFillField(DDFillQryReq^ info)
	{
		TapAPIFillQryReq cinfo = {};
		if (info != nullptr)
		{
			if (info->AccountNo != nullptr)
			{
				strcpy(cinfo.AccountNo, CAutoStrPtr(info->AccountNo).m_pChar);
			}
			if (info->ExchangeNo != nullptr)
			{
				strcpy(cinfo.ExchangeNo, CAutoStrPtr(info->ExchangeNo).m_pChar);
			}
			cinfo.CommodityType = (char)info->CommodityType;
			if (info->CommodityNo != nullptr)
			{
				strcpy(cinfo.CommodityNo, CAutoStrPtr(info->CommodityNo).m_pChar);
			}
			if (info->ContractNo != nullptr)
			{
				strcpy(cinfo.ContractNo, CAutoStrPtr(info->ContractNo).m_pChar);
			}
			if (info->StrikePrice != nullptr)
			{
				strcpy(cinfo.StrikePrice, CAutoStrPtr(info->StrikePrice).m_pChar);
			}
			cinfo.CallOrPutFlag = (char)info->CallOrPutFlag;
			cinfo.MatchSource = (char)info->MatchSource;
			cinfo.MatchSide = (char)info->MatchSide;
			cinfo.PositionEffect = (char)info->PositionEffect;
			cinfo.ServerFlag = (char)info->ServerFlag;
			if (info->OrderNo != nullptr)
			{
				strcpy(cinfo.OrderNo, CAutoStrPtr(info->OrderNo).m_pChar);
			}
			if (info->UpperNo != nullptr)
			{
				strcpy(cinfo.UpperNo, CAutoStrPtr(info->UpperNo).m_pChar);
			}
			cinfo.IsDeleted = (char)info->IsDeleted;
			cinfo.IsAddOne = (char)info->IsAddOne;
		}
		return cinfo;
	}

	bool IsLast(TAPIYNFLAG flag)
	{
		if (flag == APIYNFLAG_YES)
			return true;
		return false;
	}




	//-------------------------------------------------------------Rsp
	//-------------------------------------------------------------Rsp
	//-------------------------------------------------------------Rsp

	DDTradeLoginRspInfo^ To_RspLoginField(const TapAPITradeLoginRspInfo* entityStrc)
	{
		DDTradeLoginRspInfo^ entity = gcnew DDTradeLoginRspInfo();
		if (entityStrc != nullptr)
		{
			entity->UserNo = gcnew String(entityStrc->UserNo);
			entity->UserType = (DDEnumUserTypeType)(entityStrc->UserType);
			entity->UserName = gcnew String(entityStrc->UserName);
			entity->ReservedInfo = gcnew String(entityStrc->ReservedInfo);
			entity->LastLoginIP = gcnew String(entityStrc->LastLoginIP);
			entity->LastLoginProt = entityStrc->LastLoginProt;
			entity->LastLoginTime = gcnew String(entityStrc->LastLoginTime);
			entity->LastLogoutTime = gcnew String(entityStrc->LastLogoutTime);
			entity->TradeDate = gcnew String(entityStrc->TradeDate);
			entity->LastSettleTime = gcnew String(entityStrc->LastSettleTime);
			entity->StartTime = gcnew String(entityStrc->StartTime);
			entity->InitTime = gcnew String(entityStrc->InitTime);
		}
		return entity;
	};

	DDRequestVertificateCodeRsp^ To_RspRequestVertificateCodeField(const TapAPIRequestVertificateCodeRsp *entityStrc)
	{
		DDRequestVertificateCodeRsp^ entity = gcnew DDRequestVertificateCodeRsp();
		if (entityStrc != nullptr)
		{
			entity->SecondSerialID = gcnew String(entityStrc->SecondSerialID);
			entity->Effective = entityStrc->Effective;
		}
		return entity;
	};


	DDAccountInfo^ To_RspQryAccountField(const TapAPIAccountInfo *entityStrc)
	{
		DDAccountInfo^ entity = gcnew DDAccountInfo();
		if (entityStrc != nullptr)
		{
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->AccountType = (DDEnumAccountType)(entityStrc->AccountType);
			entity->AccountState = (DDEnumAccountState)(entityStrc->AccountState);
			entity->AccountTradeRight = (DDEnumAccountRightType)(entityStrc->AccountTradeRight);
			entity->CommodityGroupNo = gcnew String(entityStrc->CommodityGroupNo);
			entity->AccountShortName = gcnew String(entityStrc->AccountShortName);
			entity->AccountEnShortName = gcnew String(entityStrc->AccountEnShortName);
		}
		return entity;
	};


	DDAccountMarginRentQryRsp^ To_QryAccountMarginRentRspField(const TapAPIAccountMarginRentQryRsp* entityStrc)
	{
		DDAccountMarginRentQryRsp ^ entity = gcnew DDAccountMarginRentQryRsp();
		if (nullptr != entityStrc)
		{
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo = gcnew String(entityStrc->ContractNo);
			entity->StrikePrice = gcnew String(entityStrc->StrikePrice);
			entity->CallOrPutFlag = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag;
			entity->CalculateMode = (DDEnumCalculateModeType)entityStrc->CalculateMode;
			entity->CurrencyGroupNo = gcnew String(entityStrc->CurrencyGroupNo);
			entity->CurrencyNo = gcnew String(entityStrc->CurrencyNo);
			entity->InitialMargin = entityStrc->InitialMargin;
			entity->MaintenanceMargin = entityStrc->MaintenanceMargin;
			entity->SellInitialMargin = entityStrc->SellInitialMargin;
			entity->SellMaintenanceMargin = entityStrc->SellMaintenanceMargin;
			entity->LockMargin = entityStrc->LockMargin;
		}
		return entity;
	};

	DDAccountFeeRentQryRsp^ To_QryAccountFeeRentRspField(const TapAPIAccountFeeRentQryRsp* entityStrc)
	{
		DDAccountFeeRentQryRsp ^ entity = gcnew DDAccountFeeRentQryRsp();
		if (nullptr != entityStrc)
		{
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->MatchSource = (DDEnumMatchSourceType)entityStrc->MatchSource;
			entity->CalculateMode = (DDEnumCalculateModeType)entityStrc->CalculateMode;
			entity->CurrencyGroupNo = gcnew String(entityStrc->CurrencyGroupNo);
			entity->CurrencyNo = gcnew String(entityStrc->CurrencyNo);
			entity->OpenCloseFee = entityStrc->OpenCloseFee;
			entity->CloseTodayFee = entityStrc->CloseTodayFee;
		}
		return entity;
	};

	DDHisPositionQryRsp^ To_QryHisPositionRspField(const TapAPIHisPositionQryRsp* entityStrc)
	{
		DDHisPositionQryRsp ^ entity = gcnew DDHisPositionQryRsp();
		if (nullptr != entityStrc)
		{
			entity->SettleDate = gcnew String(entityStrc->SettleDate);
			entity->OpenDate = gcnew String(entityStrc->OpenDate);
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo = gcnew String(entityStrc->ContractNo);
			entity->StrikePrice = gcnew String(entityStrc->StrikePrice);
			entity->CallOrPutFlag = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag;
			entity->MatchSide = (DDEnumSideType)entityStrc->MatchSide;
			entity->HedgeFlag = (DDEnumHedgeFlagType)entityStrc->HedgeFlag;
			entity->PositionPrice = entityStrc->PositionPrice;
			entity->PositionQty = entityStrc->PositionQty;
			entity->OrderNo = gcnew String(entityStrc->OrderNo);
			entity->PositionNo = gcnew String(entityStrc->PositionNo);
			entity->UpperNo = gcnew String(entityStrc->UpperNo);
			entity->CurrencyGroup = gcnew String(entityStrc->CurrencyGroup);
			entity->Currency = gcnew String(entityStrc->Currency);
			entity->PreSettlePrice = entityStrc->PreSettlePrice;
			entity->SettlePrice = entityStrc->SettlePrice;
			entity->PositionDProfit = entityStrc->PositionDProfit;
			entity->LMEPositionProfit = entityStrc->LMEPositionProfit;
			entity->OptionMarketValue = entityStrc->OptionMarketValue;
			entity->AccountInitialMargin = entityStrc->AccountInitialMargin;
			entity->UpperInitialMargin = entityStrc->UpperInitialMargin;
			entity->UpperMaintenanceMargin = entityStrc->UpperMaintenanceMargin;
			entity->SettleGroupNo = gcnew String(entityStrc->SettleGroupNo);
		}
		return entity;
	};

	DDHisMatchQryRsp^ To_QryHisMatchRspField(const TapAPIHisMatchQryRsp* entityStrc)
	{
		DDHisMatchQryRsp ^ entity = gcnew DDHisMatchQryRsp();
		if (nullptr != entityStrc)
		{
			entity->SettleDate = gcnew String(entityStrc->SettleDate);
			entity->TradeDate = gcnew String(entityStrc->TradeDate);
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo = gcnew String(entityStrc->ContractNo);
			entity->StrikePrice = gcnew String(entityStrc->StrikePrice);
			entity->CallOrPutFlag = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag;
			entity->MatchSource = (DDEnumMatchSourceType)entityStrc->MatchSource;
			entity->MatchSide = (DDEnumSideType)entityStrc->MatchSide;
			entity->PositionEffect = (DDEnumPositionEffectType)entityStrc->PositionEffect;
			entity->HedgeFlag = (DDEnumHedgeFlagType)entityStrc->HedgeFlag;
			entity->MatchPrice = entityStrc->MatchPrice;
			entity->MatchQty = entityStrc->MatchQty;
			entity->OrderNo = gcnew String(entityStrc->OrderNo);
			entity->MatchNo = gcnew String(entityStrc->MatchNo);
			entity->MatchStreamID = entityStrc->MatchStreamID;
			entity->UpperNo = gcnew String(entityStrc->UpperNo);
			entity->MatchCmbNo = gcnew String(entityStrc->MatchCmbNo);
			entity->ExchangeMatchNo = gcnew String(entityStrc->ExchangeMatchNo);
			entity->MatchUpperStreamID = entityStrc->MatchUpperStreamID;
			entity->CommodityCurrencyGroup = gcnew String(entityStrc->CommodityCurrencyGroup);
			entity->CommodityCurrency = gcnew String(entityStrc->CommodityCurrency);
			entity->Turnover = entityStrc->Turnover;
			entity->PremiumIncome = entityStrc->PremiumIncome;
			entity->PremiumPay = entityStrc->PremiumPay;
			entity->AccountFee = entityStrc->AccountFee;
			entity->AccountFeeCurrencyGroup = gcnew String(entityStrc->AccountFeeCurrencyGroup);
			entity->AccountFeeCurrency = gcnew String(entityStrc->AccountFeeCurrency);
			entity->IsManualFee = entityStrc->IsManualFee;
			entity->UpperFee = entityStrc->UpperFee;
			entity->UpperFeeCurrencyGroup = gcnew String(entityStrc->UpperFeeCurrencyGroup);
			entity->UpperFeeCurrency = gcnew String(entityStrc->UpperFeeCurrency);
			entity->IsUpperManualFee = (DDEnumYNFlag)entityStrc->IsUpperManualFee;
			entity->UpperOtherFee = entityStrc->UpperOtherFee;
			entity->MatchDateTime = gcnew String(entityStrc->MatchDateTime);
			entity->UpperMatchDateTime = gcnew String(entityStrc->UpperMatchDateTime);
			entity->CloseProfit = entityStrc->CloseProfit;
			entity->ClosePrice = entityStrc->ClosePrice;
			entity->CloseQty = entityStrc->CloseQty;
			entity->SettleGroupNo = gcnew String(entityStrc->SettleGroupNo);
			entity->OperatorNo = gcnew String(entityStrc->OperatorNo);
			entity->OperateTime = gcnew String(entityStrc->OperateTime);
		}
		return entity;
	};

	DDHisOrderQryRsp^ To_QryHisOrderRspField(const TapAPIHisOrderQryRsp* entityStrc)
	{
		DDHisOrderQryRsp ^ entity = gcnew DDHisOrderQryRsp();
		if (nullptr != entityStrc)
		{
			entity->Date = gcnew String(entityStrc->Date);
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo = gcnew String(entityStrc->ContractNo);
			entity->StrikePrice = gcnew String(entityStrc->StrikePrice);
			entity->CallOrPutFlag = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag;
			entity->ContractNo2 = gcnew String(entityStrc->ContractNo2);
			entity->StrikePrice2 = gcnew String(entityStrc->StrikePrice2);
			entity->CallOrPutFlag2 = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag2;
			entity->OrderType = (DDEnumOrderTypeType)entityStrc->OrderType;
			entity->OrderSource = (DDEnumOrderSourceType)entityStrc->OrderSource;
			entity->TimeInForce = (DDEnumTimeInForceType)entityStrc->TimeInForce;
			entity->ExpireTime = gcnew String(entityStrc->ExpireTime);
			entity->IsRiskOrder = (DDEnumYNFlag)entityStrc->IsRiskOrder;
			entity->OrderSide = (DDEnumSideType)entityStrc->OrderSide;
			entity->PositionEffect = (DDEnumPositionEffectType)entityStrc->PositionEffect;
			entity->PositionEffect2 = (DDEnumPositionEffectType)entityStrc->PositionEffect2;
			entity->InquiryNo = gcnew String(entityStrc->InquiryNo);
			entity->HedgeFlag = (DDEnumHedgeFlagType)entityStrc->HedgeFlag;
			entity->OrderPrice = entityStrc->OrderPrice;
			entity->OrderPrice2 = entityStrc->OrderPrice2;
			entity->StopPrice = (entityStrc->StopPrice);
			entity->OrderQty = (entityStrc->OrderQty);
			entity->OrderMinQty = entityStrc->OrderMinQty;
			entity->OrderCanceledQty = entityStrc->OrderCanceledQty;
			entity->RefInt = entityStrc->RefInt;
			entity->RefDouble = entityStrc->RefDouble;
			entity->RefString = gcnew String(entityStrc->RefString);
			entity->ServerFlag = entityStrc->ServerFlag;
			entity->OrderNo = gcnew String(entityStrc->OrderNo);
			entity->OrderStreamID = entityStrc->OrderStreamID;
			entity->UpperNo = gcnew String(entityStrc->UpperNo);
			entity->UpperChannelNo = gcnew String(entityStrc->UpperChannelNo);
			entity->OrderLocalNo = gcnew String(entityStrc->OrderLocalNo);
			entity->UpperStreamID = entityStrc->UpperStreamID;
			entity->OrderSystemNo = gcnew String(entityStrc->OrderSystemNo);
			entity->OrderExchangeSystemNo = gcnew String(entityStrc->OrderExchangeSystemNo);
			entity->OrderParentSystemNo = gcnew String(entityStrc->OrderParentSystemNo);
			entity->OrderInsertUserNo = gcnew String(entityStrc->OrderInsertUserNo);
			entity->OrderInsertTime = gcnew String(entityStrc->OrderInsertTime);
			entity->OrderCommandUserNo = gcnew String(entityStrc->OrderCommandUserNo);
			entity->OrderUpdateUserNo = gcnew String(entityStrc->OrderUpdateUserNo);
			entity->OrderUpdateTime = gcnew String(entityStrc->OrderUpdateTime);
			entity->OrderState = (DDEnumOrderStateType)entityStrc->OrderState;
			entity->OrderMatchPrice = entityStrc->OrderMatchPrice;
			entity->OrderMatchPrice2 = entityStrc->OrderMatchPrice2;
			entity->OrderMatchQty = entityStrc->OrderMatchQty;
			entity->OrderMatchQty2 = entityStrc->OrderMatchQty2;
			entity->ErrorCode = entityStrc->ErrorCode;
			entity->ErrorText = gcnew String(entityStrc->ErrorText);
			entity->IsBackInput = (DDEnumYNFlag)entityStrc->IsBackInput;
			entity->IsDeleted = (DDEnumYNFlag)entityStrc->IsDeleted;
			entity->IsAddOne = (DDEnumYNFlag)entityStrc->IsAddOne;
			entity->AddOneIsValid = (DDEnumYNFlag)entityStrc->AddOneIsValid;
			entity->MinClipSize = entityStrc->MinClipSize;
			entity->MaxClipSize = entityStrc->MaxClipSize;
			entity->LicenseNo = gcnew String(entityStrc->LicenseNo);
			entity->TacticsType = (DDEnumTacticsTypeType)entityStrc->TacticsType;
			entity->TriggerCondition = (DDEnumTriggerConditionType)entityStrc->TriggerCondition;
			entity->TriggerPriceType = (DDEnumTriggerPriceTypeType)entityStrc->TriggerPriceType;
		}
		return entity;
	};

	DDBillQryRsp^ To_QryBillRspField(const TapAPIBillQryRsp* entityStrc)
	{
		DDBillQryRsp ^ entity = gcnew DDBillQryRsp();
		if (nullptr != entityStrc)
		{
			DDBillQryReq^ entity2 = gcnew DDBillQryReq();
			entity2->UserNo = gcnew String(entityStrc->Reqdata.UserNo);
			entity2->BillDate = gcnew String(entityStrc->Reqdata.BillDate);
			entity2->BillType = (DDEnumBillTypeType)entityStrc->Reqdata.BillType;
			entity2->BillFileType = (DDEnumBillFileTypeType)entityStrc->Reqdata.BillFileType;
			//
			entity->Reqdata = entity2;

			entity->BillLen = entityStrc->BillLen;
			entity->BillText = gcnew String(entityStrc->BillText);
		}
		return entity;
	};

	DDTradeMessage^ To_QryTradeMessageRspField(const TapAPITradeMessage* entityStrc)
	{
		DDTradeMessage ^ entity = gcnew DDTradeMessage();
		if (nullptr != entityStrc)
		{
			entity->SerialID = entityStrc->SerialID;
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->TMsgValidDateTime = gcnew String(entityStrc->TMsgValidDateTime);
			entity->TMsgTitle = gcnew String(entityStrc->TMsgTitle);
			entity->TMsgContent = gcnew String(entityStrc->TMsgContent);
			entity->TMsgType = (DDEnumMsgTypeType)entityStrc->TMsgType;
			entity->TMsgLevel = (DDEnumMsgLevelType)entityStrc->TMsgLevel;
			entity->IsSendBySMS = (DDEnumYNFlag)entityStrc->IsSendBySMS;
			entity->IsSendByEMail = (DDEnumYNFlag)entityStrc->IsSendByEMail;
			entity->Sender = gcnew String(entityStrc->Sender);
			entity->SendDateTime = gcnew String(entityStrc->SendDateTime);
		}
		return entity;
	};

	DDCurrencyInfo^ To_QryCurrencyRspField(const TapAPICurrencyInfo* entityStrc)
	{
		DDCurrencyInfo ^ entity = gcnew DDCurrencyInfo();
		if (nullptr != entityStrc)
		{
			entity->CurrencyNo = gcnew String(entityStrc->CurrencyNo);
			entity->CurrencyGroupNo = gcnew String(entityStrc->CurrencyGroupNo);
			entity->TradeRate = entityStrc->TradeRate;
			entity->TradeRate2 = entityStrc->TradeRate2;
			entity->FutureAlg = (DDEnumFutureAlgType)entityStrc->FutureAlg;
			entity->OptionAlg = (DDEnumOptionAlgType)entityStrc->OptionAlg;
		}
		return entity;
	};

	DDPositionSummary^ To_QryPositionSummaryRspField(const TapAPIPositionSummary* entityStrc)
	{
		DDPositionSummary^ entity = gcnew DDPositionSummary();
		if (nullptr != entityStrc)
		{
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo = gcnew String(entityStrc->ContractNo);
			entity->StrikePrice = gcnew String(entityStrc->StrikePrice);
			entity->CallOrPutFlag = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag;
			entity->MatchSide = (DDEnumSideType)entityStrc->MatchSide;
			entity->PositionPrice = entityStrc->PositionPrice;
			entity->PositionQty = entityStrc->PositionQty;
			entity->HisPositionQty = entityStrc->HisPositionQty;
		}
		return entity;
	};

	DDPositionInfo^ To_QryPositionRspField(const TapAPIPositionInfo* entityStrc)
	{
		DDPositionInfo^ entity = gcnew DDPositionInfo();
		if (nullptr != entityStrc)
		{
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo = gcnew String(entityStrc->ContractNo);
			entity->StrikePrice = gcnew String(entityStrc->StrikePrice);
			entity->CallOrPutFlag = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag;
			entity->MatchSide = (DDEnumSideType)entityStrc->MatchSide;
			entity->HedgeFlag = (DDEnumHedgeFlagType)entityStrc->HedgeFlag;
			entity->PositionNo = gcnew String(entityStrc->PositionNo);
			entity->ServerFlag = entityStrc->ServerFlag;
			entity->OrderNo = gcnew String(entityStrc->OrderNo);
			entity->MatchNo = gcnew String(entityStrc->MatchNo);
			entity->UpperNo = gcnew String(entityStrc->UpperNo);
			entity->PositionPrice = entityStrc->PositionPrice;
			entity->PositionQty = entityStrc->PositionQty;
			entity->PositionStreamId = entityStrc->PositionStreamId;
			entity->CommodityCurrencyGroup = gcnew String(entityStrc->CommodityCurrencyGroup);
			entity->CommodityCurrency = gcnew String(entityStrc->CommodityCurrency);
			entity->CalculatePrice = entityStrc->CalculatePrice;
			entity->AccountInitialMargin = entityStrc->AccountInitialMargin;
			entity->AccountMaintenanceMargin = entityStrc->AccountMaintenanceMargin;
			entity->UpperInitialMargin = entityStrc->UpperInitialMargin;
			entity->UpperMaintenanceMargin = entityStrc->UpperMaintenanceMargin;
			entity->PositionProfit = entityStrc->PositionProfit;
			entity->LMEPositionProfit = entityStrc->LMEPositionProfit;
			entity->OptionMarketValue = entityStrc->OptionMarketValue;
			entity->IsHistory = (DDEnumYNFlag)entityStrc->IsHistory;
		}
		return entity;
	};

	DDFillInfo^ To_QryFillRspField(const TapAPIFillInfo* entityStrc)
	{
		DDFillInfo^ entity = gcnew DDFillInfo();
		if (nullptr != entityStrc)
		{
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo = gcnew String(entityStrc->ContractNo);
			entity->StrikePrice = gcnew String(entityStrc->StrikePrice);
			entity->CallOrPutFlag = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag;
			entity->MatchSource = (DDEnumMatchSourceType)entityStrc->MatchSource;
			entity->MatchSide = (DDEnumSideType)entityStrc->MatchSide;
			entity->PositionEffect = (DDEnumPositionEffectType)entityStrc->PositionEffect;
			entity->ServerFlag = entityStrc->ServerFlag;
			entity->OrderNo = gcnew String(entityStrc->OrderNo);
			entity->MatchNo = gcnew String(entityStrc->MatchNo);
			entity->UpperMatchNo = gcnew String(entityStrc->UpperMatchNo);
			entity->ExchangeMatchNo = gcnew String(entityStrc->ExchangeMatchNo);
			entity->MatchDateTime = gcnew String(entityStrc->MatchDateTime);
			entity->UpperMatchDateTime = gcnew String(entityStrc->UpperMatchDateTime);
			entity->UpperNo = gcnew String(entityStrc->UpperNo);
			entity->MatchPrice = entityStrc->MatchPrice;
			entity->MatchQty = entityStrc->MatchQty;
			entity->IsDeleted = (DDEnumYNFlag)entityStrc->IsDeleted;
			entity->IsAddOne = (DDEnumYNFlag)entityStrc->IsAddOne;
			entity->FeeCurrencyGroup = gcnew String(entityStrc->FeeCurrencyGroup);
			entity->FeeCurrency = gcnew String(entityStrc->FeeCurrency);
			entity->FeeValue = entityStrc->FeeValue;
			entity->IsManualFee = (DDEnumYNFlag)entityStrc->IsManualFee;
			entity->ClosePrositionPrice = entityStrc->ClosePrositionPrice;
		}
		return entity;
	};


	DDPositionProfitNotice^ To_RtnPositionProfitField(const TapAPIPositionProfitNotice* entityStrc)
	{
		DDPositionProfitNotice^ entity = gcnew DDPositionProfitNotice();
		entity->Data = gcnew  DDPositionProfit();
		if (nullptr != entityStrc)
		{
			entity->IsLast = (DDEnumYNFlag)entityStrc->IsLast;
			if (nullptr != entityStrc->Data) {
				entity->Data->PositionNo = gcnew String(entityStrc->Data->PositionNo);
				entity->Data->PositionStreamId = (entityStrc->Data->PositionStreamId);
				entity->Data->PositionProfit = (entityStrc->Data->PositionProfit);
				entity->Data->LMEPositionProfit = (entityStrc->Data->LMEPositionProfit);
				entity->Data->OptionMarketValue = (entityStrc->Data->OptionMarketValue);
				entity->Data->CalculatePrice = (entityStrc->Data->CalculatePrice);
			}
		}
		return entity;
	};

	DDOrderInfo^ To_QryOrderRspField(const TapAPIOrderInfo* entityStrc)
	{
		DDOrderInfo^ entity = gcnew DDOrderInfo();
		if (nullptr != entityStrc)
		{
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo = gcnew String(entityStrc->ContractNo);
			entity->StrikePrice = gcnew String(entityStrc->StrikePrice);
			entity->CallOrPutFlag = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag;
			entity->ContractNo2 = gcnew String(entityStrc->ContractNo2);
			entity->StrikePrice2 = gcnew String(entityStrc->StrikePrice2);
			entity->CallOrPutFlag2 = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag2;
			entity->OrderType = (DDEnumOrderTypeType)entityStrc->OrderType;
			entity->OrderSource = (DDEnumOrderSourceType)entityStrc->OrderSource;
			entity->TimeInForce = (DDEnumTimeInForceType)entityStrc->TimeInForce;
			entity->ExpireTime = gcnew String(entityStrc->ExpireTime);
			entity->IsRiskOrder = (DDEnumYNFlag)entityStrc->IsRiskOrder;
			entity->OrderSide = (DDEnumSideType)entityStrc->OrderSide;
			entity->PositionEffect = (DDEnumPositionEffectType)entityStrc->PositionEffect;
			entity->PositionEffect2 = (DDEnumPositionEffectType)entityStrc->PositionEffect2;
			entity->InquiryNo = gcnew String(entityStrc->InquiryNo);
			entity->HedgeFlag = (DDEnumHedgeFlagType)entityStrc->HedgeFlag;
			entity->OrderPrice = entityStrc->OrderPrice;
			entity->OrderPrice2 = entityStrc->OrderPrice2;
			entity->StopPrice = entityStrc->StopPrice;
			entity->OrderQty = entityStrc->OrderQty;
			entity->OrderMinQty = entityStrc->OrderMinQty;
			entity->RefInt = entityStrc->RefInt;
			entity->RefDouble = entityStrc->RefDouble;
			entity->RefString = gcnew String(entityStrc->RefString);
			entity->MinClipSize = entityStrc->MinClipSize;
			entity->MaxClipSize = entityStrc->MaxClipSize;
			entity->LicenseNo = gcnew String(entityStrc->LicenseNo);
			entity->ServerFlag = entityStrc->ServerFlag;
			entity->OrderNo = gcnew String(entityStrc->OrderNo);
			entity->ClientOrderNo = gcnew String(entityStrc->ClientOrderNo);
			entity->ClientID = gcnew String(entityStrc->ClientID);
			entity->TacticsType = (DDEnumTacticsTypeType)entityStrc->TacticsType;
			entity->TriggerCondition = (DDEnumTriggerConditionType)entityStrc->TriggerCondition;
			entity->TriggerPriceType = (DDEnumTriggerPriceTypeType)entityStrc->TriggerPriceType;
			entity->AddOneIsValid = (DDEnumYNFlag)entityStrc->AddOneIsValid;
			entity->ClientLocalIP = gcnew String(entityStrc->ClientLocalIP);
			entity->ClientMac = gcnew String(entityStrc->ClientMac);
			entity->ClientIP = gcnew String(entityStrc->ClientIP);
			entity->OrderStreamID = entityStrc->OrderStreamID;
			entity->UpperNo = gcnew String(entityStrc->UpperNo);
			entity->UpperChannelNo = gcnew String(entityStrc->UpperChannelNo);
			entity->OrderLocalNo = gcnew String(entityStrc->OrderLocalNo);
			entity->UpperStreamID = entityStrc->UpperStreamID;
			entity->OrderSystemNo = gcnew String(entityStrc->OrderSystemNo);
			entity->OrderExchangeSystemNo = gcnew String(entityStrc->OrderExchangeSystemNo);
			entity->OrderParentSystemNo = gcnew String(entityStrc->OrderParentSystemNo);
			entity->OrderInsertUserNo = gcnew String(entityStrc->OrderInsertUserNo);
			entity->OrderInsertTime = gcnew String(entityStrc->OrderInsertTime);
			entity->OrderCommandUserNo = gcnew String(entityStrc->OrderCommandUserNo);
			entity->OrderUpdateUserNo = gcnew String(entityStrc->OrderUpdateUserNo);
			entity->OrderUpdateTime = gcnew String(entityStrc->OrderUpdateTime);
			entity->OrderState = (DDEnumOrderStateType)entityStrc->OrderState;
			entity->OrderMatchPrice = entityStrc->OrderMatchPrice;
			entity->OrderMatchPrice2 = entityStrc->OrderMatchPrice2;
			entity->OrderMatchQty = entityStrc->OrderMatchQty;
			entity->OrderMatchQty2 = entityStrc->OrderMatchQty2;
			entity->ErrorCode = entityStrc->ErrorCode;
			entity->ErrorText = gcnew String(entityStrc->ErrorText);
			entity->IsBackInput = (DDEnumYNFlag)entityStrc->IsBackInput;
			entity->IsDeleted = (DDEnumYNFlag)entityStrc->IsDeleted;
			entity->IsAddOne = (DDEnumYNFlag)entityStrc->IsAddOne;
		}
		return entity;
	};

	DDOrderActionRsp^ To_QryOrderRspField_2(const TapAPIOrderActionRsp* entityStrc)
	{
		DDOrderActionRsp^ entity = gcnew DDOrderActionRsp();
		if (nullptr != entityStrc)
		{
			entity->ActionType = (DDEnumOrderAct)entityStrc->ActionType;
			if (nullptr != entityStrc->OrderInfo)
			{
				entity->OrderInfo = To_QryOrderRspField(entityStrc->OrderInfo);
			}
		}
		return entity;
	}



	DDOrderInfoNotice^ To_QryOrderRspField_3(const TapAPIOrderInfoNotice* entityStrc)
	{
		DDOrderInfoNotice^ entity = gcnew DDOrderInfoNotice();
		if (nullptr != entityStrc)
		{
			entity->SessionID = entityStrc->SessionID;
			entity->ErrorCode = entityStrc->ErrorCode;
			if (nullptr != entityStrc->OrderInfo)
			{
				entity->OrderInfo = To_QryOrderRspField(entityStrc->OrderInfo);
			}
		}
		return entity;
	}

	DDTradeContractInfo^ To_QryContractRspField(const TapAPITradeContractInfo* entityStrc)
	{
		DDTradeContractInfo^ entity = gcnew DDTradeContractInfo();
		if (nullptr != entityStrc)
		{
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->ContractNo1 = gcnew String(entityStrc->ContractNo1);
			entity->StrikePrice1 = gcnew String(entityStrc->StrikePrice1);
			entity->CallOrPutFlag1 = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag1;
			entity->ContractNo2 = gcnew String(entityStrc->ContractNo2);
			entity->StrikePrice2 = gcnew String(entityStrc->StrikePrice2);
			entity->CallOrPutFlag2 = (DDEnumCallOrPutFlagType)entityStrc->CallOrPutFlag2;
			entity->ContractType = (DDEnumContractTypeType)entityStrc->ContractType;
			entity->QuoteUnderlyingContract = gcnew String(entityStrc->QuoteUnderlyingContract);
			entity->ContractName = gcnew String(entityStrc->ContractName);
			entity->ContractExpDate = gcnew String(entityStrc->ContractExpDate);
			entity->LastTradeDate = gcnew String(entityStrc->LastTradeDate);
			entity->FirstNoticeDate = gcnew String(entityStrc->FirstNoticeDate);
		}
		return entity;
	};

	DDCommodityInfo^ To_QryCommodityRspField(const TapAPICommodityInfo* entityStrc)
	{
		DDCommodityInfo^ entity = gcnew DDCommodityInfo();
		if (nullptr != entityStrc)
		{
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->CommodityType = (DDEnumCommodityType)entityStrc->CommodityType;
			entity->CommodityNo = gcnew String(entityStrc->CommodityNo);
			entity->CommodityName = gcnew String(entityStrc->CommodityName);
			entity->CommodityEngName = gcnew String(entityStrc->CommodityEngName);
			entity->RelateExchangeNo = gcnew String(entityStrc->RelateExchangeNo);
			entity->RelateCommodityType = (DDEnumCommodityType)entityStrc->RelateCommodityType;
			entity->RelateCommodityNo = gcnew String(entityStrc->RelateCommodityNo);
			entity->RelateExchangeNo2 = gcnew String(entityStrc->RelateExchangeNo2);
			entity->RelateCommodityType2 = (DDEnumCommodityType)entityStrc->RelateCommodityType2;
			entity->RelateCommodityNo2 = gcnew String(entityStrc->RelateCommodityNo2);
			entity->CurrencyGroupNo = gcnew String(entityStrc->CurrencyGroupNo);
			entity->TradeCurrency = gcnew String(entityStrc->TradeCurrency);
			entity->ContractSize = entityStrc->ContractSize;
			entity->OpenCloseMode = (DDEnumOpenCloseModeType)entityStrc->OpenCloseMode;
			entity->StrikePriceTimes = entityStrc->StrikePriceTimes;
			entity->CommodityTickSize = entityStrc->CommodityTickSize;
			entity->CommodityDenominator = entityStrc->CommodityDenominator;
			entity->CmbDirect = (DDEnumCmbDirectType)entityStrc->CmbDirect;
			entity->DeliveryMode = (DDEnumDeliveryModeType)entityStrc->DeliveryMode;
			entity->DeliveryDays = entityStrc->DeliveryDays;
			entity->AddOneTime = gcnew String(entityStrc->AddOneTime);
			entity->CommodityTimeZone = entityStrc->CommodityTimeZone;
			entity->IsAddOne = (DDEnumYNFlag)entityStrc->IsAddOne;
		}
		return entity;
	};

	DDExchangeInfo^ To_QryExchangeRspField(const TapAPIExchangeInfo* entityStrc)
	{
		DDExchangeInfo^ entity = gcnew DDExchangeInfo();
		if (nullptr != entityStrc)
		{
			entity->ExchangeNo = gcnew String(entityStrc->ExchangeNo);
			entity->ExchangeName = gcnew String(entityStrc->ExchangeName);
		}
		return entity;
	};

	DDFundData^ To_QryFundRspField(const TapAPIFundData* entityStrc)
	{
		DDFundData^ entity = gcnew DDFundData();
		if (nullptr != entityStrc)
		{
			entity->AccountNo = gcnew String(entityStrc->AccountNo);
			entity->CurrencyGroupNo = gcnew String(entityStrc->CurrencyGroupNo);
			entity->CurrencyNo = gcnew String(entityStrc->CurrencyNo);
			entity->TradeRate = entityStrc->TradeRate;
			entity->FutureAlg = (DDEnumFutureAlgType)entityStrc->FutureAlg;
			entity->OptionAlg = (DDEnumOptionAlgType)entityStrc->OptionAlg;
			entity->PreBalance = entityStrc->PreBalance;
			entity->PreUnExpProfit = entityStrc->PreUnExpProfit;
			entity->PreLMEPositionProfit = entityStrc->PreLMEPositionProfit;
			entity->PreEquity = entityStrc->PreEquity;
			entity->PreAvailable1 = entityStrc->PreAvailable1;
			entity->PreMarketEquity = entityStrc->PreMarketEquity;
			entity->CashInValue = entityStrc->CashInValue;
			entity->CashOutValue = entityStrc->CashOutValue;
			entity->CashAdjustValue = entityStrc->CashAdjustValue;
			entity->CashPledged = entityStrc->CashPledged;
			entity->FrozenFee = entityStrc->FrozenFee;
			entity->FrozenDeposit = entityStrc->FrozenDeposit;
			entity->AccountFee = entityStrc->AccountFee;
			entity->SwapInValue = entityStrc->SwapInValue;
			entity->SwapOutValue = entityStrc->SwapOutValue;
			entity->PremiumIncome = entityStrc->PremiumIncome;
			entity->PremiumPay = entityStrc->PremiumPay;
			entity->CloseProfit = entityStrc->CloseProfit;
			entity->FrozenFund = entityStrc->FrozenFund;
			entity->UnExpProfit = entityStrc->UnExpProfit;
			entity->ExpProfit = entityStrc->ExpProfit;
			entity->PositionProfit = entityStrc->PositionProfit;
			entity->LmePositionProfit = entityStrc->LmePositionProfit;
			entity->OptionMarketValue = entityStrc->OptionMarketValue;
			entity->AccountIntialMargin = entityStrc->AccountIntialMargin;
			entity->AccountMaintenanceMargin = entityStrc->AccountMaintenanceMargin;
			entity->UpperInitalMargin = entityStrc->UpperInitalMargin;
			entity->UpperMaintenanceMargin = entityStrc->UpperMaintenanceMargin;
			entity->Discount = entityStrc->Discount;
			entity->Balance = entityStrc->Balance;
			entity->Equity = entityStrc->Equity;
			entity->Available = entityStrc->Available;
			entity->CanDraw = entityStrc->CanDraw;
			entity->MarketEquity = entityStrc->MarketEquity;
			entity->AuthMoney = entityStrc->AuthMoney;
		}
		return entity;
	};











};
